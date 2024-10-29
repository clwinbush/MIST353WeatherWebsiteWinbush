
using MIST353WeatherWebsiteAPIS.Data;
using Microsoft.EntityFrameworkCore;
namespace MIST353WeatherWebsiteAPIS.Data
{
    public class DbContextClass : DbContext
    {
        protected readonly IConfiguration Configuration;
        public DbContextClass(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }
        public DbSet<Plant> P { get; set; }

        public DbSet<User> U { get; set; }

        public DbSet<Location> L { get; set; }
    }
}
