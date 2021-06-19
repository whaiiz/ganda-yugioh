using System.Collections.Generic;

namespace YugiohGanda.Core.Models
{
    public class DuelUser
    {
        public int Id { get; set; }

        public int Lifepoints { get; set; }

        public int DuelId { get; set; }

        public string UserId { get; set; }

        public Duel Duel { get; set; }

        public User User { get; set; }

        public ICollection<DuelCard> DuelCards { get; set; }
    }
}
