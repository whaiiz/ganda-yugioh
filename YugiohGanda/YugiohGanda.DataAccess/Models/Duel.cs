using System.Collections.Generic;
using YugiohGanda.Core.Common;

namespace YugiohGanda.Core.Models
{
    public class Duel : BaseEntity
    {
        public int Id { get; set; }

        public int Player1Life { get; set; }

        public int Player2Life { get; set; }

        public string Player1Id { get; set; }

        public string Player2Id { get; set; }

        public User Player1 { get; set; }

        public User Player2 { get; set; }

        public DuelStatus DuelStatus { get; set; } 

        public ICollection<DuelCard> DuelCards { get; set; }
    }
}
