using CoffeeRegistrationLab.Models;
using Microsoft.EntityFrameworkCore;

namespace CoffeeRegistrationLab.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options)
        {
            
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
