using System.Collections.Generic;
using System.Threading.Tasks;
using YugiohGanda.Core.Models;

namespace YugiohGanda.Core.Repositories.Interfaces
{
    public interface IDeckRepository
    {
        Task<int> Create(Deck deck);
        Task<Deck> GetById(int id);
        Task<ICollection<Deck>> GetByUser(string userId);
        Task<bool> Update(Deck deck);
        Task<bool> Delete(int id);
    }
}
