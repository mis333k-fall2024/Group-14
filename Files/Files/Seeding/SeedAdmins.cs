
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

    public static class SeedUsers
    {
        public async static Task<IdentityResult> SeedAllUsers(UserManager<AppUser> userManager, AppDbContext context)
        {
            List<AddUserModel> AllUsers = new List<AddUserModel>();
    
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "taylor@bevobnb.com",
                    Email = "taylor@bevobnb.com",
                    PhoneNumber = "2149036025",

                    FirstName = "Albert",
                    LastName = "Taylor",
                    DOB = new DateTime(1954, 8, 14), 
                    Address = "467 Nueces St.",
                },
                Password = "TRY563",
                RoleName = "Admin"
            });
        
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "sheffield@bevobnb.com",
                    Email = "sheffield@bevobnb.com",
                    PhoneNumber = "5124749225",

                    FirstName = "Molly",
                    LastName = "Sheffield",
                    DOB = new DateTime(1986, 8, 27), 
                    Address = "3886 Avenue A",
                },
                Password = "longsnores",
                RoleName = "Admin"
            });
        
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "macleod@bevobnb.com",
                    Email = "macleod@bevobnb.com",
                    PhoneNumber = "5124723769",

                    FirstName = "Jenny",
                    LastName = "MacLeod",
                    DOB = new DateTime(1984, 12, 5), 
                    Address = "2504 Far West Blvd.",
                },
                Password = "kittys",
                RoleName = "Admin"
            });
        
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "rhodes@bevobnb.com",
                    Email = "rhodes@bevobnb.com",
                    PhoneNumber = "2102520380",

                    FirstName = "Michelle",
                    LastName = "Rhodes",
                    DOB = new DateTime(1972, 7, 2), 
                    Address = "4587 Enfield Rd.",
                },
                Password = "puppies",
                RoleName = "Admin"
            });
        
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "stuart@bevobnb.com",
                    Email = "stuart@bevobnb.com",
                    PhoneNumber = "2105415031",

                    FirstName = "Evan",
                    LastName = "Stuart",
                    DOB = new DateTime(1984, 4, 17), 
                    Address = "5576 Toro Ring",
                },
                Password = "coolboi",
                RoleName = "Admin"
            });
        
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "swanson@bevobnb.com",
                    Email = "swanson@bevobnb.com",
                    PhoneNumber = "5124818542",

                    FirstName = "Ron",
                    LastName = "Swanson",
                    DOB = new DateTime(1991, 7, 25), 
                    Address = "245 River Rd",
                },
                Password = "swanbong",
                RoleName = "Admin"
            });
        
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "white@bevobnb.com",
                    Email = "white@bevobnb.com",
                    PhoneNumber = "8175025605",

                    FirstName = "Jabriel",
                    LastName = "White",
                    DOB = new DateTime(1986, 3, 17), 
                    Address = "12 Valley View",
                },
                Password = "456789",
                RoleName = "Admin"
            });
        
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "montgomery@bevobnb.com",
                    Email = "montgomery@bevobnb.com",
                    PhoneNumber = "8178817122",

                    FirstName = "Washington",
                    LastName = "Montgomery",
                    DOB = new DateTime(1961, 5, 4), 
                    Address = "210 Blanco Dr",
                },
                Password = "python4",
                RoleName = "Admin"
            });
        
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "walker@bevobnb.com",
                    Email = "walker@bevobnb.com",
                    PhoneNumber = "2143196301",

                    FirstName = "Lisa",
                    LastName = "Walker",
                    DOB = new DateTime(2003, 4, 18), 
                    Address = "9 Bison Circle",
                },
                Password = "walkameter",
                RoleName = "Admin"
            });
        
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "chang@bevobnb.com",
                    Email = "chang@bevobnb.com",
                    PhoneNumber = "2103521329",

                    FirstName = "Gregory",
                    LastName = "Chang",
                    DOB = new DateTime(1958, 4, 26), 
                    Address = "9003 Joshua St",
                },
                Password = "pupgang",
                RoleName = "Admin"
            });
        
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "derek@bevobnb.com",
                    Email = "derek@bevobnb.com",
                    PhoneNumber = "5125556789",

                    FirstName = "Derek",
                    LastName = "Dreibrodt",
                    DOB = new DateTime(2001, 1, 1), 
                    Address = "4 Privet Dr",
                },
                Password = "2cool4u",
                RoleName = "Admin"
            });
        
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "rester@bevobnb.com",
                    Email = "rester@bevobnb.com",
                    PhoneNumber = "2103521329",

                    FirstName = "Amy",
                    LastName = "Rester",
                    DOB = new DateTime(2000, 1, 1), 
                    Address = "2110 Speedway",
                },
                Password = "KIzGreat",
                RoleName = "Admin"
            });
        
            //create flag to help with errors
            String errorFlag = "Start";

            //create an identity result
            IdentityResult result = new IdentityResult();
            //call the method to seed the user
            try
            {
                foreach (AddUserModel aum in AllUsers)
                {
                    errorFlag = aum.User.Email;
                    // Took Utilities.AddUser from Relational Data Demo -> this is "Utilities/AddUser.cs"
                    result = await Utilities.AddUser.AddUserWithRoleAsync(aum, userManager, context);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("There was a problem adding the user with email: " 
                    + errorFlag, ex);
            }

            return result;

        }
    }
}
