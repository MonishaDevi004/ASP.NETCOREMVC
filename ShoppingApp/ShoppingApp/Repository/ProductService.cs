using Microsoft.EntityFrameworkCore;
using ShoppingApp.Models;

namespace ShoppingApp.Repository
{
    public class ProductService : IProductRepository
    {
        private readonly ShoppingDbContext _context;

        public ProductService(ShoppingDbContext context)
        {
            _context = context;
        }
        public  async Task<Product> AddProduct(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return product;
        }

        public  async Task<List<Supplier>> GetAllSupplier()
        {
            return await _context.Suppliers.ToListAsync();
        }
    }
}
