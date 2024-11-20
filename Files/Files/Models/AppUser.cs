using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

//TODO: Update this namespace to match your project's name
namespace Files.Models
{
    public class AppUser : IdentityUser
    {
        [Key]
        public int UserId { get; set; } // Primary Key

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters long.")]
        [MaxLength(100, ErrorMessage = "Password cannot exceed 100 characters.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "First name is required.")]
        [MaxLength(50, ErrorMessage = "First name cannot exceed 50 characters.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        [MaxLength(50, ErrorMessage = "Last name cannot exceed 50 characters.")]
        public string LastName { get; set; }

        // Navigation Properties
        public List<Reservation> Reservations { get; set; } // One-to-Many with Reservations
        public List<Property> Properties { get; set; } // One-to-Many with Properties (Host role)
        public List<Review> Reviews { get; set; } // One-to-Many with Reviews
    }
}
