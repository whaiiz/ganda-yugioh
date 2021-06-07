using AutoMapper;
using YugiohGanda.Core.Dtos;
using YugiohGanda.Core.Models;

namespace YugiohGanda.Core
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Deck, DeckDto>();
        }

    }
}
