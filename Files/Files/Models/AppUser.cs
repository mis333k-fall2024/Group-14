using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

//TODO: Update this namespace to match your project's name
namespace Files.Models
{
    public enum HireStatus { Hired, Fired}
    public class AppUser : IdentityUser
    {
        //[Key] - identity also has this: reference HW 5
        //public int UserId { get; set; } // Primary Key

        //identity already has email, phone number, password, see: HW5 interview

        [Required(ErrorMessage = "First name is required.")]
        [MaxLength(50, ErrorMessage = "First name cannot exceed 50 characters.")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        [MaxLength(50, ErrorMessage = "Last name cannot exceed 50 characters.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Date of Birth is required.")]
        [Display(Name = "Date of Birth")]
        public DateTime DOB { get; set; }

        [Required(ErrorMessage = "Address is required.")]
        public DateTime Address { get; set; }

        [Required(ErrorMessage = "Hire Status is required.")]
        [Display(Name = "Hire Status")]
        public HireStatus Status { get; set; }

        // Navigation Properties
        public List<Reservation> Reservations { get; set; } // One-to-Many with Reservations
        public List<Property> Properties { get; set; } // One-to-Many with Properties (Host role)
        public List<Review> Reviews { get; set; } // One-to-Many with Reviews
    }
}
