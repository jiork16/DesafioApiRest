using DesafioJordanRodriguesApiRest.Application.Features;
using AutoMapper;
using DesafioJordanRodriguesApiRest.Domain.Entities;

namespace DesafioJordanRodriguesApiRest.Application.Mappings
{
    internal class CurrencyProfile : Profile
    {
        public CurrencyProfile()
        {
            CreateMap<CurrencyResponse, Currency> ().ReverseMap();
        }
    }
}
