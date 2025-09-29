using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;
namespace WebApplication1.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Category> categories {  get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=localhost;Database=MVC;Trusted_Connection=true;TrustServerCertificate=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Tariq 1" },
                new Category { Id = 2, Name = "Tariq 2" },
                new Category { Id = 3, Name = "Tariq 3" }
                );
        }
    }
}
