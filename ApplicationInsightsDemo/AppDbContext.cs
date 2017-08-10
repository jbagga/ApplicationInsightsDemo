using Microsoft.EntityFrameworkCore;

namespace ApplicationInsightsDemo
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Car> Cars { get; set; }
    }
}