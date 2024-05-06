using Microsoft.EntityFrameworkCore;

namespace ShoppingApp.Models
{
    public class ShoppingDbContext : DbContext
    {
        public ShoppingDbContext(DbContextOptions<ShoppingDbContext> dbContextOptions):base(dbContextOptions)
        {

        }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Product> Products { get; set; }

    }
}
