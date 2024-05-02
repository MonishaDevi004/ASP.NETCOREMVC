
using Microsoft.EntityFrameworkCore;
using NorthwindAppDb.Models;
using NorthwindAppDb.ViewModel;
using System.Collections.Generic;   

namespace NorthwindAppDb.Repository
{
    public class ProductService : IProductRepository
    {
        private readonly NorthwindContext _context;
       
        public ProductService(NorthwindContext context) {

            _context = context;
        }
        /*  public async Task<List<ProductSupplierVM>> GetProductSupplier()
          {
              dynamic ProductSupplierdata =  (from product in _context.Products join
                                         supplier in _context.Suppliers on 
                                         product.SupplierId equals supplier.SupplierId
                                         select new {supplier.CompanyName ,product.ProductName,product.UnitPrice }).ToList();

              List<ProductSupplierVM> productSupplierVMs = new List<ProductSupplierVM>();
              productSupplierVMs.AddRange(ProductSupplierdata);


              return ProductSupplierdata;
          }*/


        public dynamic GetProductSupplier()
        {
            dynamic ProductSupplierdata = (from product in _context.Products
                                           join
                                       supplier in _context.Suppliers on
                                       product.SupplierId equals supplier.SupplierId
                                           select new { supplier.CompanyName, product.ProductId, product.ProductName, product.UnitPrice }).ToList();

           

            return ProductSupplierdata;
        }
        //calling the stored procedure
       public List<Ten_Most_Expensive_Products> GetMostExpensiveProducts()
        {
          List<Ten_Most_Expensive_Products> ten_Most_Expensive_Products =  _context.Ten_Most_Expensive_Products.FromSqlRaw("[dbo].[Ten Most Expensive Products]").ToList();
            return ten_Most_Expensive_Products;
        
        }

       

        //GetAllProduct

        public async Task<List<Product>> GetProducts()
        {
          List<Product> products =  _context.Products.ToList();

            return products;
        }
    }
}
