
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
    public class GetListAsyncByIdUserGoalQuery : UserResponse, IRequest<Result<List<GoalResponse>>>
    {
        public int IdUser { get; set; }
        public DateTime Date { get; set; }
    }
    public class GetListAsyncByIdUserGoalQueryHandler : IRequestHandler<GetListAsyncByIdUserGoalQuery, Result<List<GoalResponse>>>
    {
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;
        
        public GetListAsyncByIdUserGoalQueryHandler(IUserRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<Result<List<GoalResponse>>> Handle(GetListAsyncByIdUserGoalQuery request, CancellationToken cancellationToken)
        {
            var Goal = await _repository.GetListGoalAsync(request.IdUser);
            return Result<List<GoalResponse>>.Success(Goal);
        }
    }

}