using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YugiohGanda.Core.Common;
using YugiohGanda.Core.Models;

namespace YugiohGanda.Core.Data
{
    internal class MonsterConfiguration : IEntityTypeConfiguration<Monster>
    {
        public void Configure(EntityTypeBuilder<Monster> builder)
        {
           builder.HasData(
            new
            {
                Id = 1,
                Name = "Celtic Guardian",
                Description = "An elf who learned to wield a sword, he baffles enemies with lightning - swift attacks.",
                Price = 1000,
                Image = "https://storage.googleapis.com/ygoprodeck.com/pics/91152256.jpg",
                ImageSmall = "https://storage.googleapis.com/ygoprodeck.com/pics_small/91152256.jpg",
                AttackPoints = 1400,
                DefensePoints = 1200,
                Level = 4,
                MonsterAttribute = MonsterAttribute.Earth,
                MonsterType = MonsterType.NormalMonster
            },
            new
            {
                Id = 2,
                Name = "Pale Beast",
                Description = "With skin tinged a bluish-white, this strange creature is a fearsome sight to behold.",
                Price = 1200,
                Image = "https://storage.googleapis.com/ygoprodeck.com/pics/21263083.jpg",
                ImageSmall = "https://storage.googleapis.com/ygoprodeck.com/pics_small/21263083.jpg",
                AttackPoints = 1500,
                DefensePoints = 1200,
                Level = 4,
                MonsterAttribute = MonsterAttribute.Earth,
                MonsterType = MonsterType.NormalMonster
            },
            new
            {
                Id = 3,
                Name = "Baby Dragon",
                Description = "Much more than just a child, this dragon is gifted with untapped power.",
                Price = 900,
                Image = "https://storage.googleapis.com/ygoprodeck.com/pics/88819587.jpg",
                ImageSmall = "https://storage.googleapis.com/ygoprodeck.com/pics_small/88819587.jpg",
                AttackPoints = 1200,
                DefensePoints = 700,
                Level = 3,
                MonsterAttribute = MonsterAttribute.Wind,
                MonsterType = MonsterType.NormalMonster
            },
            new
            {
                Id = 4,
                Name = "Battle Ox",
                Description = "A monster with tremendous power, it destroys enemies with a swing of its axe.",
                Price = 1400,
                Image = "https://storage.googleapis.com/ygoprodeck.com/pics/5053103.jpg",
                ImageSmall = "https://storage.googleapis.com/ygoprodeck.com/pics_small/5053103.jpg",
                AttackPoints = 1700,
                DefensePoints = 1000,
                Level = 4,
                MonsterAttribute = MonsterAttribute.Earth,
                MonsterType = MonsterType.NormalMonster
            },
            new
            {
                Id = 5,
                Name = "Gemini Elf",
                Description = "Elf twins that alternate their attacks.",
                Price = 1600,
                Image = "https://storage.googleapis.com/ygoprodeck.com/pics/69140098.jpg",
                ImageSmall = "https://storage.googleapis.com/ygoprodeck.com/pics_small/69140098.jpg",
                AttackPoints = 1900,
                DefensePoints = 900,
                Level = 4,
                MonsterAttribute = MonsterAttribute.Earth,
                MonsterType = MonsterType.NormalMonster
            },
            new
            {
                Id = 6,
                Name = "Vorse Raider",
                Description = "This wicked Beast-Warrior does every horrid thing imaginable, and loves it! His axe bears the marks of his countless victims.",
                Price = 1700,
                Image = "https://storage.googleapis.com/ygoprodeck.com/pics/14898066.jpg",
                ImageSmall = "https://storage.googleapis.com/ygoprodeck.com/pics_small/14898066.jpg",
                AttackPoints = 1900,
                DefensePoints = 1200,
                Level = 4,
                MonsterAttribute = MonsterAttribute.Dark,
                MonsterType = MonsterType.NormalMonster
            },
            new
            {
                Id = 7,
                Name = "Hunter Dragon",
                Description = "This dragon has taken down countless prey with its sharp fangs. It strikes very quickly, because if it does not strike first it is vulnerable to a counter-attack.",
                Price = 1500,
                Image = "https://storage.googleapis.com/ygoprodeck.com/pics/96005454.jpg",
                ImageSmall = "https://storage.googleapis.com/ygoprodeck.com/pics_small/96005454.jpg",
                AttackPoints = 1700,
                DefensePoints = 100,
                Level = 3,
                MonsterAttribute = MonsterAttribute.Dark,
                MonsterType = MonsterType.NormalMonster
            },
            new
            {
                Id = 8,
                Name = "Mad Lobster",
                Description = "A gourmet food renowned by the Dark World upper crust. It has sensational flavor.",
                Price = 1500,
                Image = "https://storage.googleapis.com/ygoprodeck.com/pics/97240270.jpg",
                ImageSmall = "https://storage.googleapis.com/ygoprodeck.com/pics_small/97240270.jpg",
                AttackPoints = 1700,
                DefensePoints = 1000,
                Level = 3,
                MonsterAttribute = MonsterAttribute.Water,
                MonsterType = MonsterType.NormalMonster
            },
            new            
            {
                Id = 9,
                Name = "Soitsu",
                Description = "Apparently totally unreliable, he wonders if he has incredible potential.",
                Price = 200,
                Image = "https://storage.googleapis.com/ygoprodeck.com/pics/60246171.jpg",
                ImageSmall = "https://storage.googleapis.com/ygoprodeck.com/pics_small/60246171.jpg",
                AttackPoints = 0,
                DefensePoints = 0,
                Level = 3,
                MonsterAttribute = MonsterAttribute.Wind,
                MonsterType = MonsterType.NormalMonster
            },
            new
            {
                Id = 10,
                Name = "Mystic Clown",
                Description = "Nothing can stop the mad attack of this powerful creature.",
                Price = 700,
                Image = "https://storage.googleapis.com/ygoprodeck.com/pics/47060154.jpg",
                ImageSmall = "https://storage.googleapis.com/ygoprodeck.com/pics_small/47060154.jpg",
                AttackPoints = 1500,
                DefensePoints = 1000,
                Level = 4,
                MonsterAttribute = MonsterAttribute.Dark,
                MonsterType = MonsterType.NormalMonster
            }); 
        }
    }
}