using AutoMapper;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Threading.Tasks;
using YugiohGanda.Core.Dtos;
using YugiohGanda.Core.Models;
using YugiohGanda.Core.Repositories.Sql;

namespace YugiohGanda.Core.Services
{
    public class DeckService
    {
        private readonly DeckRepository _repository;
        private readonly IMapper _mapper;
        private readonly AuthenticationStateProvider _authenticationStateProvider;

        public DeckService(DeckRepository repository, IMapper mapper, 
            AuthenticationStateProvider authenticationStateProvider,
            UserManager<User> )
        {
            _repository = repository;
            _mapper = mapper;
            _authenticationStateProvider = authenticationStateProvider;
        }

        public async Task<int> Create(DeckDto deckDto)
        {
            var deck = _mapper.Map<DeckDto, Deck>(deckDto);

            deck.CreatedAt = DateTime.Now;

            var user = await _authenticationStateProvider.GetAuthenticationStateAsync();
            user.User.
            return await _repository.Create(deck);
        }

        public async Task<DeckDto> GetById(int id)
        {
            var deck = await _repository.GetById(id);
            return _mapper.Map<Deck, DeckDto>(deck);
        }

        public async Task<DeckDto> GetByUser()
        {
            var deck = await _repository.GetById(id);
            return _mapper.Map<Deck, DeckDto>(deck);
        }


    }
}
