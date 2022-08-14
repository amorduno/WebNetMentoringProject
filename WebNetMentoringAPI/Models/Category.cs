using System;
using System.Collections.Generic;

namespace WebNetMentoringAPI.Models
{
    public partial class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Picture { get; set; }
        public virtual Product Product { get; set; }
    }
}
