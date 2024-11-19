using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Category
{
    [Key]
    public int CategoryId { get; set; } // Primary Key

    [Required]
    public string CategoryName { get; set; }

    public string Description { get; set; }

    // Navigation Properties
    public virtual ICollection<Property> Properties { get; set; } // One-to-Many with Properties
}
