using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebNetMentoringProject.Models
{
    public partial class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Categories Name is required")]
        [StringLength(50)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [StringLength(25)]
        public string Description { get; set; }

        public string Picture { get; set; }

        public virtual Product? Product { get; set; }
    }
}
