using DesafioJordanRodriguesApiRest.Application.Features;
using AutoMapper;
using DesafioJordanRodriguesApiRest.Model;
using DesafioJordanRodriguesApiRest.Application.Features.Command;

namespace DesafioJordanRodriguesApiRest.Mappings
{
    internal class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserResponse, UserModel>().ReverseMap();
            CreateMap<GetListAsyncUserQuery, UserModel>().ReverseMap();

        }
    }
}
