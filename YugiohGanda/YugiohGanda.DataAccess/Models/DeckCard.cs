namespace YugiohGanda.Core.Models
{
    public class DeckCard : BaseEntity
    {
        public int Id { get; set; }

        public int DeckId { get; set; }

        public int CardId { get; set; }

        public Deck Deck { get; set; }

        public Card Card { get; set; }
    }
}
