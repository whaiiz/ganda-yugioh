using System.Collections.Generic;

namespace YugiohGanda.Core.Models
{
    public class Deck : BaseEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string UserId { get; set; }

        public User User { get; set; }

        public ICollection<DeckCard> DeckCards { get; set; }
    }
}
