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
                Properties = db.Properties.FirstOrDefault(u => "${u.Street}, ${u.City}, ${u.State} ${u.ZIP}" == "588 Alan Rest, Port Stephanieville, MS 63590"),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "father.Ingram@aool.com"),
                DisputeStatus = StatusDispute.NoDispute,
                HostComments = "",
                Rating = 4,
                TextReview = " ",
            });

            AllReviews.Add(new Review
            {
                Properties = db.Properties.FirstOrDefault(u => "${u.Street}, ${u.City}, ${u.State} ${u.ZIP}" == "1168 Gary Fords Apt. 308, Port Trevor, RI 96954"),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "orielly@foxnets.com"),
                DisputeStatus = StatusDispute.NoDispute,
                HostComments = "",
                Rating = 3,
                TextReview = "It was meh, ya know? It was really close to the coast, but the beaches were kinda trashed. The apartment was nice, but there wasn't an elevator.",
            });

            AllReviews.Add(new Review
            {
                Properties = db.Properties.FirstOrDefault(u => "${u.Street}, ${u.City}, ${u.State} ${u.ZIP}" == "03541 Ryan Islands Apt. 562, East Michaelfort, HI 90576"),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "father.Ingram@aool.com"),
                DisputeStatus = StatusDispute.Disputed, // Output enum
                HostComments = "The customer did not provide a valid reason for this rating.",
                Rating = 4,
                TextReview = "",
            });

            AllReviews.Add(new Review
            {
                Properties = db.Properties.FirstOrDefault(u => "${u.Street}, ${u.City}, ${u.State} ${u.ZIP}" == "588 Alan Rest, Port Stephanieville, MS 63590"),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "tuck33@puppy.com"),
                DisputeStatus = StatusDispute.NoDispute,
                HostComments = "",
                Rating = 2,
                TextReview = " ",
            });

            AllReviews.Add(new Review
            {
                Properties = db.Properties.FirstOrDefault(u => "${u.Street}, ${u.City}, ${u.State} ${u.ZIP}" == "94102 Sims Port Suite 187, Florestown, NE 80082"),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "father.Ingram@aool.com"),
                DisputeStatus = StatusDispute.NoDispute,
                HostComments = "",
                Rating = 3,
                TextReview = "Nebraska was... interesting",
            });

            AllReviews.Add(new Review
            {
                Properties = db.Properties.FirstOrDefault(u => "${u.Street}, ${u.City}, ${u.State} ${u.ZIP}" == "94102 Sims Port Suite 187, Florestown, NE 80082"),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "tfreeley@puppy.com"),
                DisputeStatus = StatusDispute.Disputed, // Output enum
                HostComments = "It is not my fault there was corn. It was not my corn!",
                Rating = 1,
                TextReview = "There was corn EVERYWHERE! I looked left and BAM, CORN. Looked right, BAM, CORN",
            });

            AllReviews.Add(new Review
            {
                Properties = db.Properties.FirstOrDefault(u => "${u.Street}, ${u.City}, ${u.State} ${u.ZIP}" == "94102 Sims Port Suite 187, Florestown, NE 80082"),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "ra@aoo.com"),
                DisputeStatus = StatusDispute.ValidDispute, // Output enum
                HostComments = "BevoBnB is the best",
                Rating = 1,
                TextReview = "Worst. Stay. Ever. Never using BevoBnB again",
            });

            AllReviews.Add(new Review
            {
                Properties = db.Properties.FirstOrDefault(u => "${u.Street}, ${u.City}, ${u.State} ${u.ZIP}" == "693 Michael Estate, Lake Michael, NM 03009"),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "orielly@foxnets.com"),
                DisputeStatus = StatusDispute.NoDispute,
                HostComments = "",
                Rating = 5,
                TextReview = " ",
            });

            AllReviews.Add(new Review
            {
                Properties = db.Properties.FirstOrDefault(u => "${u.Street}, ${u.City}, ${u.State} ${u.ZIP}" == "457 Vargas Island Suite 853, Lake Patrickstad, WY 67652"),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "orielly@foxnets.com"),
                DisputeStatus = StatusDispute.NoDispute,
                HostComments = "",
                Rating = 2,
                TextReview = " ",
            });

            AllReviews.Add(new Review
            {
                Properties = db.Properties.FirstOrDefault(u => "${u.Street}, ${u.City}, ${u.State} ${u.ZIP}" == "693 Michael Estate, Lake Michael, NM 03009"),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "tfreeley@puppy.com"),
                DisputeStatus = StatusDispute.InvalidDispute, // Output enum
                HostComments = "The website was coded by students so the owner should not be penalized!",
                Rating = 1,
                TextReview = "It was SO hard to book this place. Who coded this site anyway? ;)",
            });

            AllReviews.Add(new Review
            {
                Properties = db.Properties.FirstOrDefault(u => "${u.Street}, ${u.City}, ${u.State} ${u.ZIP}" == "71664 Kim Throughway, Chelsealand, AK 65056"),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "tuck33@puppy.com"),
                DisputeStatus = StatusDispute.NoDispute,
                HostComments = "",
                Rating = 4,
                TextReview = " ",
            });

            AllReviews.Add(new Review
            {
                Properties = db.Properties.FirstOrDefault(u => "${u.Street}, ${u.City}, ${u.State} ${u.ZIP}" == "693 Michael Estate, Lake Michael, NM 03009"),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "ra@aoo.com"),
                DisputeStatus = StatusDispute.NoDispute,
                HostComments = "",
                Rating = 5,
                TextReview = "This place rocked!",
            });

            AllReviews.Add(new Review
            {
                Properties = db.Properties.FirstOrDefault(u => "${u.Street}, ${u.City}, ${u.State} ${u.ZIP}" == "693 Michael Estate, Lake Michael, NM 03009"),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "fd@puppy.com"),
                DisputeStatus = StatusDispute.ValidDispute, // Output enum
                HostComments = "I do not understand this.",
                Rating = 4,
                TextReview = " ",
            });

            AllReviews.Add(new Review
            {
                Properties = db.Properties.FirstOrDefault(u => "${u.Street}, ${u.City}, ${u.State} ${u.ZIP}" == "457 Vargas Island Suite 853, Lake Patrickstad, WY 67652"),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "lamemartin.Martin@aool.com"),
                DisputeStatus = StatusDispute.NoDispute,
                HostComments = "",
                Rating = 4,
                TextReview = " ",
            });

            AllReviews.Add(new Review
            {
                Properties = db.Properties.FirstOrDefault(u => "${u.Street}, ${u.City}, ${u.State} ${u.ZIP}" == "94102 Sims Port Suite 187, Florestown, NE 80082"),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "fd@puppy.com"),
                DisputeStatus = StatusDispute.NoDispute,
                HostComments = "",
                Rating = 1,
                TextReview = "There were 1...5...22 roaches? I lost count.",
            });

            AllReviews.Add(new Review
            {
                Properties = db.Properties.FirstOrDefault(u => "${u.Street}, ${u.City}, ${u.State} ${u.ZIP}" == "1168 Gary Fords Apt. 308, Port Trevor, RI 96954"),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "sheff44@puppy.com"),
                DisputeStatus = StatusDispute.NoDispute,
                HostComments = "",
                Rating = 1,
                TextReview = " ",
            });

            AllReviews.Add(new Review
            {
                Properties = db.Properties.FirstOrDefault(u => "${u.Street}, ${u.City}, ${u.State} ${u.ZIP}" == "1220 Heidi Rue Apt. 998, West Haleyburgh, CO 05222"),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "fd@puppy.com"),
                DisputeStatus = StatusDispute.NoDispute,
                HostComments = "",
                Rating = 4,
                TextReview = "I LOVED the place! Had a nice view of the mountains",
            });

            AllReviews.Add(new Review
            {
                Properties = db.Properties.FirstOrDefault(u => "${u.Street}, ${u.City}, ${u.State} ${u.ZIP}" == "1220 Heidi Rue Apt. 998, West Haleyburgh, CO 05222"),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "tuck33@puppy.com"),
                DisputeStatus = StatusDispute.NoDispute,
                HostComments = "",
                Rating = 5,
                TextReview = " ",
            });

            AllReviews.Add(new Review
            {
                Properties = db.Properties.FirstOrDefault(u => "${u.Street}, ${u.City}, ${u.State} ${u.ZIP}" == "588 Alan Rest, Port Stephanieville, MS 63590"),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "orielly@foxnets.com"),
                DisputeStatus = StatusDispute.NoDispute,
                HostComments = "",
                Rating = 5,
                TextReview = "My stay was amazing! Saved my marriage",
            });

            AllReviews.Add(new Review
            {
                Properties = db.Properties.FirstOrDefault(u => "${u.Street}, ${u.City}, ${u.State} ${u.ZIP}" == "457 Vargas Island Suite 853, Lake Patrickstad, WY 67652"),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "sheff44@puppy.com"),
                DisputeStatus = StatusDispute.InvalidDispute, // Output enum
                HostComments = "Why??",
                Rating = 2,
                TextReview = " ",
            });

            AllReviews.Add(new Review
            {
                Properties = db.Properties.FirstOrDefault(u => "${u.Street}, ${u.City}, ${u.State} ${u.ZIP}" == "03541 Ryan Islands Apt. 562, East Michaelfort, HI 90576"),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "orielly@foxnets.com"),
                DisputeStatus = StatusDispute.NoDispute,
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
                // Loop through each review
                foreach (Review seedReview in AllReviews)
                {
                    // Update debugging variables to track progress
                    intReviewID = seedReview.ReviewID;
                    strReviewCustomer = seedReview.AppUsers.FirstName + " " + seedReview.AppUsers.LastName;
                    strReviewProperty = seedReview.Properties.Street + ", " + seedReview.Properties.City + ", " +
                                        seedReview.Properties.State + " " + seedReview.Properties.Zip;

                    // Check if the review already exists in the database
                    Review dbReview = db.Reviews.FirstOrDefault(c =>
                        (c.Properties.Street == seedReview.Properties.Street &&
                         c.Properties.City == seedReview.Properties.City &&
                         c.Properties.State == seedReview.Properties.State &&
                         c.Properties.Zip == seedReview.Properties.Zip) &&
                        (c.AppUsers.Email == seedReview.AppUsers.Email));

                    // If the review doesn't exist, add it to the database
                    if (dbReview == null)
                    {
                        db.Reviews.Add(seedReview);
                        db.SaveChanges();
                    }
                    else // If the review exists, update the fields
                    {
                        dbReview.DisputeStatus = seedReview.DisputeStatus;
                        dbReview.HostComments = seedReview.HostComments;
                        dbReview.Rating = seedReview.Rating;
                        dbReview.TextReview = seedReview.TextReview;

                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex) // Handle errors during the database operation
            {
                // Build a custom error message for debugging
                StringBuilder msg = new StringBuilder();

                msg.Append("There was an error adding the review for customer ");
                msg.Append(strReviewCustomer);
                msg.Append(" and property ");
                msg.Append(strReviewProperty);
                msg.Append(" (ReviewID = ");
                msg.Append(intReviewID);
                msg.Append(")");

                // Throw a new exception with the custom error message
                throw new Exception(msg.ToString(), ex);
            }
        }
    }
}