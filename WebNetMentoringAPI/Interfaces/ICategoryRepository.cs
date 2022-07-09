using WebNetMentoringAPI.Models;

namespace WebNetMentoringAPI.Interfaces
{
    public interface ICategoryRepository
    {
        ICollection<Category> GetCategories();
    }
}
