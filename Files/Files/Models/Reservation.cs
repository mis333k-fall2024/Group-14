
using System;
using System.ComponentModel.DataAnnotations;

namespace Files.Models
{
    public class Reservation
    {
        public const Decimal Tax = .07m;

        private const int START_CONFIRMATION_NUMBER = 21901;

        private static int _nextConfirmationNumber = START_CONFIRMATION_NUMBER;

        [Key]
        [Required(ErrorMessage = "Reservation ID is required")]
        [Display(Name = "Reservation ID")]
        public Int32 ReservationID { get; set; }

        [Required(ErrorMessage = "Check In is required")]
        [Display(Name = "Check In")]
        public DateTime CheckIn { get; set; }

        [Required(ErrorMessage = "Check Out is required")]
        [Display(Name = "Check Out")]
        public DateTime CheckOut { get; set; }

        [Required(ErrorMessage = "Number of Guests is required")]
        [Display(Name = "Number of Guests")]
        public Int32 NumOfGuests { get; set; }

        [Required(ErrorMessage = "Weekday Price is required")]
        [Display(Name = "Weekday Price")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public Decimal WeekdayPrice { get; set; }

        [Required(ErrorMessage = "Weekend Price is required")]
        [Display(Name = "Weekend Price")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public Decimal WeekendPrice { get; set; }

        [Required(ErrorMessage = "Cleaning Fee is required")]
        [Display(Name = "Cleaning Fee")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public Decimal CleaningFee { get; set; }

        [Required(ErrorMessage = "Discount Rate is required")]
        [Display(Name = "Discount Rate")]
        public Decimal DiscountRate { get; set; }

        [Required(ErrorMessage = "Reservation Status is required")]
        [Display(Name = "Reservation Status")]
        public Boolean ReservationStatus { get; set; }

        [Required(ErrorMessage = "Confirmation Number is required")]
        [Display(Name = "Confirmation Number")]
        public Int32 ConfirmationNumber { get; private set; }

        // Constructor to set the ConfirmationNumber
        public Reservation()
        {
            ConfirmationNumber = GenerateConfirmationNumber();
        }

        // Method to generate a confirmation number
        private static int GenerateConfirmationNumber()
        {
            return _nextConfirmationNumber++;
        }
    }
}
