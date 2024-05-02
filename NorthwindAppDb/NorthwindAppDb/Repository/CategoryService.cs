using Microsoft.EntityFrameworkCore;
using NorthwindAppDb.Models;

namespace NorthwindAppDb.Repository
{
    public class CategoryService : ICatagoryRepository

    {

        private readonly NorthwindContext _context;
        public CategoryService(NorthwindContext context) {
        
         _context = context;
        }

        //Get All Category
        public async Task<List<Category>> GetCategory()
        {
            return await _context.Categories.ToListAsync();
        }

       public async Task<Category> GetCategoryById(int id)
        {
           Category category = await _context.Categories.FindAsync(id);
            return category;
        }

       

    }
}
