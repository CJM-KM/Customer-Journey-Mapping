using Microsoft.EntityFrameworkCore;
using CustomerJourney.API.Models;

namespace CustomerJourney.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Journey> Journeys { get; set; }
        public DbSet<Touchpoint> Touchpoints { get; set; }
    }
}
// using Microsoft.EntityFrameworkCore;
// using CustomerJourney.API.Models;

// namespace CustomerJourney.API.Data
// {
//     public class AppDbContext : DbContext
//     {
//         public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

//         // Add your DbSets here
//         public DbSet<Journey> Journeys { get; set; } // Example table
//     }
// }
