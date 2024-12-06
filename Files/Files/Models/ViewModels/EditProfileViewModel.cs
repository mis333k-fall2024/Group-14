using System.ComponentModel.DataAnnotations;

public class EditProfileViewModel
{
    [Required(ErrorMessage = "Address is required.")]
    [StringLength(255)]
    public string Address { get; set; }

    [Required(ErrorMessage = "Phone number is required.")]
    [Phone(ErrorMessage = "Invalid phone number.")]
    [Display(Name = "Phone Number")]
    public string PhoneNumber { get; set; }

    [Required(ErrorMessage = "Date of Birth is required.")]
    [Display(Name = "Date of Birth")]
    [DataType(DataType.Date)]
    public DateTime DOB { get; set; }
}
