using Microsoft.EntityFrameworkCore;

namespace TMDB.Data
{
    public class AppDbContext:DbContext 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(
    "Server=DESKTOP-PFDIES0\\SQLEXPRESS;Database=TMDB;Trusted_Connection=True;TrustServerCertificate=True;"
);

        }
        public DbSet <Entities.Users> Users { get; set; }
    }
    

}
