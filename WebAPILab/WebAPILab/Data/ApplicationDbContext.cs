using Microsoft.EntityFrameworkCore;
using WebAPILab.Models;

namespace WebAPILab.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(
                new Movie() { Id = 1, Title = "Halloween", Category = "Horror", Year = 1978 },
                new Movie() { Id = 2, Title = "Mr. Brooks", Category = "Drama", Year = 2007},
                new Movie() { Id = 3, Title = "The Princess Bride", Category = "Comedy", Year = 1987},
                new Movie() { Id = 4, Title = "Alien", Category = "Horror", Year = 1979 },
                new Movie() { Id = 5, Title = "Dr. Strangelove", Category = "Comedy", Year = 1964},
                new Movie() { Id = 6, Title = "Pig", Category = "Drama", Year = 2021 }
                );
        }

        public DbSet<Movie> Movies { get; set; }
    }
}
