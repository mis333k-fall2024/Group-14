using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Files.Models
{
    public class MakeReservationViewModel
    {
        [Required]
        [Display(Name = "Customer")]
        public string CustomerId { get; set; }

        [Required]
        [Display(Name = "Property")]
        public int PropertyId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Check-In Date")]
        public DateTime CheckIn { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Check-Out Date")]
        public DateTime CheckOut { get; set; }

        [Required]
        [Display(Name = "Number of Guests")]
        [Range(1, 100, ErrorMessage = "Number of guests must be between 1 and 100.")]
        public int NumOfGuests { get; set; }

        public List<AppUser> Customers { get; set; }
        public List<Property> Properties { get; set; }
    }
}
