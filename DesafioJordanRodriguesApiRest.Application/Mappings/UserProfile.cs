using AutoMapper;
using DesafioJordanRodriguesApiRest.Application.Features;
using DesafioJordanRodriguesApiRest.Application.Features.Command;
using DesafioJordanRodriguesApiRest.Domain.Entities;

namespace DesafioJordanRodriguesApiRest.Application.Mappings
{
    internal class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserResponse, User>().ReverseMap();
            CreateMap<GetListAsyncUserQuery, User>().ReverseMap();
        }
    }
}
