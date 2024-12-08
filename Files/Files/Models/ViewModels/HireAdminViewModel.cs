using System;
using System.ComponentModel.DataAnnotations;

namespace Files
{
    public class HireAdminViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Last name cannot be longer than 50 characters.")]
        public string LastName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Address cannot be longer than 100 characters.")]
        public string Address { get; set; }

        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [AgeValidation(ErrorMessage = "Admin must be at least 18 years old.")]
        public DateTime DOB { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }

    // Custom validation attribute to check if the user is at least 18 years old
    public class AgeValidation : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var dob = (DateTime)value;
            var age = DateTime.Now.Year - dob.Year;

            if (DateTime.Now.DayOfYear < dob.DayOfYear)
                age--;

            return age >= 18;
        }
    }
}
