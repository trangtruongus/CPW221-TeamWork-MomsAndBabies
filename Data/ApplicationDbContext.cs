using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CPW221_MomsAndBabies.Models;

namespace CPW221_MomsAndBabies.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<CPW221_MomsAndBabies.Models.Customer> Customer { get; set; } = default!;
        public DbSet<CPW221_MomsAndBabies.Models.Location> Location { get; set; } = default!;
        public DbSet<CPW221_MomsAndBabies.Models.Vendor> Vendor { get; set; } = default!;
    }
}