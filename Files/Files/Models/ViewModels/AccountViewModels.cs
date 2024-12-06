using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Files.Models
{
    // This is the view model used to allow the user to login
    // The user only needs the email and password to login
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    // This is the view model used to register a user
    // When the user registers, they only need to specify the properties listed in this model
    public class RegisterViewModel
    {
        // Here is the property for email
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        // Here is the property for phone number
        [Required(ErrorMessage = "Phone number is required")]
        [Phone]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        // Add any fields that you need for creating a new user
        [Required(ErrorMessage = "First name is required.")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Address is required.")]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Date of birth is required.")]
        [Display(Name = "Date of Birth")]
        public DateTime DOB { get; set; }

        [Display(Name = "Status")]
        public HireStatus? Status { get; set; }

        // Logic for putting in a password
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    // This is the view model used to allow the user to change their password
    public class ChangePasswordViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Current password")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    // This is the view model used to display basic user information on the index page
    public class IndexViewModel
    {
        public bool HasPassword { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string UserID { get; set; }
    }

    
}

