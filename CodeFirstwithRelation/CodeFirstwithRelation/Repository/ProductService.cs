using CodeFirstwithRelation.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstwithRelation.Repository
{
    public class ProductService : IProductRepository
    {
        private readonly CartContext _context;

        public ProductService(CartContext _context)
        {
           this._context = _context;
        }

        public  async  Task<Product1> AddProduct(Product1 product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return  product;

        }
       public async Task<List<Supplier>> GetAllSupplier()
        {
           return await _context.Suppliers.ToListAsync();
        }

    }
}
