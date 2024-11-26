
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
                    UserName = "cbaker@freezing.co.uk",
                    Email = "cbaker@freezing.co.uk",
                    PhoneNumber = "5125595133",

                    FirstName = "Christopher",
                    LastName = "Baker",
                    DOB = new DateTime(1968, 11, 28), // Converted to DateTime
                    Address = "1245 Lake America Blvd.",
                },
                Password = "hellothere",
                RoleName = "Customer"
            });
        
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "mb@puppy.com",
                    Email = "mb@puppy.com",
                    PhoneNumber = "2102702860",

                    FirstName = "Michelle",
                    LastName = "Bradicus",
                    DOB = new DateTime(1988, 2, 7), // Converted to DateTime
                    Address = "1300 Small Pine Lane",
                },
                Password = "555533",
                RoleName = "Customer"
            });
        
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "fd@puppy.com",
                    Email = "fd@puppy.com",
                    PhoneNumber = "8175683686",

                    FirstName = "Franco",
                    LastName = "Broccoli",
                    DOB = new DateTime(1999, 11, 7), // Converted to DateTime
                    Address = "62 Cookie Rd",
                },
                Password = "666645",
                RoleName = "Customer"
            });
        
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "wendy@puppy.com",
                    Email = "wendy@puppy.com",
                    PhoneNumber = "5125967209",

                    FirstName = "Wendy",
                    LastName = "Charile",
                    DOB = new DateTime(1992, 10, 27), // Converted to DateTime
                    Address = "202 Bellmoth Hall",
                },
                Password = "Kansas",
                RoleName = "Customer"
            });
        
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "limchou@puppy.com",
                    Email = "limchou@puppy.com",
                    PhoneNumber = "2107748586",

                    FirstName = "Lim",
                    LastName = "Chou",
                    DOB = new DateTime(1961, 11, 11), // Converted to DateTime
                    Address = "1600 Barbara Lane",
                },
                Password = "Rockwall",
                RoleName = "Customer"
            });
        
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "444444.Dave@aool.com",
                    Email = "444444.Dave@aool.com",
                    PhoneNumber = "2142667242",

                    FirstName = "Shan",
                    LastName = "Dave",
                    DOB = new DateTime(1972, 12, 19), // Converted to DateTime
                    Address = "234 Puppy Circle",
                },
                Password = "444444",
                RoleName = "Customer"
            });
        
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "louann@puppy.com",
                    Email = "louann@puppy.com",
                    PhoneNumber = "8172580736",

                    FirstName = "Lou Ann",
                    LastName = "Feeley",
                    DOB = new DateTime(1958, 8, 1), // Converted to DateTime
                    Address = "700 S 9th Street W",
                },
                Password = "longhorns",
                RoleName = "Customer"
            });
        
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "tfreeley@puppy.com",
                    Email = "tfreeley@puppy.com",
                    PhoneNumber = "8173279674",

                    FirstName = "Tesa",
                    LastName = "Freeley",
                    DOB = new DateTime(2001, 7, 12), // Converted to DateTime
                    Address = "4334 Meanview Ave.",
                },
                Password = "puppies",
                RoleName = "Customer"
            });
        
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "mgar@puppy.com",
                    Email = "mgar@puppy.com",
                    PhoneNumber = "8176617531",

                    FirstName = "Margaret",
                    LastName = "Garcia",
                    DOB = new DateTime(1956, 11, 17), // Converted to DateTime
                    Address = "594 Puppyview",
                },
                Password = "horses",
                RoleName = "Customer"
            });
        
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "chaley@thug.com",
                    Email = "chaley@thug.com",
                    PhoneNumber = "2148499570",

                    FirstName = "Charles",
                    LastName = "Harley",
                    DOB = new DateTime(1998, 5, 29), // Converted to DateTime
                    Address = "One Ranger Pkwy",
                },
                Password = "mycats",
                RoleName = "Customer"
            });
        
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "wjhearniii@umch.edu",
                    Email = "wjhearniii@umch.edu",
                    PhoneNumber = "2148989608",

                    FirstName = "John",
                    LastName = "Hearn",
                    DOB = new DateTime(1983, 12, 29), // Converted to DateTime
                    Address = "4445 South First",
                },
                Password = "posicles",
                RoleName = "Customer"
            });
        
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "hicks43@puppy.com",
                    Email = "hicks43@puppy.com",
                    PhoneNumber = "2105812952",

                    FirstName = "Mark",
                    LastName = "Hicks",
                    DOB = new DateTime(1989, 12, 16), // Converted to DateTime
                    Address = "32 NE Mark Ln., Ste 910",
                },
                Password = "guac45",
                RoleName = "Customer"
            });
        
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "bradsingram@mall.utexas.edu",
                    Email = "bradsingram@mall.utexas.edu",
                    PhoneNumber = "5124702808",

                    FirstName = "Brad",
                    LastName = "Ingram",
                    DOB = new DateTime(1958, 9, 18), // Converted to DateTime
                    Address = "6548 La Chess St.",
                },
                Password = "father",
                RoleName = "Customer"
            });
        
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "father.Ingram@aool.com",
                    Email = "father.Ingram@aool.com",
                    PhoneNumber = "5124677352",

                    FirstName = "Todd",
                    LastName = "Jacobs",
                    DOB = new DateTime(1975, 12, 9), // Converted to DateTime
                    Address = "4564 Palm St.",
                },
                Password = "555897",
                RoleName = "Customer"
            });
        
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "victoria@puppy.com",
                    Email = "victoria@puppy.com",
                    PhoneNumber = "5129481386",

                    FirstName = "Victoria",
                    LastName = "Lawrence",
                    DOB = new DateTime(1981, 5, 29), // Converted to DateTime
                    Address = "6639 Butterfly Ln.",
                },
                Password = "something",
                RoleName = "Customer"
            });
        
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "lineback@flush.net",
                    Email = "lineback@flush.net",
                    PhoneNumber = "2102473963",

                    FirstName = "Brad",
                    LastName = "Lineback",
                    DOB = new DateTime(1973, 5, 19), // Converted to DateTime
                    Address = "1300 Pirateland St",
                },
                Password = "treelover",
                RoleName = "Customer"
            });
        
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "elowe@netscrape.net",
                    Email = "elowe@netscrape.net",
                    PhoneNumber = "2105368614",

                    FirstName = "Evan",
                    LastName = "Lowe",
                    DOB = new DateTime(1993, 6, 7), // Converted to DateTime
                    Address = "3201 Pineapple Drive",
                },
                Password = "headear",
                RoleName = "Customer"
            });
        
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "luce_chuck@puppy.com",
                    Email = "luce_chuck@puppy.com",
                    PhoneNumber = "2107007535",

                    FirstName = "Chuck",
                    LastName = "Luce",
                    DOB = new DateTime(1995, 6, 11), // Converted to DateTime
                    Address = "2345 Silent Clouds",
                },
                Password = "gooseyloosey",
                RoleName = "Customer"
            });
        
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "mackcloud@pimpdaddy.com",
                    Email = "mackcloud@pimpdaddy.com",
                    PhoneNumber = "5124772125",

                    FirstName = "Jennifer",
                    LastName = "MacLeod",
                    DOB = new DateTime(1965, 10, 11), // Converted to DateTime
                    Address = "2504 Far East Blvd.",
                },
                Password = "rainyday",
                RoleName = "Customer"
            });
        
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "liz@puppy.com",
                    Email = "liz@puppy.com",
                    PhoneNumber = "5124603832",

                    FirstName = "Elizabeth",
                    LastName = "Markham",
                    DOB = new DateTime(1989, 6, 18), // Converted to DateTime
                    Address = "7861 Chevy Mace Rd",
                },
                Password = "ember22",
                RoleName = "Customer"
            });
        
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "mclarence@puppy.com",
                    Email = "mclarence@puppy.com",
                    PhoneNumber = "8174979188",

                    FirstName = "Clarence",
                    LastName = "Martin",
                    DOB = new DateTime(1984, 4, 28), // Converted to DateTime
                    Address = "87 Alcedo St.",
                },
                Password = "lamemartin",
                RoleName = "Customer"
            });
        
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "lamemartin.Martin@aool.com",
                    Email = "lamemartin.Martin@aool.com",
                    PhoneNumber = "8178770705",

                    FirstName = "Gregory",
                    LastName = "Martinez",
                    DOB = new DateTime(1981, 12, 27), // Converted to DateTime
                    Address = "8295 Moon Blvd.",
                },
                Password = "gregory",
                RoleName = "Customer"
            });
        
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "cmiller@mapster.com",
                    Email = "cmiller@mapster.com",
                    PhoneNumber = "8177482602",

                    FirstName = "Charles",
                    LastName = "Miller",
                    DOB = new DateTime(1987, 5, 5), // Converted to DateTime
                    Address = "8962 Side St.",
                },
                Password = "mucky44",
                RoleName = "Customer"
            });
        
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "nelson.Kelly@puppy.com",
                    Email = "nelson.Kelly@puppy.com",
                    PhoneNumber = "5122950953",

                    FirstName = "Kelly",
                    LastName = "Nelson",
                    DOB = new DateTime(1969, 8, 3), // Converted to DateTime
                    Address = "2601 Green River",
                },
                Password = "Tree34",
                RoleName = "Customer"
            });
        
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "jojoe@puppy.com",
                    Email = "jojoe@puppy.com",
                    PhoneNumber = "2143149884",

                    FirstName = "Joe",
                    LastName = "Nguyen",
                    DOB = new DateTime(1956, 2, 6), // Converted to DateTime
                    Address = "1249 4th NW St.",
                },
                Password = "jvb485bg",
                RoleName = "Customer"
            });
        
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "orielly@foxnets.com",
                    Email = "orielly@foxnets.com",
                    PhoneNumber = "2103474912",

                    FirstName = "Bill",
                    LastName = "O'Reilly",
                    DOB = new DateTime(1989, 3, 14), // Converted to DateTime
                    Address = "8800 Gringo Drive",
                },
                Password = "Bobbygirl",
                RoleName = "Customer"
            });
        
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "or@puppy.com",
                    Email = "or@puppy.com",
                    PhoneNumber = "2142369553",

                    FirstName = "Anka",
                    LastName = "Radkovich",
                    DOB = new DateTime(1952, 10, 26), // Converted to DateTime
                    Address = "1300 Freaky",
                },
                Password = "radioactive",
                RoleName = "Customer"
            });
        
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "megrhodes@freezing.co.uk",
                    Email = "megrhodes@freezing.co.uk",
                    PhoneNumber = "5123768733",

                    FirstName = "Megan",
                    LastName = "Rhodes",
                    DOB = new DateTime(1958, 3, 18), // Converted to DateTime
                    Address = "4587 Rightfield Rd.",
                },
                Password = "gopigs",
                RoleName = "Customer"
            });
        
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "erynrice@puppy.com",
                    Email = "erynrice@puppy.com",
                    PhoneNumber = "5123900644",

                    FirstName = "Eryn",
                    LastName = "Rice",
                    DOB = new DateTime(2000, 11, 2), // Converted to DateTime
                    Address = "3405 Rio Small",
                },
                Password = "iloveme",
                RoleName = "Customer"
            });
        
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "jorge@hootmail.com",
                    Email = "jorge@hootmail.com",
                    PhoneNumber = "8178928361",

                    FirstName = "Jorge",
                    LastName = "Rodriguez",
                    DOB = new DateTime(1979, 1, 1), // Converted to DateTime
                    Address = "6788 Cotten Street",
                },
                Password = "565656",
                RoleName = "Customer"
            });
        
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "ra@aoo.com",
                    Email = "ra@aoo.com",
                    PhoneNumber = "5128776930",

                    FirstName = "Allen",
                    LastName = "Rogers",
                    DOB = new DateTime(2000, 3, 12), // Converted to DateTime
                    Address = "4965 Rabbit Hill",
                },
                Password = "treeman",
                RoleName = "Customer"
            });
        
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "o_st-jean@home.com",
                    Email = "o_st-jean@home.com",
                    PhoneNumber = "2104169665",

                    FirstName = "Olivier",
                    LastName = "Saint-Jean",
                    DOB = new DateTime(1997, 5, 1), // Converted to DateTime
                    Address = "255 Slap Dr.",
                },
                Password = "55htrq",
                RoleName = "Customer"
            });
        
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "ss34@puppy.com",
                    Email = "ss34@puppy.com",
                    PhoneNumber = "5123521797",

                    FirstName = "Sarah",
                    LastName = "Saunders",
                    DOB = new DateTime(1994, 5, 31), // Converted to DateTime
                    Address = "332 Fish C",
                },
                Password = "leaves",
                RoleName = "Customer"
            });
        
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "willsheff@email.com",
                    Email = "willsheff@email.com",
                    PhoneNumber = "5124534071",

                    FirstName = "William",
                    LastName = "Sewell",
                    DOB = new DateTime(1951, 12, 10), // Converted to DateTime
                    Address = "2365 34st St.",
                },
                Password = "borbj44",
                RoleName = "Customer"
            });
        
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "sheff44@puppy.com",
                    Email = "sheff44@puppy.com",
                    PhoneNumber = "5125503154",

                    FirstName = "Martin",
                    LastName = "Sheffield",
                    DOB = new DateTime(1993, 7, 2), // Converted to DateTime
                    Address = "3886 Road A",
                },
                Password = "ldiul485",
                RoleName = "Customer"
            });
        
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "johnsmith187@puppy.com",
                    Email = "johnsmith187@puppy.com",
                    PhoneNumber = "2108345875",

                    FirstName = "John",
                    LastName = "Smith",
                    DOB = new DateTime(1985, 6, 13), // Converted to DateTime
                    Address = "23 Known Forge Dr.",
                },
                Password = "kribv75",
                RoleName = "Customer"
            });
        
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "jeff@puppy.com",
                    Email = "jeff@puppy.com",
                    PhoneNumber = "5127002600",

                    FirstName = "Jeffrey",
                    LastName = "Stark",
                    DOB = new DateTime(1974, 5, 2), // Converted to DateTime
                    Address = "337 40th St.",
                },
                Password = "jeffery",
                RoleName = "Customer"
            });
        
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "dustroud@mail.com",
                    Email = "dustroud@mail.com",
                    PhoneNumber = "2142370654",

                    FirstName = "Dustin",
                    LastName = "Stroud",
                    DOB = new DateTime(1974, 7, 14), // Converted to DateTime
                    Address = "1212 Henrietta Rd",
                },
                Password = "klavjkb48",
                RoleName = "Customer"
            });
        
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "eric_stuart@puppy.com",
                    Email = "eric_stuart@puppy.com",
                    PhoneNumber = "5128202322",

                    FirstName = "Eric",
                    LastName = "Stuart",
                    DOB = new DateTime(1968, 6, 17), // Converted to DateTime
                    Address = "5576 Big Ring",
                },
                Password = "vkb451",
                RoleName = "Customer"
            });
        
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "peterstump@hootmail.com",
                    Email = "peterstump@hootmail.com",
                    PhoneNumber = "8174584890",

                    FirstName = "Peter",
                    LastName = "Stump",
                    DOB = new DateTime(2001, 7, 23), // Converted to DateTime
                    Address = "1300 Kellen Square",
                },
                Password = "kdsiu4",
                RoleName = "Customer"
            });
        
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "tanner@puppy.com",
                    Email = "tanner@puppy.com",
                    PhoneNumber = "8174614916",

                    FirstName = "Jeremy",
                    LastName = "Tanner",
                    DOB = new DateTime(1973, 12, 28), // Converted to DateTime
                    Address = "4347 Palmstead",
                },
                Password = "klrfbj45",
                RoleName = "Customer"
            });
        
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "taylordjay@puppy.com",
                    Email = "taylordjay@puppy.com",
                    PhoneNumber = "5124772439",

                    FirstName = "Allison",
                    LastName = "Taylor",
                    DOB = new DateTime(1999, 9, 30), // Converted to DateTime
                    Address = "467 Nueces St.",
                },
                Password = "lraggrhb854",
                RoleName = "Customer"
            });
        
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "lraggrhb854.Taylor@aool.com",
                    Email = "lraggrhb854.Taylor@aool.com",
                    PhoneNumber = "5124536618",

                    FirstName = "Rachel",
                    LastName = "Taylor",
                    DOB = new DateTime(1956, 2, 24), // Converted to DateTime
                    Address = "345 Shortview Dr.",
                },
                Password = "alsuib95",
                RoleName = "Customer"
            });
        
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "tee_frank@hootmail.com",
                    Email = "tee_frank@hootmail.com",
                    PhoneNumber = "8178789530",

                    FirstName = "Frank",
                    LastName = "Tee",
                    DOB = new DateTime(1964, 11, 11), // Converted to DateTime
                    Address = "5590 Big Dr.",
                },
                Password = "kd1734",
                RoleName = "Customer"
            });
        
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "tuck33@puppy.com",
                    Email = "tuck33@puppy.com",
                    PhoneNumber = "2148495141",

                    FirstName = "Clent",
                    LastName = "Tucker",
                    DOB = new DateTime(1990, 6, 25), // Converted to DateTime
                    Address = "3132 Main St.",
                },
                Password = "kjdb983",
                RoleName = "Customer"
            });
        
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "avelasco@puppy.com",
                    Email = "avelasco@puppy.com",
                    PhoneNumber = "2144009625",

                    FirstName = "Allen",
                    LastName = "Velasco",
                    DOB = new DateTime(1966, 12, 13), // Converted to DateTime
                    Address = "634 W. 4th",
                },
                Password = "odrb02",
                RoleName = "Customer"
            });
        
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "westj@pioneer.net",
                    Email = "westj@pioneer.net",
                    PhoneNumber = "2148499231",

                    FirstName = "Jake",
                    LastName = "West",
                    DOB = new DateTime(1968, 2, 6), // Converted to DateTime
                    Address = "RR 3244",
                },
                Password = "kndl847",
                RoleName = "Customer"
            });
        
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "louielouie@puppy.com",
                    Email = "louielouie@puppy.com",
                    PhoneNumber = "2145674085",

                    FirstName = "Louis",
                    LastName = "Winthorpe",
                    DOB = new DateTime(1961, 7, 23), // Converted to DateTime
                    Address = "2500 Madre Blvd",
                },
                Password = "lb2394",
                RoleName = "Customer"
            });
        
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "rwood@voyager.net",
                    Email = "rwood@voyager.net",
                    PhoneNumber = "5124569229",

                    FirstName = "Reagan",
                    LastName = "Wood",
                    DOB = new DateTime(1988, 10, 24), // Converted to DateTime
                    Address = "447 Westlake Dr.",
                },
                Password = "drai494",
                RoleName = "Customer"
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
