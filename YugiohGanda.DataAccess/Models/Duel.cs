using YugiohGanda.Core.Common;

namespace YugiohGanda.Core.Models
{
    public class Duel
    {
        public int Id { get; set; }

        public int? DuelUser1Id { get; set; }

        public int? DuelUser2Id { get; set; }

        public DuelUser DuelUser1 { get; set; }

        public DuelUser DuelUser2 { get; set; }

        public DuelStatus DuelStatus { get; set; } 
    }
}
