using CodeFirstwithRelation.Models;

namespace CodeFirstwithRelation.Repository
{
    public interface IProductRepository
    {
        Task<Product1> AddProduct(Product1 product);
       Task<List<Supplier>> GetAllSupplier();

       
        
    }
}
