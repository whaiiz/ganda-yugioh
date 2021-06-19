using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using YugiohGanda.Core.Models;

namespace YugiohGanda.Core.Data
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public DbSet<Deck> Decks { get; set; }
        public DbSet<DeckCard> DeckCards { get; set; }
        public DbSet<Monster> Monsters { get; set; }
        public DbSet<SpellTrap> SpellTraps { get; set; }
        public DbSet<Duel> Duels { get; set; }
        public DbSet<DuelUser> DuelUsers { get; set; }
        public DbSet<DuelCard> DuelCards { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MonsterConfiguration());
            modelBuilder.ApplyConfiguration(new DeckConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new DuelConfiguration());


            base.OnModelCreating(modelBuilder);
        }

    }
}
