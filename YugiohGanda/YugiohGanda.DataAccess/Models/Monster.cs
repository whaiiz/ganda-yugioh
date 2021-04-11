using YugiohGanda.Core.Common;

namespace YugiohGanda.Core.Models
{
    public class Monster
    {
        public int AttackPoints { get; set; }

        public int DefensePoints { get; set; }

        public int Level { get; set; }

        public MonsterAttribute MonsterAttribute { get; set; }
        
        public MonsterType MonsterType { get; set; }
    }
}
