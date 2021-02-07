using AutoMapper;
using YugiohGnd.Models;
using YugiohGnd.Models.Dtos;

namespace YugiohGnd
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Country, CountryDto>();
        }
    }
}