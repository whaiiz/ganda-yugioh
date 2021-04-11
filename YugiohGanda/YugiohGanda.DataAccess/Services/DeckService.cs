using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YugiohGanda.Core.Repositories;
using YugiohGanda.Core.Repositories.Interfaces;

namespace YugiohGanda.Core.Services
{
    public class DeckService
    {
        private readonly DeckRepository _repository;

        public DeckService(DeckRepository repository)
        {
            _repository = repository;
        }

        public async Task Create()
        {
            await _repository.Create(new Models.Deck()
            {

            });
        }
    }
}
