using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YugiohGanda.Core.Models;

namespace YugiohGanda.Core.Data
{
    internal class DuelConfiguration : IEntityTypeConfiguration<Duel>
    {
        public void Configure(EntityTypeBuilder<Duel> builder)
        {
            builder.ToTable("Duels");

            builder.HasOne(d => d.DuelUser1)
                .WithMany()
                .HasForeignKey(d => d.DuelUser1Id)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(d => d.DuelUser2)
                .WithMany()
                .HasForeignKey(d => d.DuelUser2Id)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}