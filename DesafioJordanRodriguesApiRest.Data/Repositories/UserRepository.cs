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

namespace DesafioJordanRodriguesApiRest.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IRepositoryAsync<User> _repository;
        public IQueryable<User> User => _repository.Entities;
        public UserRepository(IRepositoryAsync<User> repository )
        {
            _repository = repository;
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
                parameters.Add(new NpgsqlParameter() { ParameterName = "@IdUser", Value = id });
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
        public async Task<List<User>> GetListAsync()
        {
            IQueryable<User> list = _repository.Entities.Include(c => c.Currency);
            return await list.ToListAsync();
        }        
    }
}
