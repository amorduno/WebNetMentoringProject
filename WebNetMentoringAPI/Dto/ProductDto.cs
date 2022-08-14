using System.ComponentModel.DataAnnotations;
using WebNetMentoringAPI.Models;

namespace WebNetMentoringAPI.Dto
{
    public class ProductDto
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string? Description { get; set; }
        public int? CategoryId { get; set; }
        //public virtual Category oCategory { get; set; }
    }
}
