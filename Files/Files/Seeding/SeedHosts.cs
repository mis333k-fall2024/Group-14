
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
                    UserName = "jacobs@yahoo.com",
                    Email = "jacobs@yahoo.com",
                    PhoneNumber = "8176663948",

                    FirstName = "Todd",
                    LastName = "Jacobs",
                    DOB = new DateTime(1978, 1, 29),
                    Address = "4564 Elm St.",
                },
                Password = "tj2245",
                RoleName = "Host"
            });
        
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "rice@yahoo.com",
                    Email = "rice@yahoo.com",
                    PhoneNumber = "2148545987",

                    FirstName = "Eryn",
                    LastName = "Rice",
                    DOB = new DateTime(2003, 6, 11),
                    Address = "3405 Rio Grande",
                },
                Password = "ricearoni",
                RoleName = "Host"
            });
        
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "ingram@gmail.com",
                    Email = "ingram@gmail.com",
                    PhoneNumber = "5127049017",

                    FirstName = "John",
                    LastName = "Ingram",
                    DOB = new DateTime(1980, 6, 25),
                    Address = "6548 La Posada Ct.",
                },
                Password = "ingram68",
                RoleName = "Host"
            });
        
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "martinez@aol.com",
                    Email = "martinez@aol.com",
                    PhoneNumber = "2105859369",

                    FirstName = "Paul",
                    LastName = "Martinez",
                    DOB = new DateTime(1969, 6, 25),
                    Address = "8295 Sunset Blvd.",
                },
                Password = "party1",
                RoleName = "Host"
            });
        
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "tanner@utexas.edu",
                    Email = "tanner@utexas.edu",
                    PhoneNumber = "5129527803",

                    FirstName = "Jared",
                    LastName = "Tanner",
                    DOB = new DateTime(1979, 6, 2),
                    Address = "4347 Almstead",
                },
                Password = "sandman",
                RoleName = "Host"
            });
        
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "chung@yahoo.com",
                    Email = "chung@yahoo.com",
                    PhoneNumber = "2107053952",

                    FirstName = "Lauren",
                    LastName = "Chung",
                    DOB = new DateTime(1976, 3, 24),
                    Address = "234 RR 12",
                },
                Password = "listen",
                RoleName = "Host"
            });
        
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "loter@yahoo.com",
                    Email = "loter@yahoo.com",
                    PhoneNumber = "5124650249",

                    FirstName = "Wandavison",
                    LastName = "Loter",
                    DOB = new DateTime(1966, 9, 23),
                    Address = "3453 RR 3235",
                },
                Password = "pottery",
                RoleName = "Host"
            });
        
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "morales@aol.com",
                    Email = "morales@aol.com",
                    PhoneNumber = "8177529019",

                    FirstName = "Heather",
                    LastName = "Morales",
                    DOB = new DateTime(1971, 1, 16),
                    Address = "4501 RR 140",
                },
                Password = "heckin",
                RoleName = "Host"
            });
        
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "rankin@yahoo.com",
                    Email = "rankin@yahoo.com",
                    PhoneNumber = "5122997370",

                    FirstName = "Martin",
                    LastName = "Rankin",
                    DOB = new DateTime(1961, 5, 16),
                    Address = "340 Second St",
                },
                Password = "rankmark",
                RoleName = "Host"
            });
        
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "gonzalez@aol.com",
                    Email = "gonzalez@aol.com",
                    PhoneNumber = "2142415970",

                    FirstName = "Garth",
                    LastName = "Gonzalez",
                    DOB = new DateTime(1993, 12, 10),
                    Address = "103 Manor Rd",
                },
                Password = "gg2017",
                RoleName = "Host"
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
