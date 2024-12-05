using System;
using System.ComponentModel.DataAnnotations;

namespace Files.Models
{
    public enum ComparisonType
    {
        [Display(Name = "Greater Than")] GreaterThan,
        [Display(Name = "Less Than")] LessThan,
    }

    public class SearchViewModel : IValidatableObject
    {
        // City search
        [Display(Name = "City")]
        [RegularExpression("^[a-zA-Z\\s]+$", ErrorMessage = "City must only contain letters.")]
        public string? City { get; set; }

        // State search
        [Display(Name = "State")]
        [RegularExpression("^[a-zA-Z\\s]+$", ErrorMessage = "State must only contain letters.")]
        public string? State { get; set; }

        // Guests
        [Display(Name = "Guest Comparison")]
        public ComparisonType? GuestComparison { get; set; }

        [Display(Name = "Guests")]
        [Range(0, Int32.MaxValue, ErrorMessage = "Guests must be a positive number.")]
        public int? GuestValue { get; set; }

        // Price
        [Display(Name = "Price Comparison")]
        public ComparisonType? PriceComparison { get; set; }

        [Display(Name = "Price")]
        [Range(0.0, double.MaxValue, ErrorMessage = "Price must be a positive number.")]
        public decimal? PriceValue { get; set; }

        // Category dropdown
        [Display(Name = "Category")]
        public int SelectedCategoryID { get; set; }

        // Bedrooms
        [Display(Name = "Bedroom Comparison")]
        public ComparisonType? BedroomComparison { get; set; }

        [Display(Name = "Bedrooms")]
        [Range(0, Int32.MaxValue, ErrorMessage = "Bedrooms must be a positive number.")]
        public int? BedroomValue { get; set; }

        // Bathrooms
        [Display(Name = "Bathroom Comparison")]
        public ComparisonType? BathroomComparison { get; set; }

        [Display(Name = "Bathrooms")]
        [Range(0, Int32.MaxValue, ErrorMessage = "Bathrooms must be a positive number.")]
        public int? BathroomValue { get; set; }

        // Guest Ratings
        [Display(Name = "Rating")]
        [Range(1.0, 5.0, ErrorMessage = "Rating must be between 1.0 and 5.0.")]
        public decimal? RatingValue { get; set; }

        [Display(Name = "Rating Comparison")]
        public ComparisonType? RatingComparison { get; set; }

        // Pets Allowed
        [Display(Name = "Pets Allowed")]
        public bool? PetsAllowed { get; set; }

        // Free Parking
        [Display(Name = "Free Parking")]
        public bool? FreeParking { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Check-In Date")]
        public DateTime? CheckInDate { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Check-Out Date")]
        public DateTime? CheckOutDate { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (CheckInDate.HasValue && !CheckOutDate.HasValue)
            {
                yield return new ValidationResult("If Check-In Date is provided, Check-Out Date must also be provided.", new[] { nameof(CheckOutDate) });
            }

            if (!CheckInDate.HasValue && CheckOutDate.HasValue)
            {
                yield return new ValidationResult("If Check-Out Date is provided, Check-In Date must also be provided.", new[] { nameof(CheckInDate) });
            }
        }
    }

}


