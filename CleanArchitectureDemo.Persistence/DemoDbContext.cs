using CleanArchitectureDemo.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitectureDemo.Persistence
{
    public class DemoDbContext: DbContext
    {
        
        public DemoDbContext(DbContextOptions<DemoDbContext> options)
            : base(options)
        {

        }

        public DbSet<WeatherForecast> WeatherForecasts { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
      
    }
}
