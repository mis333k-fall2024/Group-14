using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

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
        public string Address { get; set; }

        [Display(Name = "Hire Status")]
        public HireStatus? Status { get; set; }

        [NotMapped]
        public bool IsOver18
        {
            get
            {
                var today = DateTime.Today;
                var age = today.Year - DOB.Year;
                if (DOB.Date > today.AddYears(-age)) age--;
                return age >= 18;
            }
        }

        // Navigation Properties
        public List<Reservation> Reservations { get; } = new List<Reservation>();// One-to-Many with Reservations
        public List<Property> Properties { get; } = new List<Property>(); // One-to-Many with Properties (Host role)
        public List<Review> Reviews { get; } = new List<Review>(); // One-to-Many with Reviews
    }
}
