using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebNetMentoringProject.Models
{
    public partial class Product
    {        
        public int Id { get; set; }

        [Required(ErrorMessage = "Product's name is required")]
        [StringLength(25)]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "Description is required")]
        [StringLength(25)]
        public string? Description { get; set; }

        public int? CategoryId { get; set; }

        public virtual Category oCategory { get; set; } = null!;
    }
}
