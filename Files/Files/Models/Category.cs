using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Files.Models
{
    public class Category
    {
        [Key]
        [Required(ErrorMessage = "CategoryId is required")]
        public int CategoryId { get; set; } // Primary Key

        [Required(ErrorMessage = "Category Name is required")]
        [Display(Name = "Category Name")]
        public string CategoryName { get; set; }

        [Display(Name = "Category Name")]
        public string Description { get; set; }

        // Navigation Properties
        public List<Property> Properties { get; set; }
        // One-to-Many with Properties
    }
}



