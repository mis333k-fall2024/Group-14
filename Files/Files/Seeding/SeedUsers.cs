using Microsoft.AspNetCore.Identity;


//Update these using statements to include your project name
using Files.Utilities;
using Files.DAL;
using Files.Models;

//Upddate this namespace to match your project name
namespace Files.Seeding
{
    public static class SeedUsers
    {
        public async static Task<IdentityResult> SeedAllUsers(UserManager<AppUser> userManager, AppDbContext context)
        {
            //Create a list of AddUserModels
            List<AddUserModel> AllUsers = new List<AddUserModel>();

            //NOTE: Admin Users Begin here
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
                    Address = "467 Nueces St. 75237",
                    Status = HireStatus.Hired,
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
                    Address = "3886 Avenue A 78736",
                    Status = HireStatus.Hired,
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
                    Address = "2504 Far West Blvd. 78731",
                    Status = HireStatus.Hired,
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
                    Address = "4587 Enfield Rd. 78293",
                    Status = HireStatus.Hired,
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
                    Address = "5576 Toro Ring 78279",
                    Status = HireStatus.Hired,
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
                    Address = "245 River Rd 78731",
                    Status = HireStatus.Hired,
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
                    Address = "12 Valley View 77045",
                    Status = HireStatus.Hired,
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
                    Address = "210 Blanco Dr 77030",
                    Status = HireStatus.Hired,
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
                    Address = "9 Bison Circle 75238",
                    Status = HireStatus.Hired,
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
                    Address = "9003 Joshua St 78260",
                    Status = HireStatus.Hired,
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
                    Address = "4 Privet Dr 78705",
                    Status = HireStatus.Hired,
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
                    Address = "2110 Speedway 78705",
                    Status = HireStatus.Hired,
                },
                Password = "KIzGreat",
                RoleName = "Admin"
            });

            //NOTE: Customer Users Begin here
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
                    Address = "1245 Lake America Blvd. 78733",
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
                    Address = "1300 Small Pine Lane 78261",
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
                    Address = "62 Cookie Rd 77019",
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
                    Address = "202 Bellmoth Hall 78713",
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
                    Address = "1600 Barbara Lane 78266",
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
                    Address = "234 Puppy Circle 75208",
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
                    Address = "700 S 9th Street W 77010",
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
                    Address = "4334 Meanview Ave. 77009",
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
                    Address = "594 Puppyview 77003",
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
                    Address = "One Ranger Pkwy 75261",
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
                    Address = "4445 South First 75237",
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
                    Address = "32 NE Mark Ln., Ste 910 78239",
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
                    Address = "6548 La Chess St. 78736",
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
                    Address = "4564 Palm St. 78731",
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
                    Address = "6639 Butterfly Ln. 78761",
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
                    Address = "1300 Pirateland St 78293",
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
                    Address = "3201 Pineapple Drive 78279",
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
                    Address = "2345 Silent Clouds 78268",
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
                    Address = "2504 Far East Blvd. 78731",
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
                    Address = "7861 Chevy Mace Rd 78732",
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
                    Address = "87 Alcedo St. 77045",
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
                    Address = "8295 Moon Blvd. 77030",
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
                    Address = "8962 Side St. 77031",
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
                    Address = "2601 Green River 78703",
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
                    Address = "1249 4th NW St. 75238",
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
                    Address = "8800 Gringo Drive 78260",
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
                    Address = "1300 Freaky 75260",
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
                    Address = "4587 Rightfield Rd. 78707",
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
                    Address = "3405 Rio Small 78705",
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
                    Address = "6788 Cotten Street 77057",
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
                    Address = "4965 Rabbit Hill 78732",
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
                    Address = "255 Slap Dr. 78292",
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
                    Address = "332 Fish C 78705",
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
                    Address = "2365 34st St. 78709",
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
                    Address = "3886 Road A 78705",
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
                    Address = "23 Known Forge Dr. 78280",
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
                    Address = "337 40th St. 78705",
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
                    Address = "1212 Henrietta Rd 75221",
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
                    Address = "5576 Big Ring 78746",
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
                    Address = "1300 Kellen Square 77018",
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
                    Address = "4347 Palmstead 77044",
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
                    Address = "467 Nueces St. 78705",
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
                    Address = "345 Shortview Dr. 78705",
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
                    Address = "5590 Big Dr. 77004",
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
                    Address = "3132 Main St. 75315",
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
                    Address = "634 W. 4th 75207",
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
                    Address = "RR 3244 75323",
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
                    Address = "2500 Madre Blvd 78746",
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
                    Address = "447 Westlake Dr. 78746",
                },
                Password = "drai494",
                RoleName = "Customer"
            });

            //NOTE: Host Users Begin here

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
                    Address = "4564 Elm St. 77003",
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
                    Address = "3405 Rio Grande 75261",
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
                    Address = "6548 La Posada Ct. 78705",
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
                    Address = "8295 Sunset Blvd. 78239",
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
                    Address = "4347 Almstead 78761",
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
                    Address = "234 RR 12 78268",
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
                    Address = "3453 RR 3235 78732",
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
                    Address = "4501 RR 140 77031",
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
                    Address = "340 Second St 78703",
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
                    Address = "103 Manor Rd 75260",
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
