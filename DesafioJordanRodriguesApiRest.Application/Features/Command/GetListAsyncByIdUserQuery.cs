
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AspNetCoreHero.Results;
using AutoMapper;
using DesafioJordanRodriguesApiRest.Application.Interfaces;
using MediatR;

namespace DesafioJordanRodriguesApiRest.Application.Features.Command
{
    public class GetListAsyncByIdUserQuery : UserResponse, IRequest<Result<GenericResponse>>
    {
        public int IdUser { get; set; }
    }
    public class GetListAsyncByIdUserQueryHandler : IRequestHandler<GetListAsyncByIdUserQuery, Result<GenericResponse>>
    {
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;
        
        public GetListAsyncByIdUserQueryHandler(IUserRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<Result<GenericResponse>> Handle(GetListAsyncByIdUserQuery request, CancellationToken cancellationToken)
        {
            var users = await _repository.GetByIdAsync(request.IdUser);
            var mappedUsers = _mapper.Map<UserResponse>(users);
            var result = new GenericResponse() {Id = mappedUsers.Id, UserName= mappedUsers.Firstname +" " + mappedUsers.Surname
                , UserNameAdvisor = mappedUsers.Advisor.Firstname + " " + mappedUsers.Advisor.Surname
                , CreateDate= mappedUsers.Created
            };
            return Result<GenericResponse>.Success(result);
        }
    }

}