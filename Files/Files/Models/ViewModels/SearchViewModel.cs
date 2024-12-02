using System;
using System.ComponentModel.DataAnnotations;

namespace Files.Models
{
    public enum SelectedVote
    {
        [Display(Name = "Greater Than")] GreaterThan,
        [Display(Name = "Less Than")] LessThan,
    }

    public class SearchViewModel
    {
        // City search
        [Display(Name = "City")]
        public string? City { get; set; }

        // State search
        [Display(Name = "State")]
        public string? State { get; set; }

        // Number of Guests
        [Display(Name = "Minimum Guests")]
        [Range(0, Int32.MaxValue, ErrorMessage = "Minimum Guests must be a positive number.")]
        public int? MinGuests { get; set; }

        [Display(Name = "Maximum Guests")]
        [Range(0, Int32.MaxValue, ErrorMessage = "Maximum Guests must be a positive number.")]
        public int? MaxGuests { get; set; } = 15;

        // Price Range
        [Display(Name = "Minimum Price (Weekday)")]
        [Range(0.0, double.MaxValue, ErrorMessage = "Price must be a positive number.")]
        public decimal? MinPrice { get; set; }

        [Display(Name = "Maximum Price (Weekday)")]
        [Range(0.0, double.MaxValue, ErrorMessage = "Price must be a positive number.")]
        public decimal? MaxPrice { get; set; } = 300;

        // Category dropdown
        [Display(Name = "Category")]
        public int SelectedCategoryID { get; set; }

        // Number of Bedrooms
        [Display(Name = "Minimum Bedrooms")]
        [Range(0, Int32.MaxValue, ErrorMessage = "Minimum Bedrooms must be a positive number.")]
        public int? MinBedrooms { get; set; }

        [Display(Name = "Maximum Bedrooms")]
        [Range(0, Int32.MaxValue, ErrorMessage = "Maximum Bedrooms must be a positive number.")]
        public int? MaxBedrooms { get; set; }

        // Number of Bathrooms
        [Display(Name = "Minimum Bathrooms")]
        [Range(0, Int32.MaxValue, ErrorMessage = "Minimum Bathrooms must be a positive number.")]
        public int? MinBathrooms { get; set; }

        [Display(Name = "Maximum Bathrooms")]
        [Range(0, Int32.MaxValue, ErrorMessage = "Maximum Bathrooms must be a positive number.")]
        public int? MaxBathrooms { get; set; }

        // Guest Ratings
        [Display(Name = "Minimum Rating")]
        [Range(1.0, 5.0, ErrorMessage = "Rating must be between 1.0 and 5.0.")]
        public decimal? MinRating { get; set; }

        [Display(Name = "Maximum Rating")]
        [Range(1.0, 5.0, ErrorMessage = "Rating must be between 1.0 and 5.0.")]
        public decimal? MaxRating { get; set; }

        [Display(Name = "Rating Comparison")]
        public SelectedVote? RatingComparison { get; set; }

        // Pets Allowed
        [Display(Name = "Pets Allowed")]
        public bool? PetsAllowed { get; set; }

        // Free Parking
        [Display(Name = "Free Parking")]
        public bool? FreeParking { get; set; }

        // Check-In and Check-Out Dates
        [DataType(DataType.Date)]
        [Display(Name = "Check-In Date")]
        public DateTime? CheckInDate { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Check-Out Date")]
        public DateTime? CheckOutDate { get; set; }
    }
}


