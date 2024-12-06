using System;
using System.ComponentModel.DataAnnotations;

namespace Files.Models
{
    public class ReservationViewModel
    {
        [Required]
        [Display(Name = "Customer ID")]
        public string CustomerId { get; set; }

        [Required]
        [Display(Name = "Property ID")]
        public int PropertyId { get; set; }

        [Required]
        [Display(Name = "Check In")]
        public DateTime CheckIn { get; set; }

        [Required]
        [Display(Name = "Check Out")]
        public DateTime CheckOut { get; set; }

        [Required]
        [Display(Name = "Number of Guests")]
        public int NumOfGuests { get; set; }

        [Required]
        [Display(Name = "Discount Rate (%)")]
        public decimal DiscountRate { get; set; }
    }
}
