using WebNetMentoringProject.Models;

namespace WebNetMentoringProject.ViewModel
{
    public class CategoryViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public IFormFile Picture { get; set; }

        public virtual Product? Product { get; set; }
    }
}
