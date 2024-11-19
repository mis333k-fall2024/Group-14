using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Xml.Linq;
using Files;
using Files.Models;

namespace Files.Models
{
    public enum PetsAllowed { yes, no }

    public enum FreeParking { yes, no }

    public class Property
    {

        private const int START_PROPID_NUMBER = 3001;

        private static int _nextPropIDNumber = START_PROPID_NUMBER;

        [Key]
        public Int32 PropertyID { get; set; } //pk + int?, req?, no display

        // HostID fk + int?, non-req?

        //CategoryID fk + int?, non-req?

        //[Required(ErrorMessage = "Property Number is required")]
        //[Display(Name = "Property Number")]
        public int PropertyNumber { get; set; } //req

        [Required(ErrorMessage = "Street Address is required")]
        [Display(Name = "Street Address")]
        public string Street { get; set; } //string, req?

        [Required(ErrorMessage = "City is required")]
        [Display(Name = "City")]
        public string City { get; set; } //string

        [Required(ErrorMessage = "State is required")]
        [Display(Name = "State")]
        public string State { get; set; } //string

        [Required(ErrorMessage = "Zip Code is required")]
        [Display(Name = "Zip Code")]
        public Int32 Zip { get; set; } //int 5 #s

        [Required(ErrorMessage = "Number of Bedrooms is required")]
        [Display(Name = "Number of Bedrooms")]
        public Int32 Bedrooms { get; set; } //int32

        [Required(ErrorMessage = "Number of Bathrooms is required")]
        [Display(Name = "Number of Bathrooms")]
        public Int32 Bathrooms { get; set; } //int

        [Required(ErrorMessage = "Max Guest Number is required")]
        [Display(Name = "Max Guest Number")]
        public Int32 GuestsAllowed { get; set; } //int

        [Required(ErrorMessage = "Property Number is required")]
        [Display(Name = "Property Number")]
        public PetsAllowed PetsAllowed { get; set; } //enum (yes or no)

        [Required(ErrorMessage = "Parking option is required")]
        [Display(Name = "Free Parking")]
        public FreeParking FreeParking { get; set; } //enum (yes or no)

        [Required(ErrorMessage = "Weekday Price is required")]
        [Display(Name = "Weekday Price")]
        public Type WeekdayPrice { get; set; } //int/dec in 2 dec place

        [Required(ErrorMessage = "Weekend Price is required")]
        [Display(Name = "Weekend Price")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal WeekendPrice { get; set; } //int/dec in 2 dec place

        [Required(ErrorMessage = "Cleaning Fee is required")]
        [Display(Name = "Cleaning Fee")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal CleaningFee { get; set; } //int/dec in 2 dec place

        [Required(ErrorMessage = "Minimum Stay for Discount is required")]
        [Display(Name = "Minimum Days for Discount")]
        public Int32 DiscountMinStay { get; set; } //int not dec

        //[DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? DiscountRate { get; set; } //int/dec in 2 dec place,not req
        //still have display when said should just be in dollars (aka result of drate*amt)

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MMMM d, yyyy}")]
        public DateTime UnavailableDates { get; set; } //multiple dates tho??

        // Setting the PropIDNumber
        public Property()
        {
            PropertyID = GeneratePropIDNumber();
        }

        // Method to generate a confirmation number
        private static int GeneratePropIDNumber()
        {
            return _nextPropIDNumber++;
        }

        // Navigation property to the (it can have many Reservations)
        public List<Reservation> Reservations { get; set; }
        //many reviews to one prop
        public List<Review> Reviews { get; set; }
        //one category
        public Category Categories { get; set; }
        //users
        public User Users { get; set; }
    }

}

