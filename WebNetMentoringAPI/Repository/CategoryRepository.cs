using WebNetMentoringAPI.Interfaces;
using WebNetMentoringAPI.Models;

namespace WebNetMentoringAPI.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DBShopContext _context;
        public CategoryRepository(DBShopContext context)
        {
            _context = context; 
        }

        public ICollection<Category> GetCategories()
        {
            return _context.Categories.OrderBy(c => c.Id).ToList();
        }
    }
}
