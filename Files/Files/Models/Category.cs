using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Files.Models
{
    public class Category
    {
        [Key]
        public Int32 CategoryID { get; set; } // Primary Key

        [Required(ErrorMessage = "Category Name is required")]
        [Display(Name = "Category Name")]
        public string CategoryName { get; set; }

        // Navigation Properties
        public List<Property> Properties { get; } = new List<Property>();
        // One-to-Many with Properties
    }
}



