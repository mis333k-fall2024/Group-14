
using Files.DAL;
using Files.Models;
using Files.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Files.Seeding
{


    public static class SeedReviews
    {
        public static void SeedAllReviews(AppDbContext db)
        {
            List<Review> AllReviews = new List<Review>();


            AllReviews.Add(new Review
            {
                Properties = db.Properties.FirstOrDefault(u => u.PropertyNumber == 3127),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "father.Ingram@aool.com"),
                DisputeStatus = StatusDispute.NoDispute, // Output enum
                HostComments = "",
                Rating = 4,
                TextReview = " ",
            });

            AllReviews.Add(new Review
            {
                Properties = db.Properties.FirstOrDefault(u => u.PropertyNumber == 3085),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "orielly@foxnets.com"),
                DisputeStatus = StatusDispute.NoDispute, // Output enum
                HostComments = "",
                Rating = 3,
                TextReview = "It was meh, ya know? It was really close to the coast, but the beaches were kinda trashed. The apartment was nice, but there wasn't an elevator.",
            });

            AllReviews.Add(new Review
            {
                Properties = db.Properties.FirstOrDefault(u => u.PropertyNumber == 3161),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "father.Ingram@aool.com"),
                DisputeStatus = StatusDispute.Disputed, // Output enum
                HostComments = "The customer did not provide a valid reason for this rating.",
                Rating = 4,
                TextReview = "",
            });

            AllReviews.Add(new Review
            {
                Properties = db.Properties.FirstOrDefault(u => u.PropertyNumber == 3127),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "tuck33@puppy.com"),
                DisputeStatus = StatusDispute.NoDispute, // Output enum
                HostComments = "",
                Rating = 2,
                TextReview = " ",
            });

            AllReviews.Add(new Review
            {
                Properties = db.Properties.FirstOrDefault(u => u.PropertyNumber == 3107),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "father.Ingram@aool.com"),
                DisputeStatus = StatusDispute.NoDispute, // Output enum
                HostComments = "",
                Rating = 3,
                TextReview = "Nebraska was... interesting",
            });

            AllReviews.Add(new Review
            {
                Properties = db.Properties.FirstOrDefault(u => u.PropertyNumber == 3107),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "tfreeley@puppy.com"),
                DisputeStatus = StatusDispute.Disputed, // Output enum
                HostComments = "It is not my fault there was corn. It was not my corn!",
                Rating = 1,
                TextReview = "There was corn EVERYWHERE! I looked left and BAM, CORN. Looked right, BAM, CORN",
            });

            AllReviews.Add(new Review
            {
                Properties = db.Properties.FirstOrDefault(u => u.PropertyNumber == 3107),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "ra@aoo.com"),
                DisputeStatus = StatusDispute.ValidDispute, // Output enum
                HostComments = "BevoBnB is the best",
                Rating = 1,
                TextReview = "Worst. Stay. Ever. Never using BevoBnB again",
            });

            AllReviews.Add(new Review
            {
                Properties = db.Properties.FirstOrDefault(u => u.PropertyNumber == 3065),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "orielly@foxnets.com"),
                DisputeStatus = StatusDispute.NoDispute, // Output enum
                HostComments = "",
                Rating = 5,
                TextReview = " ",
            });

            AllReviews.Add(new Review
            {
                Properties = db.Properties.FirstOrDefault(u => u.PropertyNumber == 3133),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "orielly@foxnets.com"),
                DisputeStatus = StatusDispute.NoDispute, // Output enum
                HostComments = "",
                Rating = 2,
                TextReview = " ",
            });

            AllReviews.Add(new Review
            {
                Properties = db.Properties.FirstOrDefault(u => u.PropertyNumber == 3065),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "tfreeley@puppy.com"),
                DisputeStatus = StatusDispute.InvalidDispute, // Output enum
                HostComments = "The website was coded by students so the owner should not be penalized!",
                Rating = 1,
                TextReview = "It was SO hard to book this place. Who coded this site anyway? ;)",
            });

            AllReviews.Add(new Review
            {
                Properties = db.Properties.FirstOrDefault(u => u.PropertyNumber == 3067),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "tuck33@puppy.com"),
                DisputeStatus = StatusDispute.NoDispute, // Output enum
                HostComments = "",
                Rating = 4,
                TextReview = " ",
            });

            AllReviews.Add(new Review
            {
                Properties = db.Properties.FirstOrDefault(u => u.PropertyNumber == 3065),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "ra@aoo.com"),
                DisputeStatus = StatusDispute.NoDispute, // Output enum
                HostComments = "",
                Rating = 5,
                TextReview = "This place rocked!",
            });

            AllReviews.Add(new Review
            {
                Properties = db.Properties.FirstOrDefault(u => u.PropertyNumber == 3065),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "fd@puppy.com"),
                DisputeStatus = StatusDispute.ValidDispute, // Output enum
                HostComments = "I do not understand this.",
                Rating = 4,
                TextReview = " ",
            });

            AllReviews.Add(new Review
            {
                Properties = db.Properties.FirstOrDefault(u => u.PropertyNumber == 3133),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "lamemartin.Martin@aool.com"),
                DisputeStatus = StatusDispute.NoDispute, // Output enum
                HostComments = "",
                Rating = 4,
                TextReview = " ",
            });

            AllReviews.Add(new Review
            {
                Properties = db.Properties.FirstOrDefault(u => u.PropertyNumber == 3107),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "fd@puppy.com"),
                DisputeStatus = StatusDispute.NoDispute, // Output enum
                HostComments = "",
                Rating = 1,
                TextReview = "There were 1...5...22 roaches? I lost count.",
            });

            AllReviews.Add(new Review
            {
                Properties = db.Properties.FirstOrDefault(u => u.PropertyNumber == 3085),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "sheff44@puppy.com"),
                DisputeStatus = StatusDispute.NoDispute, // Output enum
                HostComments = "",
                Rating = 1,
                TextReview = " ",
            });

            AllReviews.Add(new Review
            {
                Properties = db.Properties.FirstOrDefault(u => u.PropertyNumber == 3087),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "fd@puppy.com"),
                DisputeStatus = StatusDispute.NoDispute, // Output enum
                HostComments = "",
                Rating = 4,
                TextReview = "I LOVED the place! Had a nice view of the mountains",
            });

            AllReviews.Add(new Review
            {
                Properties = db.Properties.FirstOrDefault(u => u.PropertyNumber == 3087),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "tuck33@puppy.com"),
                DisputeStatus = StatusDispute.NoDispute, // Output enum
                HostComments = "",
                Rating = 5,
                TextReview = " ",
            });

            AllReviews.Add(new Review
            {
                Properties = db.Properties.FirstOrDefault(u => u.PropertyNumber == 3127),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "orielly@foxnets.com"),
                DisputeStatus = StatusDispute.NoDispute, // Output enum
                HostComments = "",
                Rating = 5,
                TextReview = "My stay was amazing! Saved my marriage",
            });

            AllReviews.Add(new Review
            {
                Properties = db.Properties.FirstOrDefault(u => u.PropertyNumber == 3133),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "sheff44@puppy.com"),
                DisputeStatus = StatusDispute.InvalidDispute, // Output enum
                HostComments = "Why??",
                Rating = 2,
                TextReview = " ",
            });

            AllReviews.Add(new Review
            {
                Properties = db.Properties.FirstOrDefault(u => u.PropertyNumber == 3161),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "orielly@foxnets.com"),
                DisputeStatus = StatusDispute.NoDispute, // Output enum
                HostComments = "",
                Rating = 2,
                TextReview = "My wife's attitude was the only thing rougher than the sand at the nearby beaches",
            });

            // Create a counter and flag to help with debugging
            int intReviewID = 0;
            string strReviewCustomer = "Start";
            string strReviewProperty = "Start";

            // Add the reviews to the database in a Try/Catch block to handle potential errors
            try
            {
                {
                    // Loop through each review
                    foreach (Review seedReview in AllReviews)
                    {
                        {
                            // Update debugging variables to track progress
                            intReviewID = seedReview.ReviewID;
                            strReviewCustomer = seedReview.AppUsers.FirstName + " " + seedReview.AppUsers.LastName;
                            strReviewProperty = seedReview.Properties.PropertyNumber.ToString(); // Updated to PropertyNumber

                            // Check if the review already exists in the database
                            Review dbReview = db.Reviews.FirstOrDefault(c =>
                                (c.Properties.PropertyNumber == seedReview.Properties.PropertyNumber) &&
                                (c.AppUsers.Email == seedReview.AppUsers.Email));

                            // If the review doesn't exist, add it to the database
                            if (dbReview == null)
                            {
                                {
                                    db.Reviews.Add(seedReview);
                                    db.SaveChanges();
                                }
                            }
                            else // If the review exists, update the fields
                            {
                                {
                                    dbReview.DisputeStatus = seedReview.DisputeStatus;
                                    dbReview.HostComments = seedReview.HostComments;
                                    dbReview.Rating = seedReview.Rating;
                                    dbReview.TextReview = seedReview.TextReview;

                                    db.SaveChanges();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex) // Handle errors during the database operation
            {
                {
                    // Build a custom error message for debugging
                    StringBuilder msg = new StringBuilder();

                    msg.Append("There was an error adding the review for customer ");
                    msg.Append(strReviewCustomer); // Customer name
                    msg.Append(" and property number ");
                    msg.Append(strReviewProperty); // Updated to show PropertyNumber
                    msg.Append(" (ReviewID = ");
                    msg.Append(intReviewID);
                    msg.Append(")");

                    // Throw a new exception with the custom error message
                    throw new Exception(msg.ToString(), ex);
                }
            }
        }
    }
}