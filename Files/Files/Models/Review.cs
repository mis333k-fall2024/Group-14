using System;
using System.Collections.Generic;
using System.Linq;

namespace Files.Models
{
    public class Review
    {
        // Properties
        public int ReviewId { get; set; }                  
        public int PropertyId { get; set; }               
        public int CustomerId { get; set; }              
        private int _rating;                           
        public int Rating
        {
            get { return _rating; }
            set
            {
                if (value < 1 || value > 5)
                    throw new ArgumentOutOfRangeException("Rating must be between 1 and 5.");
                _rating = value;
                UpdateAverageRating();
            }
        }
        private string _comment;                           
        public string Comment
        {
            get { return _comment; }
            set
            {
                if (value != null && value.Length > 280)
                    throw new ArgumentOutOfRangeException("Comment must be 280 characters or less.");
                _comment = value;
            }
        }
        public DateTime DatePosted { get; private set; }   // Date  review was posted
        public bool IsEditable { get; set; }               // Indicates if  review can be edited
        private static List<int> AllRatings = new List<int>();  // Stores all ratings for average calculation
        public static double AverageRating { get; private set; } // Static property for average rating

       
        public Review(int reviewId, int propertyId, int customerId, int rating, string comment)
        {
            ReviewId = reviewId;
            PropertyId = propertyId;
            CustomerId = customerId;
            Rating = rating;
            Comment = comment;
            DatePosted = DateTime.Now;
            IsEditable = true;

            AllRatings.Add(rating);
            UpdateAverageRating();
        }

        // update average rating
        private static void UpdateAverageRating()
        {
            AverageRating = Math.Round(AllRatings.Average(), 1);
        }

        // edit the review
        public void EditReview(int newRating, string newComment)
        {
            if (!IsEditable)
                throw new InvalidOperationException("This review cannot be edited.");

            AllRatings.Remove(_rating);  // Remove old rating from calculation
            Rating = newRating;          // Set new rating
            Comment = newComment;        // Update comment if provided

            AllRatings.Add(newRating);   // Add new rating to calculation
            UpdateAverageRating();
        }

        // to dispute management
        public void ToggleEditable()
        {
            IsEditable = !IsEditable;
        }
    }
}


