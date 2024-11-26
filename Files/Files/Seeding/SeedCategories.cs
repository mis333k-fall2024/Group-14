
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


    public static class SeedCategories
    {
        public static void SeedAllCategories(AppDbContext db)
        {
            List<Category>AllCategories = new List<Category>();
    


            AllCategories.Add(new Category
            {
                CategoryName = "House",
            }) ; 


            AllCategories.Add(new Category
            {
                CategoryName = "Cabin",
            }) ; 


            AllCategories.Add(new Category
            {
                CategoryName = "Apartment",
            }) ; 


            AllCategories.Add(new Category
            {
                CategoryName = "Condo",
            }) ; 


            AllCategories.Add(new Category
            {
                CategoryName = "Hotel",
            }) ; 

            //create a counter and flag to help with debugging
            int intCategoryID = 0;
            String strCategoryName = "Start";

            //we are now going to add the data to the database
            //this could cause errors, so we need to put this code
            //into a Try/Catch block
            try
            {
                foreach (Category seedCategory in AllCategories)
                {
                    //updates the counters to get info on where the problem is
                    intCategoryID = seedCategory.CategoryID;
                    strCategoryName = seedCategory.CategoryName;

                    //try to find the Category in the database
                    Category dbCategory = db.Categories.FirstOrDefault(c => c.CategoryName == seedCategory.CategoryName);

                    //if the Category isn't in the database, dbCategory will be null
                    if (dbCategory == null)
                    {
                        //add the Category to the database
                        db.Categories.Add(seedCategory);
                        db.SaveChanges();
                    }
                    else //the record is in the database
                    {
                        //update all the fields
                        //this isn't really needed for Category because it only has one field
                        //but you will need it to re-set seeded data with more fields
                        dbCategory.CategoryName = seedCategory.CategoryName;
                        //you would add other fields here
                        db.SaveChanges();
                    }

                }
            }
            catch (Exception ex) //something about adding to the database caused a problem
            {
                //create a new instance of the string builder to make building out 
                //our message neater - we don't want a REALLY long line of code for this
                //so we break it up into several lines
                StringBuilder msg = new StringBuilder();

                msg.Append("There was an error adding the ");
                msg.Append(strCategoryName);
                msg.Append(" Category (CategoryID = ");
                msg.Append(intCategoryID);
                msg.Append(")");

                //have this method throw the exception to the calling method
                //this code wraps the exception from the database with the 
                //custom message we built above. The original error from the
                //database becomes the InnerException
                throw new Exception(msg.ToString(), ex);
            }
  
        }
    }
        
}
