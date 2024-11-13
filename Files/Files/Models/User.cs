using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class User
{
    [Key]
    public int UserId { get; set; } // Primary Key

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    public string Password { get; set; }

    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Navigation Properties
    public virtual ICollection<Reservation> Reservations { get; set; } // One-to-Many with Reservations
    public virtual ICollection<Property> Properties { get; set; } // One-to-Many with Properties (Host role)
    public virtual ICollection<Review> Reviews { get; set; } // One-to-Many with Reviews
}
