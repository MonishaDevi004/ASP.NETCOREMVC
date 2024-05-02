using NorthwindAppDb.Models;
using NorthwindAppDb.ViewModel;

namespace NorthwindAppDb.Repository
{
    public interface IProductRepository
    {
      //  Task<List<ProductSupplierVM>> GetProductSupplier();

       dynamic GetProductSupplier();

        //calling the procedure
         List<Ten_Most_Expensive_Products> GetMostExpensiveProducts();

    }
}
