using Microsoft.EntityFrameworkCore;
using RunGroopWebApp.Models;

namespace RunWebApp.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
            
        }

        public DbSet<Race> Races { get; set; }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Address> Adresses { get; set; }

    }
}
