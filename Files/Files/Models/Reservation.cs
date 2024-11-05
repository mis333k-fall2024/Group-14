
using System;
using System.ComponentModel.DataAnnotations;

namespace FA24_Group14.Models
{
    public class Reservation
    {
        public const Decimal Tax = .07m;

        private const int START_CONFIRMATION_NUMBER = 21901;

        private static int _nextConfirmationNumber = START_CONFIRMATION_NUMBER;

        [Key]
        [Display(Name = "Reservation ID")]
        public Int32 ReservationID { get; set; }

        [Display(Name = "Check In")]
        public DateTime CheckIn { get; set; }

        [Display(Name = "Check Out")]
        public DateTime CheckOut { get; set; }

        [Display(Name = "Number of Guests")]
        public Int32 NumOfGuests { get; set; }

        [Display(Name = "Weekday Price")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public Decimal WeekdayPrice { get; set; }

        [Display(Name = "Weekend Price")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public Decimal WeekendPrice { get; set; }

        [Display(Name = "Cleaning Fee")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public Decimal CleaningFee { get; set; }

        [Display(Name = "Discount Rate")]
        public Decimal DiscountRate { get; set; }

        [Display(Name = "Reservation Status")]
        public Boolean ReservationStatus { get; set; }

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
