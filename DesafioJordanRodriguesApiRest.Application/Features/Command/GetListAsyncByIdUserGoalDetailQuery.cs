
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
    public class GetListAsyncByIdUserGoalDetailQuery : UserResponse, IRequest<Result<List<GoalDetailResponse>>>
    {
        public int IdUser { get; set; }
        public int IdGoal { get; set; }
        public DateTime Date { get; set; }
    }
    public class GetListAsyncByIdUserGoalDetailQueryHandler : IRequestHandler<GetListAsyncByIdUserGoalDetailQuery, Result<List<GoalDetailResponse>>>
    {
        private readonly IUserRepository _repository;
        
        public GetListAsyncByIdUserGoalDetailQueryHandler(IUserRepository repository, IMapper mapper)
        {
            _repository = repository;
        }
        public async Task<Result<List<GoalDetailResponse>>> Handle(GetListAsyncByIdUserGoalDetailQuery request, CancellationToken cancellationToken)
        {
            var GoalDetail = await _repository.GetListGoalDetailAsync(request.IdUser,request.IdGoal);
            return Result<List<GoalDetailResponse>>.Success(GoalDetail);
        }
    }

}