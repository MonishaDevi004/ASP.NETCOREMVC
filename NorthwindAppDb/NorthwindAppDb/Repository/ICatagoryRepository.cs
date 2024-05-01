using NorthwindAppDb.Models;

namespace NorthwindAppDb.Repository
{
    public interface ICatagoryRepository
    {

        Task<List<Category>> GetCategory();
    }
}
