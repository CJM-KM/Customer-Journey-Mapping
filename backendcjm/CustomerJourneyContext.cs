using Microsoft.EntityFrameworkCore;
using CustomerJourneyAPI.Models;

namespace CustomerJourneyAPI.Data
{
    public class CustomerJourneyContext : DbContext
    {
        public CustomerJourneyContext(DbContextOptions<CustomerJourneyContext> options)
            : base(options)
        {
        }

        public DbSet<Stage> Stages { get; set; }
    }
}
