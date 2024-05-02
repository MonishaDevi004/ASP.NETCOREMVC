using NorthwindAppDb.Models;

namespace NorthwindAppDb.Repository
{
    public interface ICatagoryRepository
    {

        Task<List<Category>> GetCategory();

        Task<Category> GetCategoryById(int id);

      


    }
}
