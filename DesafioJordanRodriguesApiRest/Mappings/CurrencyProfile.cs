using DesafioJordanRodriguesApiRest.Application.Features;
using AutoMapper;
using DesafioJordanRodriguesApiRest.Model;
using DesafioJordanRodriguesApiRest.Application.Features.Command;
using DesafioJordanRodriguesApiRest.Domain.Entities;

namespace DesafioJordanRodriguesApiRest.Mappings
{
    internal class CurrencyProfile : Profile
    {
        public CurrencyProfile()
        {
            CreateMap<CurrencyModel, CurrencyResponse>().ReverseMap();
            CreateMap<CurrencyResponse, CurrencyModel>().ReverseMap();
        }
    }
}
