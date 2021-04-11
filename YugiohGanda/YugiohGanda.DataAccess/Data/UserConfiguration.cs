using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YugiohGanda.Core.Models;

namespace YugiohGanda.Core.Data
{
    internal class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");

            builder.HasOne(d => d.CurrentDeck)
             .WithOne()
             .HasForeignKey<User>();
        }
    }
}