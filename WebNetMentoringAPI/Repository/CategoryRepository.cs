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

        public bool CreateCategory(Category category)
        {
            _context.Add(category);

            return Save();
        }

        public bool UpdateCategory(Category category)
        {
            _context.Update(category);
            return Save();
        }

        public bool DeleteCategory(Category category)
        {
            _context.Remove(category);
            return Save();
        }

        public ICollection<Category> GetCategories()
        {
            return _context.Categories.OrderBy(c => c.Id).ToList();
        }

        public Category GetCategoryById(int id)
        {
            return _context.Categories.Where(c => c.Id == id).FirstOrDefault();
        }

        public Category GetCategory(string name)
        {
            return _context.Categories.Where(c => c.Name == name).FirstOrDefault();
        }

        public bool CategoryExists(int id)
        {
            return _context.Categories.Any(c => c.Id == id);
        }

        public bool Save()
        {
            var save = _context.SaveChanges();

            return save > 0 ? true : false;
        }
    }
}
