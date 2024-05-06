using Microsoft.EntityFrameworkCore;

namespace CodeFirstwithRelation.Models
{
    public class CartContext :DbContext
    {
        public CartContext() { }
        public CartContext(DbContextOptions<CartContext> options) : base(options) { }

        public DbSet<Supplier> Suppliers { get; set; }

        public DbSet<Product1> Products { get; set; }
    }
}
