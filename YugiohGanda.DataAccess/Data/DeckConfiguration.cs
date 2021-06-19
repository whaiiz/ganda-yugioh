using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YugiohGanda.Core.Models;

namespace YugiohGanda.Core.Data
{
    internal class DeckConfiguration : IEntityTypeConfiguration<Deck>
    {
        public void Configure(EntityTypeBuilder<Deck> builder)
        {
            builder.ToTable("Decks");

            builder.HasOne(d => d.User)
             .WithMany(u => u.Decks)
             .HasForeignKey(d => d.UserId);   
        }
    }
}