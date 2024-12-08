using System;
using System.ComponentModel.DataAnnotations;

namespace Files
{
    public class ModifyProfileViewModel
    {
        [Required]
        public string UserId { get; set; }

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
        [AgeValidation(ErrorMessage = "You must be at least 18 years old.")]
        public DateTime DOB { get; set; }
    }

    // Custom validation to ensure the user is at least 18 years old
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
