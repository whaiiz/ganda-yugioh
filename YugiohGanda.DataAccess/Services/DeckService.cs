using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using YugiohGanda.Core.Dtos;
using YugiohGanda.Core.Models;
using YugiohGanda.Core.Repositories;

namespace YugiohGanda.Core.Services
{
    public class DeckService
    {
        private readonly DeckRepository _repository;
        private readonly IMapper _mapper;
        private readonly UserRepository _userRepository;

        public DeckService(DeckRepository repository, IMapper mapper,
            UserRepository userRepository)
        {
            _repository = repository;
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public async Task<int> Create(DeckDto deckDto)
        {
            var deck = _mapper.Map<DeckDto, Deck>(deckDto);
            return await _repository.Create(deck);
        }

        public async Task<DeckDto> GetById(int id)
        {
            var deck = await _repository.GetById(id);
            return _mapper.Map<Deck, DeckDto>(deck);
        }

        public async Task<ICollection<DeckDto>> GetByUser()
        {
            var user = await _userRepository.GetUserLoggedIn();
            var decks = await _repository.GetByUser(user.Id);

            return _mapper.Map<ICollection<Deck>, ICollection<DeckDto>>(decks);
        }

        public async Task<bool> Update(DeckDto deckDto)
        {
            var deck = _mapper.Map<DeckDto, Deck>(deckDto);

            try
            {
                return await _repository.Update(deck);
            }
            catch (DbUpdateException)
            {
                return false;
            }
        }

        public async Task<bool> Delete(int id)
        {
            return await _repository.Delete(id);
        }

    }
}