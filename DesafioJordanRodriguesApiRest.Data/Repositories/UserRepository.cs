using DesafioJordanRodriguesApiRest.Application.Interfaces;
using DesafioJordanRodriguesApiRest.Domain.Entities;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using DesafioJordanRodriguesApiRest.Data.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data;
using DesafioJordanRodriguesApiRest.Application.Features;

namespace DesafioJordanRodriguesApiRest.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IRepositoryAsync<User> _repository;
        private readonly IRepositoryAsync<Goal> _repositoryGoal;
        private readonly IRepositoryAsync<Goaltransaction> _repositoryGoalTransaction;
        public IQueryable<User> User => _repository.Entities;
        public UserRepository(IRepositoryAsync<User> repository, IRepositoryAsync<Goal> repositoryGoal, IRepositoryAsync<Goaltransaction> repositoryGoalTransaction)
        {
            _repository = repository;
            _repositoryGoal = repositoryGoal;
            _repositoryGoalTransaction = repositoryGoalTransaction;
        }
        public async Task<User> GetByIdAsync(int id)
        {
            return await _repository.Entities
                .Where(p => p.id == id)
                .Select(a => new User
                {
                    id= a.id,
                    firstname = a.firstname,
                    surname = a.surname,
                    created = a.created,
                    Advisor = a.Advisor
                })
                .FirstOrDefaultAsync();

        }
        public async Task<DataTable> GetSumaryAsync(int id)
        {

            using (var ctx = new ChallengeContext())
            {
                List<DbParameter> parameters = new List<DbParameter>();
                parameters.Add(new NpgsqlParameter() { ParameterName = "@IdUser", Value = id, NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Integer });
                string sqlQuery = @"SELECT sum((public.goaltransactionfunding.quotas)
                                                    * (public.fundingsharevalue.value)
                                                    *(public.currencyindicator.value)) balance,
                                                    sum((public.goaltransaction.amount)
                                                    *(public.currencyindicator.value )) aportes,
                                                    public.fundingsharevalue.date,public.user.id
                                                    FROM public.user inner join public.goal on public.user.id=public.goal.userid
                                                    join public.funding on public.funding.currencyid=public.user.currencyid
                                                    join public.goaltransaction on public.goaltransaction.ownerid=public.user.id
                                                    and public.goaltransaction.currencyid=public.user.currencyid
                                                    join public.goaltransactionfunding on public.goaltransactionfunding.goalid=public.goal.id
                                                    and public.goaltransaction.id= public.goaltransactionfunding.transactionid
                                                    and public.goaltransactionfunding.date=public.goaltransaction.date
                                                    and public.user.id=public.goaltransaction.ownerid
                                                    join public.fundingsharevalue on public.fundingsharevalue.fundingid= public.funding.id
                                                    and  public.fundingsharevalue.date=public.goaltransactionfunding.date
                                                    join public.currencyindicator on public.currencyindicator.sourcecurrencyid=public.user.currencyid
                                                    and public.currencyindicator.date=public.goaltransactionfunding.date
                                                    and public.currencyindicator.sourcecurrencyid=public.goaltransaction.currencyid
                                                    where public.user.id=@IdUser
                                                    group by public.fundingsharevalue.date,public.user.id";
                var query = await EfSqlHelper.ExecuteScalar(ctx, sqlQuery, parameters);
                return  query;
            }
        }
        public async Task<DataTable> GetSumaryDateAsync(int id, DateTime date)
        {

            using (var ctx = new ChallengeContext())
            {
                List<DbParameter> parameters = new();
                parameters.Add(new NpgsqlParameter() { ParameterName = "@IdUser", Value = id , NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Integer });
                parameters.Add(new NpgsqlParameter() { ParameterName = "@Date", Value = date, NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Date });
                string sqlQuery = @"SELECT sum((public.goaltransactionfunding.quotas)
                                                    * (public.fundingsharevalue.value)
                                                    *(public.currencyindicator.value)) balance,
                                                    sum((public.goaltransaction.amount)
                                                    *(public.currencyindicator.value )) aportes,
                                                    public.fundingsharevalue.date,public.user.id
                                                    FROM public.user inner join public.goal on public.user.id=public.goal.userid
                                                    join public.funding on public.funding.currencyid=public.user.currencyid
                                                    join public.goaltransaction on public.goaltransaction.ownerid=public.user.id
                                                    and public.goaltransaction.currencyid=public.user.currencyid
                                                    join public.goaltransactionfunding on public.goaltransactionfunding.goalid=public.goal.id
                                                    and public.goaltransaction.id= public.goaltransactionfunding.transactionid
                                                    and public.goaltransactionfunding.date=public.goaltransaction.date
                                                    and public.user.id=public.goaltransaction.ownerid
                                                    join public.fundingsharevalue on public.fundingsharevalue.fundingid= public.funding.id
                                                    and  public.fundingsharevalue.date=public.goaltransactionfunding.date
                                                    join public.currencyindicator on public.currencyindicator.sourcecurrencyid=public.user.currencyid
                                                    and public.currencyindicator.date=public.goaltransactionfunding.date
                                                    and public.currencyindicator.sourcecurrencyid=public.goaltransaction.currencyid
                                                    where public.user.id=@IdUser and  public.currencyindicator.date= @Date
                                                    group by public.fundingsharevalue.date,public.user.id";
                var query = await EfSqlHelper.ExecuteScalar(ctx, sqlQuery, parameters);
                return query;
            }
        }
        public async Task<List<User>> GetListAsync()
        {
            IQueryable<User> list = _repository.Entities.Include(c => c.Currency);
            return await list.ToListAsync();
        }
        public async Task<List<GoalResponse>> GetListGoalAsync(int id)
        {
           var list = _repositoryGoal.Entities
                .Where(p => p.userid == id)
                .Include(Financialentity => Financialentity.Financialentity)
                .Include(Portfolio => Portfolio.Portfolio)
                .Select(c => new GoalResponse
                {
                    TituloMeta = c.title,
                    Años = c.years,
                    AporteMensaul = c.monthlycontribution,
                    MontoObjetivo = c.targetamount,
                    InversionInicial = c.initialinvestment,
                    EntidadFinanciera = c.Financialentity.title,
                    PortafolioCompleto = c.Portfolio.title,
                    FechaCreacion = c.created
                }).ToListAsync();

            return await list;

        }
        public async Task<List<GoalDetailResponse>> GetListGoalDetailAsync(int idUser, int idGoal)
        {
            IQueryable<GoalDetailResponse> list = (IQueryable<GoalDetailResponse>)_repositoryGoalTransaction.Entities
                 .Where(p => p.ownerid == idUser && p.goalid == idGoal)
                 .Include(Goal => Goal.Goal)
                 .Include(Portfolio => Portfolio.Goal.Portfolio)
                 .Include(Goalcategory => Goalcategory.Goal.Goalcategory)
                  //.ToList()
                  .GroupBy(c => new {
                      Title = c.Goal.title,
                      Years = c.Goal.years,
                      Monthlycontribution = c.Goal.monthlycontribution,
                      Targetamount = c.Goal.targetamount,
                      Initialinvestment = c.Goal.initialinvestment,
                      InancialentityTitle = c.Goal.Financialentity.title,
                      PortfolioTitle = c.Goal.Portfolio.title,
                      Created = c.date,
                      GoalcategoryTitle = c.Goal.Goalcategory.title
                  })
            .Select(c => new GoalDetailResponse
            {
                TituloMeta = c.Key.Title,
                Años = c.Key.Years,
                AporteMensaul = c.Key.Monthlycontribution,
                MontoObjetivo = c.Key.Targetamount,
                InversionInicial = c.Key.Initialinvestment,
                EntidadFinanciera = c.Key.InancialentityTitle,
                PortafolioCompleto = c.Key.PortfolioTitle,
                FechaCreacion = c.Key.Created,
                CategoriaMeta = c.Key.GoalcategoryTitle,
                PorcentajeCumplimientoMeta = ((c.Key.Initialinvestment + c.Key.Monthlycontribution) * 100) / c.Key.Targetamount,
                TotalAportes = (decimal)c.Sum(a => a.amount > 0 ? a.amount : 0),
                TotalRetiro = (decimal)c.Sum(a => a.amount > 0 ? 0 : a.amount)
            });

            return await list.ToListAsync();

        }
    }
}
