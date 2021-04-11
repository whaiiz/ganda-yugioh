using System.Collections.Generic;

namespace YugiohGanda.Core.Models 
{ 
    public abstract class Card : BaseEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Price { get; set; }

        public string Image { get; set; }

        public string ImageSmall { get; set; }

        public string UserId { get; set; }

        public User User { get; set; }

        public ICollection<DeckCard> DeckCards { get; set; }

        public ICollection<DuelCard> DuelCards { get; set; }
    }   
}
