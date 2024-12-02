﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Files.Models
{
    public class Reservation
    {
        public const decimal TaxRate = 0.07m;

        private const int START_CONFIRMATION_NUMBER = 21901;

        private static int _nextConfirmationNumber = START_CONFIRMATION_NUMBER;

        [Key]
        public int ReservationID { get; set; }

        [Required(ErrorMessage = "Check In is required")]
        [Display(Name = "Check In")]
        public DateTime CheckIn { get; set; }

        [Required(ErrorMessage = "Check Out is required")]
        [Display(Name = "Check Out")]
        public DateTime CheckOut { get; set; }

        [Required(ErrorMessage = "Number of Guests is required")]
        [Display(Name = "Number of Guests")]
        public int NumOfGuests { get; set; }

        [Required(ErrorMessage = "Weekday Price is required")]
        [Display(Name = "Weekday Price")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal WeekdayPrice { get; set; }

        [Required(ErrorMessage = "Weekend Price is required")]
        [Display(Name = "Weekend Price")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal WeekendPrice { get; set; }

        [Required(ErrorMessage = "Cleaning Fee is required")]
        [Display(Name = "Cleaning Fee")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal CleaningFee { get; set; }

        [Display(Name = "Discount Amount")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal DiscountAmount { get; set; } // Automatically calculated based on DiscountRate and length of stay

        [Required(ErrorMessage = "Discount Rate is required")]
        [Display(Name = "Discount Rate")]
        public decimal DiscountRate { get; set; }

        [Required(ErrorMessage = "Reservation Status is required")]
        [Display(Name = "Reservation Status")]
        public bool ReservationStatus { get; set; }

        [Required(ErrorMessage = "Confirmation Number is required")]
        [Display(Name = "Confirmation Number")]
        public int ConfirmationNumber { get; set; }

        [Required(ErrorMessage = "Property is required")]
        public int PropertyId { get; set; } // Foreign key for Property

        [Display(Name = "Property Name")]
        public Property Properties { get; set; }

        [Required(ErrorMessage = "User is required")]
        public string UserId { get; set; } // Foreign key for User

        [Display(Name = "User")]
        public AppUser AppUsers { get; set; }

        [Display(Name = "City")]
        public string City { get; set; }

        [Display(Name = "State")]
        public string State { get; set; }

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

        // Method to calculate total price for the stay
        public decimal CalculateStayPrice()
        {
            int totalDays = (CheckOut - CheckIn).Days;
            int weekendDays = CalculateWeekendDays(CheckIn, CheckOut);
            int weekdayDays = totalDays - weekendDays;

            return (weekdayDays * WeekdayPrice) + (weekendDays * WeekendPrice);
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
