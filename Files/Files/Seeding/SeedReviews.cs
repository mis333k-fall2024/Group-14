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
            List <Reviews> AllReviews = new List<Reviews>();


             AllReviews.Add(new Review()
            {
                PropertyAddress = "588 Alan Rest, Port Stephanieville, MS 63590",
                PropertyNumber = 3127,
                CustomerEmail = "father.Ingram@aool.com",
                DisputeStatus = "NoDispute",
                HostComments = " ",
                Rating = 4,
                ReviewText = " ",
            });
    
             AllReviews.Add(new Review()
            {
                PropertyAddress = "1168 Gary Fords Apt. 308, Port Trevor, RI 96954",
                PropertyNumber = 3085,
                CustomerEmail = "orielly@foxnets.com",
                DisputeStatus = "NoDispute",
                HostComments = " ",
                Rating = 3,
                ReviewText = "It was meh, ya know? It was really close to the coast, but the beaches were kinda trashed. The apartment was nice, but there wasn't an elevator.",
            });
    
             AllReviews.Add(new Review()
            {
                PropertyAddress = "03541 Ryan Islands Apt. 562, East Michaelfort, HI 90576",
                PropertyNumber = 3161,
                CustomerEmail = "father.Ingram@aool.com",
                DisputeStatus = "Disputed",
                HostComments = "The customer did not provide a valid reason for this rating.",
                Rating = 4,
                ReviewText = " ",
            });
    
             AllReviews.Add(new Review()
            {
                PropertyAddress = "588 Alan Rest, Port Stephanieville, MS 63590",
                PropertyNumber = 3127,
                CustomerEmail = "tuck33@puppy.com",
                DisputeStatus = "NoDispute",
                HostComments = " ",
                Rating = 2,
                ReviewText = " ",
            });
    
             AllReviews.Add(new Review()
            {
                PropertyAddress = "94102 Sims Port Suite 187, Florestown, NE 80082",
                PropertyNumber = 3107,
                CustomerEmail = "father.Ingram@aool.com",
                DisputeStatus = "NoDispute",
                HostComments = " ",
                Rating = 3,
                ReviewText = "Nebraska was... interesting",
            });
    
             AllReviews.Add(new Review()
            {
                PropertyAddress = "94102 Sims Port Suite 187, Florestown, NE 80082",
                PropertyNumber = 3107,
                CustomerEmail = "tfreeley@puppy.com",
                DisputeStatus = "Disputed",
                HostComments = "It is not my fault there was corn. It was not my corn!",
                Rating = 1,
                ReviewText = "There was corn EVERYWHERE! I looked left and BAM, CORN. Looked right, BAM, CORN",
            });
    
             AllReviews.Add(new Review()
            {
                PropertyAddress = "94102 Sims Port Suite 187, Florestown, NE 80082",
                PropertyNumber = 3107,
                CustomerEmail = "ra@aoo.com",
                DisputeStatus = "ValidDispute",
                HostComments = "BevoBnB is the best",
                Rating = 1,
                ReviewText = "Worst. Stay. Ever. Never using BevoBnB again",
            });
    
             AllReviews.Add(new Review()
            {
                PropertyAddress = "693 Michael Estate, Lake Michael, NM 03009",
                PropertyNumber = 3065,
                CustomerEmail = "orielly@foxnets.com",
                DisputeStatus = "NoDispute",
                HostComments = " ",
                Rating = 5,
                ReviewText = " ",
            });
    
             AllReviews.Add(new Review()
            {
                PropertyAddress = "457 Vargas Island Suite 853, Lake Patrickstad, WY 67652",
                PropertyNumber = 3133,
                CustomerEmail = "orielly@foxnets.com",
                DisputeStatus = "NoDispute",
                HostComments = " ",
                Rating = 2,
                ReviewText = " ",
            });
    
             AllReviews.Add(new Review()
            {
                PropertyAddress = "693 Michael Estate, Lake Michael, NM 03009",
                PropertyNumber = 3065,
                CustomerEmail = "tfreeley@puppy.com",
                DisputeStatus = "InvalidDispute",
                HostComments = "The website was coded by students so the owner should not be penalized!",
                Rating = 1,
                ReviewText = "It was SO hard to book this place. Who coded this site anyway? ;)",
            });
    
             AllReviews.Add(new Review()
            {
                PropertyAddress = "71664 Kim Throughway, Chelsealand, AK 65056",
                PropertyNumber = 3067,
                CustomerEmail = "tuck33@puppy.com",
                DisputeStatus = "NoDispute",
                HostComments = " ",
                Rating = 4,
                ReviewText = " ",
            });
    
             AllReviews.Add(new Review()
            {
                PropertyAddress = "693 Michael Estate, Lake Michael, NM 03009",
                PropertyNumber = 3065,
                CustomerEmail = "ra@aoo.com",
                DisputeStatus = "NoDispute",
                HostComments = " ",
                Rating = 5,
                ReviewText = "This place rocked!",
            });
    
             AllReviews.Add(new Review()
            {
                PropertyAddress = "693 Michael Estate, Lake Michael, NM 03009",
                PropertyNumber = 3065,
                CustomerEmail = "fd@puppy.com",
                DisputeStatus = "ValidDispute",
                HostComments = "I do not understand this.",
                Rating = 4,
                ReviewText = " ",
            });
    
             AllReviews.Add(new Review()
            {
                PropertyAddress = "457 Vargas Island Suite 853, Lake Patrickstad, WY 67652",
                PropertyNumber = 3133,
                CustomerEmail = "lamemartin.Martin@aool.com",
                DisputeStatus = "NoDispute",
                HostComments = " ",
                Rating = 4,
                ReviewText = " ",
            });
    
             AllReviews.Add(new Review()
            {
                PropertyAddress = "94102 Sims Port Suite 187, Florestown, NE 80082",
                PropertyNumber = 3107,
                CustomerEmail = "fd@puppy.com",
                DisputeStatus = "NoDispute",
                HostComments = " ",
                Rating = 1,
                ReviewText = "There were 1...5...22 roaches? I lost count.",
            });
    
             AllReviews.Add(new Review()
            {
                PropertyAddress = "1168 Gary Fords Apt. 308, Port Trevor, RI 96954",
                PropertyNumber = 3085,
                CustomerEmail = "sheff44@puppy.com",
                DisputeStatus = "NoDispute",
                HostComments = " ",
                Rating = 1,
                ReviewText = " ",
            });
    
             AllReviews.Add(new Review()
            {
                PropertyAddress = "1220 Heidi Rue Apt. 998, West Haleyburgh, CO 05222",
                PropertyNumber = 3087,
                CustomerEmail = "fd@puppy.com",
                DisputeStatus = "NoDispute",
                HostComments = " ",
                Rating = 4,
                ReviewText = "I LOVED the place! Had a nice view of the mountains",
            });
    
             AllReviews.Add(new Review()
            {
                PropertyAddress = "1220 Heidi Rue Apt. 998, West Haleyburgh, CO 05222",
                PropertyNumber = 3087,
                CustomerEmail = "tuck33@puppy.com",
                DisputeStatus = "NoDispute",
                HostComments = " ",
                Rating = 5,
                ReviewText = " ",
            });
    
             AllReviews.Add(new Review()
            {
                PropertyAddress = "588 Alan Rest, Port Stephanieville, MS 63590",
                PropertyNumber = 3127,
                CustomerEmail = "orielly@foxnets.com",
                DisputeStatus = "NoDispute",
                HostComments = " ",
                Rating = 5,
                ReviewText = "My stay was amazing! Saved my marriage",
            });
    
             AllReviews.Add(new Review()
            {
                PropertyAddress = "457 Vargas Island Suite 853, Lake Patrickstad, WY 67652",
                PropertyNumber = 3133,
                CustomerEmail = "sheff44@puppy.com",
                DisputeStatus = "InvalidDispute",
                HostComments = "Why??",
                Rating = 2,
                ReviewText = " ",
            });
    
             AllReviews.Add(new Review()
            {
                PropertyAddress = "03541 Ryan Islands Apt. 562, East Michaelfort, HI 90576",
                PropertyNumber = 3161,
                CustomerEmail = "orielly@foxnets.com",
                DisputeStatus = "NoDispute",
                HostComments = " ",
                Rating = 2,
                ReviewText = "My wife's attitude was the only thing rougher than the sand at the nearby beaches",
            });

// Debugging variables
            string strCustomer = "Start";
            int propertyNumber = 0;

            // Add reviews to the database with error handling
            try
            {
                foreach (Review seedReview in AllReviews)
                {
                    // Track current review being processed
                    strCustomer = seedReview.Customer;
                    propertyNumber = seedReview.PropertyNumber;

                    // Check if the review exists in the database
                    Review dbReview = db.Reviews.FirstOrDefault(r => r.Customer == seedReview.Customer &&
                                                                     r.PropertyNumber == seedReview.PropertyNumber);

                    // If the review isn't in the database, add it
                    if (dbReview == null)
                    {
                        db.Reviews.Add(seedReview);
                        db.SaveChanges();
                    }
                    else // If the review exists, update it
                    {
                        dbReview.DisputeStatus = seedReview.DisputeStatus;
                        dbReview.HostComments = seedReview.HostComments;
                        dbReview.Rating = seedReview.Rating;
                        dbReview.ReviewText = seedReview.ReviewText;

                        // Save updates
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex) // Handle database errors
            {
                StringBuilder msg = new StringBuilder();
                msg.Append("Error adding or updating review for Customer: ");
                msg.Append(strCustomer);
                msg.Append(" at PropertyNumber: ");
                msg.Append(propertyNumber);

                // Throw exception with additional details
                throw new Exception(msg.ToString(), ex);
            }
        }
    }
}
