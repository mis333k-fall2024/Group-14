using System;
using System.ComponentModel.DataAnnotations;

namespace Files.Models
{
    public class Reservation
    {
        public const Decimal TaxRate = 0.07m;

        [Key]
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

        [Display(Name = "Discount Amount")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public Decimal DiscountAmount { get; set; } // Automatically calculated based on DiscountRate and length of stay

        [Required(ErrorMessage = "Discount Rate is required")]
        [Display(Name = "Discount Rate")]
        public Decimal DiscountRate { get; set; }

        [Required(ErrorMessage = "Reservation Status is required")]
        [Display(Name = "Active Reservation")]
        public Boolean ReservationStatus { get; set; }

        [Required(ErrorMessage = "Confirmation Number is required")]
        [Display(Name = "Confirmation Number")]
        public Int32 ConfirmationNumber { get; set; }

        [Display(Name = "Property Name")]
        public Property Properties { get; set; }

        [Display(Name = "User")]
        public AppUser AppUsers { get; set; }

        [Display(Name = "City")]
        public string? City { get; set; }

        [Display(Name = "State")]
        public string? State { get; set; }


        public decimal CalculatePreDiscountPrice()
        {
            int totalDays = (CheckOut - CheckIn).Days;
            int weekendDays = CalculateWeekendDays(CheckIn, CheckOut);
            int weekdayDays = totalDays - weekendDays;

            // Calculate the total stay price before applying any discounts
            return (weekdayDays * WeekdayPrice) + (weekendDays * WeekendPrice);
        }

        public decimal CalculateStayPrice()
        {
            decimal preDiscountPrice = CalculatePreDiscountPrice();

            // Apply discount if applicable
            int totalDays = (CheckOut - CheckIn).Days;
            if (totalDays >= Properties.DiscountMinStay)
            {
                decimal discountRate = Properties.DiscountRate ?? 0m; // Use 0m if DiscountRate is null
                decimal discount = preDiscountPrice * discountRate;
                preDiscountPrice -= discount; // Apply the discount
            }

            return preDiscountPrice;
        }

        // Method to calculate total amount (including cleaning fee and discounts)
        public decimal CalculateTotalAmount()
        {
            decimal stayPrice = CalculateStayPrice();
            DiscountAmount = stayPrice * DiscountRate;
            decimal subtotal = stayPrice + CleaningFee - DiscountAmount;
            return subtotal + (subtotal * TaxRate); // Include tax
        }

        // Helper method to calculate the number of weekend days in a date range
        private int CalculateWeekendDays(DateTime checkIn, DateTime checkOut)
        {
            int weekendDays = 0;
            for (var date = checkIn; date < checkOut; date = date.AddDays(1))
            {
                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                {
                    weekendDays++;
                }
            }
            return weekendDays;
        }
    }
}
