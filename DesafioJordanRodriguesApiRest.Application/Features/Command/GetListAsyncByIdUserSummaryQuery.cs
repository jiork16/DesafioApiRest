
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Helpers;
using AspNetCoreHero.Results;
using AutoMapper;
using DesafioJordanRodriguesApiRest.Application.Interfaces;
using MediatR;
using Newtonsoft.Json;

namespace DesafioJordanRodriguesApiRest.Application.Features.Command
{
    public class GetListAsyncByIdUserSummaryQuery : UserResponse, IRequest<Result<List<SumariResponse>>>
    {
        public int IdUser { get; set; }
    }
    public class GetListAsyncByIdUserSummaryQueryHandler : IRequestHandler<GetListAsyncByIdUserSummaryQuery, Result<List<SumariResponse>>>
    {
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;
        
        public GetListAsyncByIdUserSummaryQueryHandler(IUserRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<Result<List<SumariResponse>>> Handle(GetListAsyncByIdUserSummaryQuery request, CancellationToken cancellationToken)
        {
            var users = await _repository.GetSumaryAsync(request.IdUser);
            List<SumariResponse> sumari = new List<SumariResponse>();
            if (users != null)
            {
                foreach (System.Data.DataRow item in users.Rows)
                {
                    SumariResponse sum = new(){ Aportes = (decimal)(double)item[0], Balance = (decimal)(double)item[1], Date = (DateTime)item[2], Userid = (int)item[3]};
                    sumari.Add(sum);
                }
            }
            return Result<List<SumariResponse>>.Success(sumari);
        }
    }

}