using System;
using System.ComponentModel.DataAnnotations;

namespace Files.Models
{
    public class ModifyProfile
    {
        [Required(ErrorMessage = "First name is required.")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        [Phone]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Address is required.")]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Date of Birth is required.")]
        [Display(Name = "Date of Birth")]
        public DateTime DOB { get; set; }

        // For password change
        [DataType(DataType.Password)]
        [Display(Name = "Current Password")]
        public string OldPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "New Password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm New Password")]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmNewPassword { get; set; }

        // Read-only Email
        [Required(ErrorMessage = "Email address is required.")]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        // Custom validation to check if the user is 18 or older (can be moved to server-side validation if needed)
        public bool IsAdult()
        {
            return (DateTime.Now - DOB).TotalDays / 365 >= 18;
        }
    }
}


