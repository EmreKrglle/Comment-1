using Microsoft.EntityFrameworkCore;
using TMDB.Entities;

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
        public DbSet<AppTasks> Tasks { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppTasks>()
                .HasMany(t => t.Users)
                .WithMany(u => u.Tasks)
                .UsingEntity(j => j.ToTable("UserTasks"));
        }
        public DbSet <Entities.AppTasks> Task { get; set; }
        public DbSet<Entities.User> Users { get; set; }    
    }
    

}
