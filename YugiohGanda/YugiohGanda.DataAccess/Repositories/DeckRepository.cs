using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YugiohGanda.Core.Data;
using YugiohGanda.Core.Models;

namespace YugiohGanda.Core.Repositories
{
    public class DeckRepository
    {
        private readonly AppDbContext _context;

        public DeckRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<int> Create(Deck deck)
        {
            var result = await _context.Decks.AddAsync(deck);
            await _context.SaveChangesAsync();
            return result.Entity.Id;
        }

        public async Task<Deck> GetById(int id)
        {
            var deck = await _context.Decks
                .Include(d => d.DeckCards)
                    .ThenInclude(dc => dc.Card)
                .FirstOrDefaultAsync(d => d.Id == id);

            return deck;
        }

        public async Task<ICollection<Deck>> GetByUser(string userId)
        {
            var decks = await _context.Decks.Where(d => d.UserId == userId)
                .Include(d => d.DeckCards)
                    .ThenInclude(dc => dc.Card)
                .ToListAsync();

            return decks;
        }

        public async Task<bool> Update(Deck deck)
        {
            _context.Decks.Update(deck);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> Delete(int id)
        {
            var deck = await _context.Decks.FirstOrDefaultAsync(d => d.Id == id);

            if(deck == null)
            {
                throw new NotFoundException("Deck not found");
            }

            _context.Decks.Remove(deck);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
