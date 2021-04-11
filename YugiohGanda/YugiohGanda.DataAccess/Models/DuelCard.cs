using YugiohGanda.Core.Common;

namespace YugiohGanda.Core.Models
{
    public class DuelCard : BaseEntity
    {
        public int Id { get; set; }

        public int DuelId { get; set; }

        public int CardId { get; set; }

        public Duel Duel { get; set; }

        public Card Card { get; set; }

        public DuelCardStatus DuelCardStatus { get; set; } 
    }
}
