using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace YugiohGnd.Models
{
    public class AppDbContext: IdentityDbContext<ApplicationUser>
    {
        public DbSet<Country> Countries { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    }
}
