
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AspNetCoreHero.Results;
using AutoMapper;
using DesafioJordanRodriguesApiRest.Application.Interfaces;
using MediatR;

namespace DesafioJordanRodriguesApiRest.Application.Features.Command
{
    public class GetListAsyncUserQuery : UserResponse, IRequest<Result<List<UserResponse>>>
    {
    }
    public class GetListAsyncUserQueryHandler : IRequestHandler<GetListAsyncUserQuery, Result<List<UserResponse>>>
    {
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;
        
        public GetListAsyncUserQueryHandler(IUserRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<Result<List<UserResponse>>> Handle(GetListAsyncUserQuery request, CancellationToken cancellationToken)
        {
            var users = await _repository.GetListAsync();
            var mappedUsers = _mapper.Map<List<UserResponse>>(users);
            return Result<List<UserResponse>>.Success(mappedUsers);
        }
    }

}