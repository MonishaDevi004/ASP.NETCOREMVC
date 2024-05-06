using ShoppingApp.Models;

namespace ShoppingApp.Repository
{
    public interface IProductRepository
    {
        Task<Product> AddProduct(Product product);

        Task<List<Supplier>> GetAllSupplier();

    }
}
