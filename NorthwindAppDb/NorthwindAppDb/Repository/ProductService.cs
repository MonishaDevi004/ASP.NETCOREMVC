
using NorthwindAppDb.Models;

namespace NorthwindAppDb.Repository
{
    public class ProductService : IProductRepository
    {
        private readonly NorthwindContext _context;
       
        public ProductService(NorthwindContext context) {

            _context = context;
        }
        public async Task<dynamic> GetProductSupplier()
        {
            var ProductSupplierdata =  (from product in _context.Products join
                                       supplier in _context.Suppliers on 
                                       product.SupplierId equals supplier.SupplierId
                                       select new {supplier.CompanyName ,product.ProductName,product.UnitPrice }).ToList();

            return ProductSupplierdata;
        }
    }
}
