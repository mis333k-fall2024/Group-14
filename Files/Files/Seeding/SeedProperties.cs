
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


    public static class SeedProperties
    {
        public static void SeedAllProperties(AppDbContext db)
        {
            List<Property> AllProperties = new List<Property>();


            AllProperties.Add(new Property
            {
                PropertyNumber = 3001,
                Zip = 72227, // Int32
                State = "PA",
                Street = "8714 Mann Plaza",
                City = "Lisaside",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "gonzalez@aol.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "House"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 5, // Int32
                Bathrooms = 6, // Int32
                GuestsAllowed = 9, // Int32
                WeekdayPrice = 152.68m, // Decimal (2 decimal places)
                WeekendPrice = 171.57m, // Decimal (2 decimal places)
                CleaningFee = 8.88m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3002,
                Zip = 5565, // Int32
                State = "FL",
                Street = "96593 White View Apt. 094",
                City = "Jonesberg",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "gonzalez@aol.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Apartment"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 7, // Int32
                Bathrooms = 8, // Int32
                GuestsAllowed = 8, // Int32
                WeekdayPrice = 120.81m, // Decimal (2 decimal places)
                WeekendPrice = 148.15m, // Decimal (2 decimal places)
                CleaningFee = 8.02m, // Decimal (2 decimal places)
                DiscountMinStay = 4,
                DiscountRate = 0.14m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3003,
                Zip = 80819, // Int32
                State = "MD",
                Street = "848 Melissa Springs Suite 947",
                City = "Kellerstad",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "rankin@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Condo"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 5, // Int32
                Bathrooms = 7, // Int32
                GuestsAllowed = 8, // Int32
                WeekdayPrice = 127.96m, // Decimal (2 decimal places)
                WeekendPrice = 132.99m, // Decimal (2 decimal places)
                CleaningFee = 13.37m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3004,
                Zip = 79428, // Int32
                State = "ND",
                Street = "30413 Norton Isle Suite 012",
                City = "North Lisa",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "rankin@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Hotel"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 1, // Int32
                Bathrooms = 3, // Int32
                GuestsAllowed = 14, // Int32
                WeekdayPrice = 80.20m, // Decimal (2 decimal places)
                WeekendPrice = 185.35m, // Decimal (2 decimal places)
                CleaningFee = 5.57m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3005,
                Zip = 63315, // Int32
                State = "DE",
                Street = "39916 Mitchell Crescent",
                City = "New Andrewburgh",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "loter@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Cabin"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 2, // Int32
                Bathrooms = 3, // Int32
                GuestsAllowed = 12, // Int32
                WeekdayPrice = 170.25m, // Decimal (2 decimal places)
                WeekendPrice = 100.37m, // Decimal (2 decimal places)
                CleaningFee = 18.64m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3006,
                Zip = 24135, // Int32
                State = "NE",
                Street = "086 Mary Cliff",
                City = "North Deborah",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "rice@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "House"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 7, // Int32
                Bathrooms = 9, // Int32
                GuestsAllowed = 2, // Int32
                WeekdayPrice = 220.24m, // Decimal (2 decimal places)
                WeekendPrice = 162.60m, // Decimal (2 decimal places)
                CleaningFee = 10.83m, // Decimal (2 decimal places)
                DiscountMinStay = 10,
                DiscountRate = 0.24m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3007,
                Zip = 58475, // Int32
                State = "PA",
                Street = "91634 Strong Mountains Apt. 302",
                City = "West Alyssa",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "rice@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Apartment"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 1, // Int32
                Bathrooms = 2, // Int32
                GuestsAllowed = 9, // Int32
                WeekdayPrice = 213.37m, // Decimal (2 decimal places)
                WeekendPrice = 204.87m, // Decimal (2 decimal places)
                CleaningFee = 25.04m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3008,
                Zip = 10865, // Int32
                State = "WA",
                Street = "6984 Price Shoals",
                City = "Erictown",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "tanner@utexas.edu"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Cabin"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 2, // Int32
                Bathrooms = 3, // Int32
                GuestsAllowed = 8, // Int32
                WeekdayPrice = 159.69m, // Decimal (2 decimal places)
                WeekendPrice = 140.89m, // Decimal (2 decimal places)
                CleaningFee = 27.13m, // Decimal (2 decimal places)
                DiscountMinStay = 7,
                DiscountRate = 0.05m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3009,
                Zip = 51359, // Int32
                State = "ME",
                Street = "423 Bell Heights",
                City = "Brittanyberg",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "rice@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Cabin"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 3, // Int32
                Bathrooms = 3, // Int32
                GuestsAllowed = 4, // Int32
                WeekdayPrice = 200.73m, // Decimal (2 decimal places)
                WeekendPrice = 295.39m, // Decimal (2 decimal places)
                CleaningFee = 14.91m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { DateTime.Parse("2024-12-04 00:00:00"), DateTime.Parse("2024-12-05 00:00:00") } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3010,
                Zip = 87296, // Int32
                State = "WI",
                Street = "93523 Dana Lane",
                City = "Johnsonshire",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "ingram@gmail.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Cabin"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 6, // Int32
                Bathrooms = 6, // Int32
                GuestsAllowed = 3, // Int32
                WeekdayPrice = 170.39m, // Decimal (2 decimal places)
                WeekendPrice = 110.80m, // Decimal (2 decimal places)
                CleaningFee = 8.67m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3011,
                Zip = 7035, // Int32
                State = "NH",
                Street = "1427 Odonnell Rapids",
                City = "North Troyport",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "jacobs@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Cabin"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 3, // Int32
                Bathrooms = 3, // Int32
                GuestsAllowed = 14, // Int32
                WeekdayPrice = 217.15m, // Decimal (2 decimal places)
                WeekendPrice = 126.29m, // Decimal (2 decimal places)
                CleaningFee = 26.48m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3012,
                Zip = 37198, // Int32
                State = "ME",
                Street = "81206 Stewart Forest Apt. 089",
                City = "East Davidborough",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "martinez@aol.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Apartment"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 3, // Int32
                Bathrooms = 5, // Int32
                GuestsAllowed = 8, // Int32
                WeekdayPrice = 205.21m, // Decimal (2 decimal places)
                WeekendPrice = 293.26m, // Decimal (2 decimal places)
                CleaningFee = 28.74m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3013,
                Zip = 85034, // Int32
                State = "SD",
                Street = "76104 Marsh Crescent",
                City = "Dennishaven",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "chung@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "House"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 7, // Int32
                Bathrooms = 7, // Int32
                GuestsAllowed = 4, // Int32
                WeekdayPrice = 123.13m, // Decimal (2 decimal places)
                WeekendPrice = 126.99m, // Decimal (2 decimal places)
                CleaningFee = 18.73m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3014,
                Zip = 60619, // Int32
                State = "SD",
                Street = "0003 Grant Lakes",
                City = "Port Karafort",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "jacobs@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "House"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 3, // Int32
                Bathrooms = 5, // Int32
                GuestsAllowed = 14, // Int32
                WeekdayPrice = 89.19m, // Decimal (2 decimal places)
                WeekendPrice = 188.81m, // Decimal (2 decimal places)
                CleaningFee = 11.98m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3015,
                Zip = 21978, // Int32
                State = "KY",
                Street = "236 Smith Drive Suite 555",
                City = "West Kimberlyton",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "jacobs@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Condo"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 1, // Int32
                Bathrooms = 3, // Int32
                GuestsAllowed = 11, // Int32
                WeekdayPrice = 198.30m, // Decimal (2 decimal places)
                WeekendPrice = 132.96m, // Decimal (2 decimal places)
                CleaningFee = 13.96m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3016,
                Zip = 14742, // Int32
                State = "MT",
                Street = "6824 Timothy Garden Apt. 428",
                City = "West Richardmouth",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "rankin@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Apartment"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 6, // Int32
                Bathrooms = 6, // Int32
                GuestsAllowed = 10, // Int32
                WeekdayPrice = 181.50m, // Decimal (2 decimal places)
                WeekendPrice = 297.31m, // Decimal (2 decimal places)
                CleaningFee = 10.09m, // Decimal (2 decimal places)
                DiscountMinStay = 22,
                DiscountRate = 0.13m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3017,
                Zip = 11894, // Int32
                State = "SC",
                Street = "5517 Holly Meadow Apt. 452",
                City = "Lake Anne",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "gonzalez@aol.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Apartment"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 1, // Int32
                Bathrooms = 3, // Int32
                GuestsAllowed = 1, // Int32
                WeekdayPrice = 134.09m, // Decimal (2 decimal places)
                WeekendPrice = 139.22m, // Decimal (2 decimal places)
                CleaningFee = 9.75m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3018,
                Zip = 28976, // Int32
                State = "TX",
                Street = "30601 Hawkins Highway",
                City = "Morashire",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "martinez@aol.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "House"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 6, // Int32
                Bathrooms = 5, // Int32
                GuestsAllowed = 9, // Int32
                WeekdayPrice = 187.65m, // Decimal (2 decimal places)
                WeekendPrice = 160.61m, // Decimal (2 decimal places)
                CleaningFee = 7.50m, // Decimal (2 decimal places)
                DiscountMinStay = 30,
                DiscountRate = 0.11m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3019,
                Zip = 28798, // Int32
                State = "AZ",
                Street = "49263 Wilson View Apt. 873",
                City = "South Raymondborough",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "loter@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Apartment"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 1, // Int32
                Bathrooms = 3, // Int32
                GuestsAllowed = 5, // Int32
                WeekdayPrice = 206.95m, // Decimal (2 decimal places)
                WeekendPrice = 133.25m, // Decimal (2 decimal places)
                CleaningFee = 14.04m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3020,
                Zip = 68819, // Int32
                State = "NE",
                Street = "76582 Vanessa Oval",
                City = "New Richard",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "chung@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "House"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 5, // Int32
                Bathrooms = 4, // Int32
                GuestsAllowed = 12, // Int32
                WeekdayPrice = 99.54m, // Decimal (2 decimal places)
                WeekendPrice = 242.89m, // Decimal (2 decimal places)
                CleaningFee = 6.61m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3021,
                Zip = 50177, // Int32
                State = "FL",
                Street = "7389 Alec Squares Suite 508",
                City = "Port Jonathan",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "loter@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Condo"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 7, // Int32
                Bathrooms = 7, // Int32
                GuestsAllowed = 12, // Int32
                WeekdayPrice = 112.62m, // Decimal (2 decimal places)
                WeekendPrice = 165.32m, // Decimal (2 decimal places)
                CleaningFee = 24.26m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3022,
                Zip = 66355, // Int32
                State = "NC",
                Street = "18013 Billy Bridge Suite 522",
                City = "Schmitthaven",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "martinez@aol.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Hotel"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 3, // Int32
                Bathrooms = 4, // Int32
                GuestsAllowed = 2, // Int32
                WeekdayPrice = 199.21m, // Decimal (2 decimal places)
                WeekendPrice = 119.02m, // Decimal (2 decimal places)
                CleaningFee = 11.63m, // Decimal (2 decimal places)
                DiscountMinStay = 21,
                DiscountRate = 0.13m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3023,
                Zip = 51431, // Int32
                State = "NJ",
                Street = "891 Bullock Ford",
                City = "Amandachester",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "gonzalez@aol.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "House"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 5, // Int32
                Bathrooms = 6, // Int32
                GuestsAllowed = 11, // Int32
                WeekdayPrice = 179.05m, // Decimal (2 decimal places)
                WeekendPrice = 244.93m, // Decimal (2 decimal places)
                CleaningFee = 21.78m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3024,
                Zip = 50853, // Int32
                State = "MT",
                Street = "02489 Cook Park",
                City = "Sherriport",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "chung@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Cabin"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 4, // Int32
                Bathrooms = 3, // Int32
                GuestsAllowed = 6, // Int32
                WeekdayPrice = 207.24m, // Decimal (2 decimal places)
                WeekendPrice = 227.35m, // Decimal (2 decimal places)
                CleaningFee = 5.50m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3025,
                Zip = 20341, // Int32
                State = "UT",
                Street = "23450 Timothy Divide",
                City = "Wuland",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "jacobs@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "House"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 3, // Int32
                Bathrooms = 4, // Int32
                GuestsAllowed = 11, // Int32
                WeekdayPrice = 116.01m, // Decimal (2 decimal places)
                WeekendPrice = 278.36m, // Decimal (2 decimal places)
                CleaningFee = 24.73m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3026,
                Zip = 85565, // Int32
                State = "OH",
                Street = "0976 Williams Mountains Apt. 009",
                City = "Lake Mario",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "chung@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Apartment"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 6, // Int32
                Bathrooms = 7, // Int32
                GuestsAllowed = 7, // Int32
                WeekdayPrice = 225.14m, // Decimal (2 decimal places)
                WeekendPrice = 293.42m, // Decimal (2 decimal places)
                CleaningFee = 10.42m, // Decimal (2 decimal places)
                DiscountMinStay = 28,
                DiscountRate = 0.06m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3027,
                Zip = 51884, // Int32
                State = "WY",
                Street = "1097 Santos Springs Suite 264",
                City = "New Michelleborough",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "loter@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Hotel"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 2, // Int32
                Bathrooms = 2, // Int32
                GuestsAllowed = 4, // Int32
                WeekdayPrice = 70.24m, // Decimal (2 decimal places)
                WeekendPrice = 126.45m, // Decimal (2 decimal places)
                CleaningFee = 18.69m, // Decimal (2 decimal places)
                DiscountMinStay = 3,
                DiscountRate = 0.08m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3028,
                Zip = 66353, // Int32
                State = "SC",
                Street = "5100 Scott Burg",
                City = "East Clayton",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "morales@aol.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Cabin"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 4, // Int32
                Bathrooms = 3, // Int32
                GuestsAllowed = 3, // Int32
                WeekdayPrice = 186.38m, // Decimal (2 decimal places)
                WeekendPrice = 224.07m, // Decimal (2 decimal places)
                CleaningFee = 28.24m, // Decimal (2 decimal places)
                DiscountMinStay = 20,
                DiscountRate = 0.06m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3029,
                Zip = 57004, // Int32
                State = "NV",
                Street = "412 Snow Manors Apt. 161",
                City = "South Kimtown",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "morales@aol.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Apartment"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 5, // Int32
                Bathrooms = 7, // Int32
                GuestsAllowed = 9, // Int32
                WeekdayPrice = 112.47m, // Decimal (2 decimal places)
                WeekendPrice = 120.93m, // Decimal (2 decimal places)
                CleaningFee = 23.28m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3030,
                Zip = 48447, // Int32
                State = "IN",
                Street = "5415 David Square",
                City = "West Michaeltown",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "gonzalez@aol.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "House"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 7, // Int32
                Bathrooms = 9, // Int32
                GuestsAllowed = 1, // Int32
                WeekdayPrice = 214.81m, // Decimal (2 decimal places)
                WeekendPrice = 100.02m, // Decimal (2 decimal places)
                CleaningFee = 17.78m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3031,
                Zip = 62982, // Int32
                State = "DE",
                Street = "03104 Norris Rapids",
                City = "Port Donald",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "loter@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "House"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 1, // Int32
                Bathrooms = 2, // Int32
                GuestsAllowed = 11, // Int32
                WeekdayPrice = 159.87m, // Decimal (2 decimal places)
                WeekendPrice = 161.60m, // Decimal (2 decimal places)
                CleaningFee = 10.34m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3032,
                Zip = 16915, // Int32
                State = "FL",
                Street = "03557 Phillips Wells Suite 291",
                City = "New Beverlyburgh",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "loter@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Condo"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 7, // Int32
                Bathrooms = 6, // Int32
                GuestsAllowed = 4, // Int32
                WeekdayPrice = 70.55m, // Decimal (2 decimal places)
                WeekendPrice = 203.60m, // Decimal (2 decimal places)
                CleaningFee = 5.09m, // Decimal (2 decimal places)
                DiscountMinStay = 30,
                DiscountRate = 0.23m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3033,
                Zip = 39742, // Int32
                State = "MT",
                Street = "332 Watson Shore Apt. 290",
                City = "Millerland",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "rice@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Apartment"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 3, // Int32
                Bathrooms = 3, // Int32
                GuestsAllowed = 2, // Int32
                WeekdayPrice = 176.37m, // Decimal (2 decimal places)
                WeekendPrice = 299.34m, // Decimal (2 decimal places)
                CleaningFee = 17.38m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3034,
                Zip = 54060, // Int32
                State = "MS",
                Street = "645 John Roads",
                City = "Danahaven",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "morales@aol.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "House"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 7, // Int32
                Bathrooms = 6, // Int32
                GuestsAllowed = 14, // Int32
                WeekdayPrice = 172.83m, // Decimal (2 decimal places)
                WeekendPrice = 229.98m, // Decimal (2 decimal places)
                CleaningFee = 23.55m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3035,
                Zip = 55774, // Int32
                State = "HI",
                Street = "3547 Stephanie Underpass Apt. 418",
                City = "Port Jacqueline",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "tanner@utexas.edu"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Apartment"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 1, // Int32
                Bathrooms = 1, // Int32
                GuestsAllowed = 5, // Int32
                WeekdayPrice = 177.08m, // Decimal (2 decimal places)
                WeekendPrice = 143.71m, // Decimal (2 decimal places)
                CleaningFee = 19.21m, // Decimal (2 decimal places)
                DiscountMinStay = 42,
                DiscountRate = 0.13m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3036,
                Zip = 59363, // Int32
                State = "UT",
                Street = "5825 Welch Corners",
                City = "Fischerport",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "jacobs@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "House"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 3, // Int32
                Bathrooms = 4, // Int32
                GuestsAllowed = 10, // Int32
                WeekdayPrice = 76.66m, // Decimal (2 decimal places)
                WeekendPrice = 113.86m, // Decimal (2 decimal places)
                CleaningFee = 27.87m, // Decimal (2 decimal places)
                DiscountMinStay = 7,
                DiscountRate = 0.11m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3037,
                Zip = 71770, // Int32
                State = "IN",
                Street = "41489 Roger Terrace",
                City = "Davisfort",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "jacobs@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Cabin"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 6, // Int32
                Bathrooms = 8, // Int32
                GuestsAllowed = 6, // Int32
                WeekdayPrice = 177.37m, // Decimal (2 decimal places)
                WeekendPrice = 299.09m, // Decimal (2 decimal places)
                CleaningFee = 23.78m, // Decimal (2 decimal places)
                DiscountMinStay = 19,
                DiscountRate = 0.09m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3038,
                Zip = 5147, // Int32
                State = "CO",
                Street = "014 Aaron Locks Suite 714",
                City = "Justinborough",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "rankin@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Condo"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 2, // Int32
                Bathrooms = 2, // Int32
                GuestsAllowed = 5, // Int32
                WeekdayPrice = 104.05m, // Decimal (2 decimal places)
                WeekendPrice = 158.42m, // Decimal (2 decimal places)
                CleaningFee = 5.36m, // Decimal (2 decimal places)
                DiscountMinStay = 30,
                DiscountRate = 0.23m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3039,
                Zip = 28062, // Int32
                State = "SC",
                Street = "8518 Pamela Track Apt. 164",
                City = "Aprilshire",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "chung@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Apartment"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 3, // Int32
                Bathrooms = 2, // Int32
                GuestsAllowed = 1, // Int32
                WeekdayPrice = 199.37m, // Decimal (2 decimal places)
                WeekendPrice = 210.59m, // Decimal (2 decimal places)
                CleaningFee = 8.83m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3040,
                Zip = 88090, // Int32
                State = "OH",
                Street = "864 Ramos Port Apt. 211",
                City = "Moralesmouth",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "tanner@utexas.edu"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Apartment"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 3, // Int32
                Bathrooms = 5, // Int32
                GuestsAllowed = 9, // Int32
                WeekdayPrice = 94.48m, // Decimal (2 decimal places)
                WeekendPrice = 153.69m, // Decimal (2 decimal places)
                CleaningFee = 16.85m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3041,
                Zip = 28775, // Int32
                State = "RI",
                Street = "637 Neal Island Suite 074",
                City = "Lake Tyler",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "ingram@gmail.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Condo"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 3, // Int32
                Bathrooms = 3, // Int32
                GuestsAllowed = 14, // Int32
                WeekdayPrice = 88.82m, // Decimal (2 decimal places)
                WeekendPrice = 196.14m, // Decimal (2 decimal places)
                CleaningFee = 6.97m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3042,
                Zip = 75585, // Int32
                State = "WV",
                Street = "0811 Smith Canyon Apt. 904",
                City = "Jessicabury",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "rankin@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Apartment"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 3, // Int32
                Bathrooms = 5, // Int32
                GuestsAllowed = 2, // Int32
                WeekdayPrice = 119.58m, // Decimal (2 decimal places)
                WeekendPrice = 123.22m, // Decimal (2 decimal places)
                CleaningFee = 18.45m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3043,
                Zip = 17438, // Int32
                State = "MD",
                Street = "7562 Fisher Spur",
                City = "Hernandezberg",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "rice@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Cabin"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 1, // Int32
                Bathrooms = 2, // Int32
                GuestsAllowed = 2, // Int32
                WeekdayPrice = 218.87m, // Decimal (2 decimal places)
                WeekendPrice = 283.77m, // Decimal (2 decimal places)
                CleaningFee = 19.07m, // Decimal (2 decimal places)
                DiscountMinStay = 4,
                DiscountRate = 0.09m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3044,
                Zip = 7027, // Int32
                State = "VT",
                Street = "5667 Blair Underpass",
                City = "South Shelby",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "morales@aol.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Cabin"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 2, // Int32
                Bathrooms = 4, // Int32
                GuestsAllowed = 13, // Int32
                WeekdayPrice = 76.19m, // Decimal (2 decimal places)
                WeekendPrice = 239.76m, // Decimal (2 decimal places)
                CleaningFee = 11.37m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3045,
                Zip = 1008, // Int32
                State = "MI",
                Street = "6708 Carpenter Overpass Suite 735",
                City = "Bobbyton",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "rice@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Hotel"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 7, // Int32
                Bathrooms = 7, // Int32
                GuestsAllowed = 7, // Int32
                WeekdayPrice = 161.17m, // Decimal (2 decimal places)
                WeekendPrice = 229.04m, // Decimal (2 decimal places)
                CleaningFee = 25.01m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3046,
                Zip = 60236, // Int32
                State = "ND",
                Street = "16396 Shawn Junction",
                City = "New Nicolemouth",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "rice@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Cabin"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 4, // Int32
                Bathrooms = 4, // Int32
                GuestsAllowed = 6, // Int32
                WeekdayPrice = 106.06m, // Decimal (2 decimal places)
                WeekendPrice = 220.69m, // Decimal (2 decimal places)
                CleaningFee = 11.82m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3047,
                Zip = 1707, // Int32
                State = "CA",
                Street = "4486 Olson Well",
                City = "North Kevin",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "martinez@aol.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Cabin"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 7, // Int32
                Bathrooms = 7, // Int32
                GuestsAllowed = 10, // Int32
                WeekdayPrice = 151.44m, // Decimal (2 decimal places)
                WeekendPrice = 138.96m, // Decimal (2 decimal places)
                CleaningFee = 6.72m, // Decimal (2 decimal places)
                DiscountMinStay = 2,
                DiscountRate = 0.18m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3048,
                Zip = 33233, // Int32
                State = "HI",
                Street = "67771 Christopher Courts Apt. 637",
                City = "Port Ronaldfurt",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "ingram@gmail.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Apartment"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 5, // Int32
                Bathrooms = 5, // Int32
                GuestsAllowed = 2, // Int32
                WeekdayPrice = 102.43m, // Decimal (2 decimal places)
                WeekendPrice = 134.28m, // Decimal (2 decimal places)
                CleaningFee = 19.81m, // Decimal (2 decimal places)
                DiscountMinStay = 1,
                DiscountRate = 0.15m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3049,
                Zip = 79756, // Int32
                State = "NY",
                Street = "5561 Bishop Turnpike",
                City = "Lake Kenneth",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "gonzalez@aol.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Cabin"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 5, // Int32
                Bathrooms = 7, // Int32
                GuestsAllowed = 11, // Int32
                WeekdayPrice = 94.31m, // Decimal (2 decimal places)
                WeekendPrice = 259.87m, // Decimal (2 decimal places)
                CleaningFee = 22.33m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3050,
                Zip = 36216, // Int32
                State = "SD",
                Street = "3019 Gerald Mall Apt. 340",
                City = "Trevinoville",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "chung@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Apartment"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 5, // Int32
                Bathrooms = 5, // Int32
                GuestsAllowed = 1, // Int32
                WeekdayPrice = 151.69m, // Decimal (2 decimal places)
                WeekendPrice = 263.32m, // Decimal (2 decimal places)
                CleaningFee = 13.27m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3051,
                Zip = 43477, // Int32
                State = "NY",
                Street = "84331 Leonard Fort Suite 749",
                City = "East Lisa",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "chung@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Condo"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 7, // Int32
                Bathrooms = 8, // Int32
                GuestsAllowed = 10, // Int32
                WeekdayPrice = 204.04m, // Decimal (2 decimal places)
                WeekendPrice = 204.28m, // Decimal (2 decimal places)
                CleaningFee = 11.07m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3052,
                Zip = 17819, // Int32
                State = "VA",
                Street = "62281 Kathy Tunnel",
                City = "Hudsonborough",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "ingram@gmail.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Cabin"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 1, // Int32
                Bathrooms = 1, // Int32
                GuestsAllowed = 9, // Int32
                WeekdayPrice = 165.51m, // Decimal (2 decimal places)
                WeekendPrice = 224.19m, // Decimal (2 decimal places)
                CleaningFee = 24.26m, // Decimal (2 decimal places)
                DiscountMinStay = 5,
                DiscountRate = 0.12m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3053,
                Zip = 97149, // Int32
                State = "NM",
                Street = "9927 Christina Burg Suite 774",
                City = "East Angelaburgh",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "jacobs@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Condo"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 7, // Int32
                Bathrooms = 9, // Int32
                GuestsAllowed = 6, // Int32
                WeekdayPrice = 106.87m, // Decimal (2 decimal places)
                WeekendPrice = 121.74m, // Decimal (2 decimal places)
                CleaningFee = 5.62m, // Decimal (2 decimal places)
                DiscountMinStay = 5,
                DiscountRate = 0.06m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3054,
                Zip = 45480, // Int32
                State = "IA",
                Street = "142 Warner View Suite 460",
                City = "North Leslie",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "ingram@gmail.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Hotel"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 5, // Int32
                Bathrooms = 7, // Int32
                GuestsAllowed = 9, // Int32
                WeekdayPrice = 212.32m, // Decimal (2 decimal places)
                WeekendPrice = 148.76m, // Decimal (2 decimal places)
                CleaningFee = 20.20m, // Decimal (2 decimal places)
                DiscountMinStay = 41,
                DiscountRate = 0.12m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3055,
                Zip = 3720, // Int32
                State = "AR",
                Street = "5240 Berry Centers",
                City = "West Andrew",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "rankin@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "House"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 7, // Int32
                Bathrooms = 6, // Int32
                GuestsAllowed = 12, // Int32
                WeekdayPrice = 164.02m, // Decimal (2 decimal places)
                WeekendPrice = 111.01m, // Decimal (2 decimal places)
                CleaningFee = 26.21m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3056,
                Zip = 85576, // Int32
                State = "HI",
                Street = "51056 Patricia Forge",
                City = "Grahamstad",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "loter@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Cabin"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 7, // Int32
                Bathrooms = 9, // Int32
                GuestsAllowed = 10, // Int32
                WeekdayPrice = 117.45m, // Decimal (2 decimal places)
                WeekendPrice = 167.53m, // Decimal (2 decimal places)
                CleaningFee = 24.75m, // Decimal (2 decimal places)
                DiscountMinStay = 8,
                DiscountRate = 0.17m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3057,
                Zip = 92199, // Int32
                State = "VA",
                Street = "0648 Malone Port Apt. 662",
                City = "New Devonhaven",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "gonzalez@aol.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Apartment"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 6, // Int32
                Bathrooms = 5, // Int32
                GuestsAllowed = 12, // Int32
                WeekdayPrice = 209.47m, // Decimal (2 decimal places)
                WeekendPrice = 176.53m, // Decimal (2 decimal places)
                CleaningFee = 5.83m, // Decimal (2 decimal places)
                DiscountMinStay = 3,
                DiscountRate = 0.05m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3058,
                Zip = 5261, // Int32
                State = "SC",
                Street = "23028 Jennifer Meadow Apt. 972",
                City = "West Matthewfurt",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "ingram@gmail.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Apartment"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 1, // Int32
                Bathrooms = 2, // Int32
                GuestsAllowed = 14, // Int32
                WeekdayPrice = 153.04m, // Decimal (2 decimal places)
                WeekendPrice = 199.10m, // Decimal (2 decimal places)
                CleaningFee = 18.62m, // Decimal (2 decimal places)
                DiscountMinStay = 19,
                DiscountRate = 0.13m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3059,
                Zip = 72649, // Int32
                State = "LA",
                Street = "2738 Martin Terrace Suite 547",
                City = "Smithhaven",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "tanner@utexas.edu"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Condo"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 1, // Int32
                Bathrooms = 1, // Int32
                GuestsAllowed = 11, // Int32
                WeekdayPrice = 196.56m, // Decimal (2 decimal places)
                WeekendPrice = 199.22m, // Decimal (2 decimal places)
                CleaningFee = 20.71m, // Decimal (2 decimal places)
                DiscountMinStay = 4,
                DiscountRate = 0.14m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3060,
                Zip = 97488, // Int32
                State = "KY",
                Street = "984 Stephen Stravenue",
                City = "South Michaelton",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "ingram@gmail.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Cabin"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 4, // Int32
                Bathrooms = 6, // Int32
                GuestsAllowed = 3, // Int32
                WeekdayPrice = 117.03m, // Decimal (2 decimal places)
                WeekendPrice = 178.29m, // Decimal (2 decimal places)
                CleaningFee = 6.47m, // Decimal (2 decimal places)
                DiscountMinStay = 4,
                DiscountRate = 0.05m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3061,
                Zip = 42837, // Int32
                State = "LA",
                Street = "98522 Mathis Viaduct Apt. 909",
                City = "West Michael",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "jacobs@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Apartment"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 4, // Int32
                Bathrooms = 4, // Int32
                GuestsAllowed = 1, // Int32
                WeekdayPrice = 133.35m, // Decimal (2 decimal places)
                WeekendPrice = 252.79m, // Decimal (2 decimal places)
                CleaningFee = 9.15m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3062,
                Zip = 56059, // Int32
                State = "OH",
                Street = "620 Ashley Mills Apt. 507",
                City = "Julieborough",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "jacobs@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Apartment"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 1, // Int32
                Bathrooms = 3, // Int32
                GuestsAllowed = 9, // Int32
                WeekdayPrice = 171.15m, // Decimal (2 decimal places)
                WeekendPrice = 296.05m, // Decimal (2 decimal places)
                CleaningFee = 18.26m, // Decimal (2 decimal places)
                DiscountMinStay = 4,
                DiscountRate = 0.21m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3063,
                Zip = 2288, // Int32
                State = "LA",
                Street = "212 Shelly Roads",
                City = "Fischerview",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "chung@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Cabin"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 5, // Int32
                Bathrooms = 7, // Int32
                GuestsAllowed = 10, // Int32
                WeekdayPrice = 132.81m, // Decimal (2 decimal places)
                WeekendPrice = 163.88m, // Decimal (2 decimal places)
                CleaningFee = 7.46m, // Decimal (2 decimal places)
                DiscountMinStay = 6,
                DiscountRate = 0.17m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3064,
                Zip = 50851, // Int32
                State = "OK",
                Street = "8885 Lee Tunnel Suite 208",
                City = "Port Donna",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "chung@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Hotel"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 7, // Int32
                Bathrooms = 7, // Int32
                GuestsAllowed = 7, // Int32
                WeekdayPrice = 228.84m, // Decimal (2 decimal places)
                WeekendPrice = 140.73m, // Decimal (2 decimal places)
                CleaningFee = 17.13m, // Decimal (2 decimal places)
                DiscountMinStay = 22,
                DiscountRate = 0.23m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3065,
                Zip = 3009, // Int32
                State = "NM",
                Street = "693 Michael Estate",
                City = "Lake Michael",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "tanner@utexas.edu"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "House"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 4, // Int32
                Bathrooms = 5, // Int32
                GuestsAllowed = 13, // Int32
                WeekdayPrice = 155.03m, // Decimal (2 decimal places)
                WeekendPrice = 139.83m, // Decimal (2 decimal places)
                CleaningFee = 21.05m, // Decimal (2 decimal places)
                DiscountMinStay = 21,
                DiscountRate = 0.09m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3066,
                Zip = 92905, // Int32
                State = "NY",
                Street = "342 Miller Mission",
                City = "Lake Jennifer",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "martinez@aol.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "House"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 4, // Int32
                Bathrooms = 5, // Int32
                GuestsAllowed = 1, // Int32
                WeekdayPrice = 128.41m, // Decimal (2 decimal places)
                WeekendPrice = 249.24m, // Decimal (2 decimal places)
                CleaningFee = 6.63m, // Decimal (2 decimal places)
                DiscountMinStay = 8,
                DiscountRate = 0.07m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3067,
                Zip = 65056, // Int32
                State = "AK",
                Street = "71664 Kim Throughway",
                City = "Chelsealand",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "rankin@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "House"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 6, // Int32
                Bathrooms = 8, // Int32
                GuestsAllowed = 9, // Int32
                WeekdayPrice = 163.68m, // Decimal (2 decimal places)
                WeekendPrice = 286.53m, // Decimal (2 decimal places)
                CleaningFee = 25.57m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3068,
                Zip = 11181, // Int32
                State = "AZ",
                Street = "66660 Gomez Port Apt. 945",
                City = "South Thomashaven",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "tanner@utexas.edu"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Apartment"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 4, // Int32
                Bathrooms = 3, // Int32
                GuestsAllowed = 2, // Int32
                WeekdayPrice = 93.86m, // Decimal (2 decimal places)
                WeekendPrice = 137.17m, // Decimal (2 decimal places)
                CleaningFee = 28.18m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3069,
                Zip = 53480, // Int32
                State = "FL",
                Street = "0131 Williams Ville Apt. 562",
                City = "Richardberg",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "loter@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Apartment"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 6, // Int32
                Bathrooms = 5, // Int32
                GuestsAllowed = 13, // Int32
                WeekdayPrice = 86.25m, // Decimal (2 decimal places)
                WeekendPrice = 120.61m, // Decimal (2 decimal places)
                CleaningFee = 11.39m, // Decimal (2 decimal places)
                DiscountMinStay = 10,
                DiscountRate = 0.17m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3070,
                Zip = 11353, // Int32
                State = "OR",
                Street = "22708 Madison Spurs",
                City = "Herringstad",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "morales@aol.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Cabin"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 6, // Int32
                Bathrooms = 7, // Int32
                GuestsAllowed = 2, // Int32
                WeekdayPrice = 182.46m, // Decimal (2 decimal places)
                WeekendPrice = 241.25m, // Decimal (2 decimal places)
                CleaningFee = 18.29m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3071,
                Zip = 5560, // Int32
                State = "FL",
                Street = "3454 Holmes Motorway",
                City = "Port Rachel",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "chung@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Cabin"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 3, // Int32
                Bathrooms = 3, // Int32
                GuestsAllowed = 1, // Int32
                WeekdayPrice = 89.88m, // Decimal (2 decimal places)
                WeekendPrice = 123.04m, // Decimal (2 decimal places)
                CleaningFee = 19.14m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3072,
                Zip = 93500, // Int32
                State = "GA",
                Street = "805 James Turnpike",
                City = "Carrmouth",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "martinez@aol.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "House"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 6, // Int32
                Bathrooms = 5, // Int32
                GuestsAllowed = 12, // Int32
                WeekdayPrice = 81.55m, // Decimal (2 decimal places)
                WeekendPrice = 219.86m, // Decimal (2 decimal places)
                CleaningFee = 13.38m, // Decimal (2 decimal places)
                DiscountMinStay = 2,
                DiscountRate = 0.22m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3073,
                Zip = 44515, // Int32
                State = "NV",
                Street = "8081 Smith Trail",
                City = "North Ronaldstad",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "jacobs@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "House"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 7, // Int32
                Bathrooms = 7, // Int32
                GuestsAllowed = 3, // Int32
                WeekdayPrice = 130.47m, // Decimal (2 decimal places)
                WeekendPrice = 196.09m, // Decimal (2 decimal places)
                CleaningFee = 14.53m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3074,
                Zip = 7347, // Int32
                State = "MS",
                Street = "125 Ian Crossroad Apt. 593",
                City = "South Deannaport",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "morales@aol.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Apartment"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 2, // Int32
                Bathrooms = 1, // Int32
                GuestsAllowed = 4, // Int32
                WeekdayPrice = 148.10m, // Decimal (2 decimal places)
                WeekendPrice = 136.82m, // Decimal (2 decimal places)
                CleaningFee = 15.57m, // Decimal (2 decimal places)
                DiscountMinStay = 22,
                DiscountRate = 0.22m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3075,
                Zip = 54532, // Int32
                State = "NH",
                Street = "1607 Munoz River",
                City = "Emilyshire",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "chung@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Cabin"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 6, // Int32
                Bathrooms = 7, // Int32
                GuestsAllowed = 3, // Int32
                WeekdayPrice = 147.55m, // Decimal (2 decimal places)
                WeekendPrice = 209.77m, // Decimal (2 decimal places)
                CleaningFee = 27.65m, // Decimal (2 decimal places)
                DiscountMinStay = 6,
                DiscountRate = 0.09m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3076,
                Zip = 65516, // Int32
                State = "UT",
                Street = "3615 David Keys Apt. 269",
                City = "West Stephenside",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "gonzalez@aol.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Apartment"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 2, // Int32
                Bathrooms = 4, // Int32
                GuestsAllowed = 3, // Int32
                WeekdayPrice = 86.80m, // Decimal (2 decimal places)
                WeekendPrice = 126.47m, // Decimal (2 decimal places)
                CleaningFee = 17.60m, // Decimal (2 decimal places)
                DiscountMinStay = 21,
                DiscountRate = 0.06m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3077,
                Zip = 20721, // Int32
                State = "AZ",
                Street = "640 Mary Common",
                City = "Michaelville",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "ingram@gmail.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "House"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 3, // Int32
                Bathrooms = 4, // Int32
                GuestsAllowed = 7, // Int32
                WeekdayPrice = 121.75m, // Decimal (2 decimal places)
                WeekendPrice = 173.01m, // Decimal (2 decimal places)
                CleaningFee = 12.53m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3078,
                Zip = 43567, // Int32
                State = "LA",
                Street = "395 Timothy Road",
                City = "Williamsbury",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "loter@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Cabin"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 5, // Int32
                Bathrooms = 7, // Int32
                GuestsAllowed = 5, // Int32
                WeekdayPrice = 160.23m, // Decimal (2 decimal places)
                WeekendPrice = 198.10m, // Decimal (2 decimal places)
                CleaningFee = 10.82m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3079,
                Zip = 1239, // Int32
                State = "OR",
                Street = "3267 Walter Dam",
                City = "Cunninghamtown",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "chung@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Cabin"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 1, // Int32
                Bathrooms = 2, // Int32
                GuestsAllowed = 7, // Int32
                WeekdayPrice = 110.64m, // Decimal (2 decimal places)
                WeekendPrice = 127.70m, // Decimal (2 decimal places)
                CleaningFee = 26.67m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3080,
                Zip = 3966, // Int32
                State = "MS",
                Street = "00580 Brandon Creek",
                City = "Port Eric",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "jacobs@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Cabin"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 3, // Int32
                Bathrooms = 5, // Int32
                GuestsAllowed = 2, // Int32
                WeekdayPrice = 227.60m, // Decimal (2 decimal places)
                WeekendPrice = 236.71m, // Decimal (2 decimal places)
                CleaningFee = 20.22m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3081,
                Zip = 29996, // Int32
                State = "MS",
                Street = "325 Amanda Cliffs Apt. 695",
                City = "South Paulabury",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "ingram@gmail.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Apartment"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 6, // Int32
                Bathrooms = 6, // Int32
                GuestsAllowed = 13, // Int32
                WeekdayPrice = 115.37m, // Decimal (2 decimal places)
                WeekendPrice = 135.59m, // Decimal (2 decimal places)
                CleaningFee = 29.80m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3082,
                Zip = 93980, // Int32
                State = "CT",
                Street = "40956 Amanda Walk Apt. 260",
                City = "Simonfurt",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "chung@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Apartment"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 4, // Int32
                Bathrooms = 4, // Int32
                GuestsAllowed = 5, // Int32
                WeekdayPrice = 93.35m, // Decimal (2 decimal places)
                WeekendPrice = 271.49m, // Decimal (2 decimal places)
                CleaningFee = 8.54m, // Decimal (2 decimal places)
                DiscountMinStay = 6,
                DiscountRate = 0.18m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3083,
                Zip = 23687, // Int32
                State = "KS",
                Street = "25762 Gill Creek Suite 525",
                City = "Mccoyton",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "jacobs@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Condo"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 1, // Int32
                Bathrooms = 3, // Int32
                GuestsAllowed = 5, // Int32
                WeekdayPrice = 171.37m, // Decimal (2 decimal places)
                WeekendPrice = 247.15m, // Decimal (2 decimal places)
                CleaningFee = 17.22m, // Decimal (2 decimal places)
                DiscountMinStay = 8,
                DiscountRate = 0.21m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3084,
                Zip = 4593, // Int32
                State = "GA",
                Street = "6048 Johnson Loop Suite 635",
                City = "East Daniel",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "rankin@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Condo"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 1, // Int32
                Bathrooms = 3, // Int32
                GuestsAllowed = 8, // Int32
                WeekdayPrice = 95.59m, // Decimal (2 decimal places)
                WeekendPrice = 299.60m, // Decimal (2 decimal places)
                CleaningFee = 24.30m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3085,
                Zip = 96954, // Int32
                State = "RI",
                Street = "1168 Gary Fords Apt. 308",
                City = "Port Trevor",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "martinez@aol.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Apartment"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 1, // Int32
                Bathrooms = 2, // Int32
                GuestsAllowed = 11, // Int32
                WeekdayPrice = 194.84m, // Decimal (2 decimal places)
                WeekendPrice = 278.17m, // Decimal (2 decimal places)
                CleaningFee = 5.88m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3086,
                Zip = 62271, // Int32
                State = "MS",
                Street = "164 Matthew Parkway Suite 826",
                City = "Jimmyfurt",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "jacobs@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Condo"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 6, // Int32
                Bathrooms = 8, // Int32
                GuestsAllowed = 8, // Int32
                WeekdayPrice = 112.03m, // Decimal (2 decimal places)
                WeekendPrice = 100.08m, // Decimal (2 decimal places)
                CleaningFee = 28.82m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3087,
                Zip = 5222, // Int32
                State = "CO",
                Street = "1220 Heidi Rue Apt. 998",
                City = "West Haleyburgh",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "rice@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Apartment"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 5, // Int32
                Bathrooms = 4, // Int32
                GuestsAllowed = 1, // Int32
                WeekdayPrice = 127.97m, // Decimal (2 decimal places)
                WeekendPrice = 182.77m, // Decimal (2 decimal places)
                CleaningFee = 13.02m, // Decimal (2 decimal places)
                DiscountMinStay = 37,
                DiscountRate = 0.17m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3088,
                Zip = 22365, // Int32
                State = "SD",
                Street = "751 Wood Square Suite 732",
                City = "Port Melissaburgh",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "rice@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Hotel"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 7, // Int32
                Bathrooms = 7, // Int32
                GuestsAllowed = 13, // Int32
                WeekdayPrice = 120.07m, // Decimal (2 decimal places)
                WeekendPrice = 186.01m, // Decimal (2 decimal places)
                CleaningFee = 26.71m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3089,
                Zip = 53609, // Int32
                State = "OR",
                Street = "376 Smith Dale Suite 279",
                City = "South Sarahland",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "ingram@gmail.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Hotel"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 2, // Int32
                Bathrooms = 2, // Int32
                GuestsAllowed = 9, // Int32
                WeekdayPrice = 137.96m, // Decimal (2 decimal places)
                WeekendPrice = 122.31m, // Decimal (2 decimal places)
                CleaningFee = 26.29m, // Decimal (2 decimal places)
                DiscountMinStay = 29,
                DiscountRate = 0.10m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3090,
                Zip = 9478, // Int32
                State = "CA",
                Street = "79148 Pierce Lock Suite 423",
                City = "Erikberg",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "rice@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Hotel"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 3, // Int32
                Bathrooms = 5, // Int32
                GuestsAllowed = 6, // Int32
                WeekdayPrice = 226.57m, // Decimal (2 decimal places)
                WeekendPrice = 234.61m, // Decimal (2 decimal places)
                CleaningFee = 16.41m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3091,
                Zip = 1425, // Int32
                State = "ID",
                Street = "147 Lisa Hill Apt. 512",
                City = "Port Elizabethshire",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "gonzalez@aol.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Apartment"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 4, // Int32
                Bathrooms = 6, // Int32
                GuestsAllowed = 10, // Int32
                WeekdayPrice = 95.73m, // Decimal (2 decimal places)
                WeekendPrice = 145.15m, // Decimal (2 decimal places)
                CleaningFee = 9.93m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3092,
                Zip = 29941, // Int32
                State = "KY",
                Street = "971 Hansen Well Suite 103",
                City = "South Mary",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "morales@aol.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Hotel"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 6, // Int32
                Bathrooms = 8, // Int32
                GuestsAllowed = 4, // Int32
                WeekdayPrice = 161.68m, // Decimal (2 decimal places)
                WeekendPrice = 145.72m, // Decimal (2 decimal places)
                CleaningFee = 24.36m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3093,
                Zip = 47577, // Int32
                State = "WY",
                Street = "511 Berry Fork Suite 623",
                City = "Sharonfort",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "morales@aol.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Hotel"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 4, // Int32
                Bathrooms = 5, // Int32
                GuestsAllowed = 3, // Int32
                WeekdayPrice = 183.81m, // Decimal (2 decimal places)
                WeekendPrice = 260.18m, // Decimal (2 decimal places)
                CleaningFee = 7.46m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3094,
                Zip = 94134, // Int32
                State = "WI",
                Street = "65873 Chen Knolls",
                City = "Ramirezfurt",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "morales@aol.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "House"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 4, // Int32
                Bathrooms = 3, // Int32
                GuestsAllowed = 14, // Int32
                WeekdayPrice = 215.38m, // Decimal (2 decimal places)
                WeekendPrice = 117.17m, // Decimal (2 decimal places)
                CleaningFee = 24.31m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3095,
                Zip = 57039, // Int32
                State = "IN",
                Street = "8799 Emma Parkway Suite 735",
                City = "North Thomasfurt",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "rice@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Hotel"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 3, // Int32
                Bathrooms = 5, // Int32
                GuestsAllowed = 11, // Int32
                WeekdayPrice = 145.51m, // Decimal (2 decimal places)
                WeekendPrice = 242.21m, // Decimal (2 decimal places)
                CleaningFee = 11.89m, // Decimal (2 decimal places)
                DiscountMinStay = 41,
                DiscountRate = 0.10m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3096,
                Zip = 23718, // Int32
                State = "ND",
                Street = "30068 David View Apt. 173",
                City = "New Peggychester",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "martinez@aol.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Apartment"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 4, // Int32
                Bathrooms = 6, // Int32
                GuestsAllowed = 7, // Int32
                WeekdayPrice = 142.76m, // Decimal (2 decimal places)
                WeekendPrice = 161.21m, // Decimal (2 decimal places)
                CleaningFee = 20.92m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3097,
                Zip = 26932, // Int32
                State = "MD",
                Street = "298 Johnathan Cove Apt. 402",
                City = "South Jamie",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "ingram@gmail.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Apartment"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 6, // Int32
                Bathrooms = 7, // Int32
                GuestsAllowed = 13, // Int32
                WeekdayPrice = 170.07m, // Decimal (2 decimal places)
                WeekendPrice = 176.37m, // Decimal (2 decimal places)
                CleaningFee = 8.54m, // Decimal (2 decimal places)
                DiscountMinStay = 17,
                DiscountRate = 0.09m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3098,
                Zip = 74554, // Int32
                State = "CO",
                Street = "171 Harrison Motorway",
                City = "Davidview",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "chung@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "House"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 6, // Int32
                Bathrooms = 8, // Int32
                GuestsAllowed = 10, // Int32
                WeekdayPrice = 145.08m, // Decimal (2 decimal places)
                WeekendPrice = 234.81m, // Decimal (2 decimal places)
                CleaningFee = 26.14m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3099,
                Zip = 32097, // Int32
                State = "NE",
                Street = "3576 Sergio Avenue",
                City = "Benjaminmouth",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "morales@aol.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Cabin"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 1, // Int32
                Bathrooms = 1, // Int32
                GuestsAllowed = 1, // Int32
                WeekdayPrice = 111.73m, // Decimal (2 decimal places)
                WeekendPrice = 260.62m, // Decimal (2 decimal places)
                CleaningFee = 15.89m, // Decimal (2 decimal places)
                DiscountMinStay = 9,
                DiscountRate = 0.24m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { DateTime.Parse("2024-12-29 00:00:00"), DateTime.Parse("2024-12-30 00:00:00"), DateTime.Parse("2024-12-31 00:00:00"), DateTime.Parse("2025-01-01 00:00:00") } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3100,
                Zip = 21519, // Int32
                State = "RI",
                Street = "37457 Tanya Pike Apt. 348",
                City = "North Ericton",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "ingram@gmail.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Apartment"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 2, // Int32
                Bathrooms = 1, // Int32
                GuestsAllowed = 13, // Int32
                WeekdayPrice = 70.63m, // Decimal (2 decimal places)
                WeekendPrice = 214.62m, // Decimal (2 decimal places)
                CleaningFee = 5.29m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { DateTime.Parse("2024-12-31 00:00:00") } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3101,
                Zip = 76875, // Int32
                State = "PA",
                Street = "3673 Peter Turnpike Suite 835",
                City = "New Sandra",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "loter@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Hotel"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 4, // Int32
                Bathrooms = 4, // Int32
                GuestsAllowed = 6, // Int32
                WeekdayPrice = 229.03m, // Decimal (2 decimal places)
                WeekendPrice = 172.79m, // Decimal (2 decimal places)
                CleaningFee = 14.05m, // Decimal (2 decimal places)
                DiscountMinStay = 12,
                DiscountRate = 0.14m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3102,
                Zip = 80451, // Int32
                State = "TX",
                Street = "939 Johnson Oval Suite 830",
                City = "North Dennismouth",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "gonzalez@aol.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Hotel"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 3, // Int32
                Bathrooms = 5, // Int32
                GuestsAllowed = 6, // Int32
                WeekdayPrice = 169.34m, // Decimal (2 decimal places)
                WeekendPrice = 133.53m, // Decimal (2 decimal places)
                CleaningFee = 18.06m, // Decimal (2 decimal places)
                DiscountMinStay = 28,
                DiscountRate = 0.25m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3103,
                Zip = 51726, // Int32
                State = "NV",
                Street = "645 Jennings Estates",
                City = "Angelastad",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "tanner@utexas.edu"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "House"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 2, // Int32
                Bathrooms = 3, // Int32
                GuestsAllowed = 4, // Int32
                WeekdayPrice = 155.52m, // Decimal (2 decimal places)
                WeekendPrice = 109.44m, // Decimal (2 decimal places)
                CleaningFee = 8.28m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3104,
                Zip = 77240, // Int32
                State = "MT",
                Street = "1231 Stephanie Lock Suite 835",
                City = "North Richardland",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "martinez@aol.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Hotel"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 5, // Int32
                Bathrooms = 7, // Int32
                GuestsAllowed = 5, // Int32
                WeekdayPrice = 180.20m, // Decimal (2 decimal places)
                WeekendPrice = 182.33m, // Decimal (2 decimal places)
                CleaningFee = 17.78m, // Decimal (2 decimal places)
                DiscountMinStay = 13,
                DiscountRate = 0.13m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3105,
                Zip = 98152, // Int32
                State = "CO",
                Street = "302 Parker Plains Apt. 197",
                City = "East Robertstad",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "morales@aol.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Apartment"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 3, // Int32
                Bathrooms = 2, // Int32
                GuestsAllowed = 1, // Int32
                WeekdayPrice = 212.86m, // Decimal (2 decimal places)
                WeekendPrice = 212.70m, // Decimal (2 decimal places)
                CleaningFee = 6.82m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3106,
                Zip = 98277, // Int32
                State = "MS",
                Street = "098 Hernandez Green",
                City = "New Sergiobury",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "morales@aol.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Cabin"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 4, // Int32
                Bathrooms = 6, // Int32
                GuestsAllowed = 8, // Int32
                WeekdayPrice = 188.71m, // Decimal (2 decimal places)
                WeekendPrice = 262.30m, // Decimal (2 decimal places)
                CleaningFee = 21.88m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3107,
                Zip = 80082, // Int32
                State = "NE",
                Street = "94102 Sims Port Suite 187",
                City = "Florestown",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "rice@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Condo"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 4, // Int32
                Bathrooms = 4, // Int32
                GuestsAllowed = 8, // Int32
                WeekdayPrice = 83.34m, // Decimal (2 decimal places)
                WeekendPrice = 128.05m, // Decimal (2 decimal places)
                CleaningFee = 11.29m, // Decimal (2 decimal places)
                DiscountMinStay = 8,
                DiscountRate = 0.21m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3108,
                Zip = 71531, // Int32
                State = "ND",
                Street = "01630 Baker Crescent",
                City = "Kellyborough",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "gonzalez@aol.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Cabin"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 1, // Int32
                Bathrooms = 1, // Int32
                GuestsAllowed = 4, // Int32
                WeekdayPrice = 204.02m, // Decimal (2 decimal places)
                WeekendPrice = 125.27m, // Decimal (2 decimal places)
                CleaningFee = 21.15m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3109,
                Zip = 14157, // Int32
                State = "OK",
                Street = "70452 Forbes Courts",
                City = "Mosesland",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "morales@aol.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Cabin"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 4, // Int32
                Bathrooms = 3, // Int32
                GuestsAllowed = 9, // Int32
                WeekdayPrice = 90.98m, // Decimal (2 decimal places)
                WeekendPrice = 172.10m, // Decimal (2 decimal places)
                CleaningFee = 18.09m, // Decimal (2 decimal places)
                DiscountMinStay = 11,
                DiscountRate = 0.22m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3110,
                Zip = 26899, // Int32
                State = "MO",
                Street = "0835 Angela Station",
                City = "East Heather",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "tanner@utexas.edu"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "House"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 5, // Int32
                Bathrooms = 7, // Int32
                GuestsAllowed = 9, // Int32
                WeekdayPrice = 158.64m, // Decimal (2 decimal places)
                WeekendPrice = 299.91m, // Decimal (2 decimal places)
                CleaningFee = 23.09m, // Decimal (2 decimal places)
                DiscountMinStay = 22,
                DiscountRate = 0.12m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3111,
                Zip = 42872, // Int32
                State = "VT",
                Street = "2458 Jason Village Suite 248",
                City = "North Donnamouth",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "tanner@utexas.edu"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Condo"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 2, // Int32
                Bathrooms = 4, // Int32
                GuestsAllowed = 4, // Int32
                WeekdayPrice = 107.97m, // Decimal (2 decimal places)
                WeekendPrice = 189.30m, // Decimal (2 decimal places)
                CleaningFee = 9.05m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3112,
                Zip = 78301, // Int32
                State = "CO",
                Street = "1243 Grimes Corners",
                City = "Shawchester",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "martinez@aol.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "House"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 4, // Int32
                Bathrooms = 3, // Int32
                GuestsAllowed = 2, // Int32
                WeekdayPrice = 214.14m, // Decimal (2 decimal places)
                WeekendPrice = 193.24m, // Decimal (2 decimal places)
                CleaningFee = 26.10m, // Decimal (2 decimal places)
                DiscountMinStay = 21,
                DiscountRate = 0.06m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3113,
                Zip = 34523, // Int32
                State = "DC",
                Street = "558 Williams Station",
                City = "Port Pamela",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "rankin@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "House"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 6, // Int32
                Bathrooms = 7, // Int32
                GuestsAllowed = 4, // Int32
                WeekdayPrice = 106.30m, // Decimal (2 decimal places)
                WeekendPrice = 192.46m, // Decimal (2 decimal places)
                CleaningFee = 17.59m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { DateTime.Parse("2024-12-05 00:00:00"), DateTime.Parse("2024-12-06 00:00:00"), DateTime.Parse("2024-12-07 00:00:00") } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3114,
                Zip = 63064, // Int32
                State = "VT",
                Street = "4934 Lozano Place Suite 716",
                City = "Gavinton",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "chung@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Hotel"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 5, // Int32
                Bathrooms = 6, // Int32
                GuestsAllowed = 6, // Int32
                WeekdayPrice = 116.99m, // Decimal (2 decimal places)
                WeekendPrice = 257.37m, // Decimal (2 decimal places)
                CleaningFee = 5.63m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3115,
                Zip = 35700, // Int32
                State = "LA",
                Street = "41227 Patricia Lake",
                City = "Martinezbury",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "gonzalez@aol.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "House"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 2, // Int32
                Bathrooms = 1, // Int32
                GuestsAllowed = 3, // Int32
                WeekdayPrice = 203.03m, // Decimal (2 decimal places)
                WeekendPrice = 108.28m, // Decimal (2 decimal places)
                CleaningFee = 11.35m, // Decimal (2 decimal places)
                DiscountMinStay = 4,
                DiscountRate = 0.10m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3116,
                Zip = 55206, // Int32
                State = "VA",
                Street = "028 Harris Drive Apt. 422",
                City = "Amyburgh",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "martinez@aol.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Apartment"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 2, // Int32
                Bathrooms = 2, // Int32
                GuestsAllowed = 14, // Int32
                WeekdayPrice = 163.30m, // Decimal (2 decimal places)
                WeekendPrice = 262.77m, // Decimal (2 decimal places)
                CleaningFee = 13.74m, // Decimal (2 decimal places)
                DiscountMinStay = 12,
                DiscountRate = 0.16m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3117,
                Zip = 98240, // Int32
                State = "IA",
                Street = "06268 Lewis Place Suite 121",
                City = "Port Patriciatown",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "gonzalez@aol.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Hotel"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 3, // Int32
                Bathrooms = 2, // Int32
                GuestsAllowed = 4, // Int32
                WeekdayPrice = 156.25m, // Decimal (2 decimal places)
                WeekendPrice = 108.52m, // Decimal (2 decimal places)
                CleaningFee = 23.66m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3118,
                Zip = 87205, // Int32
                State = "WI",
                Street = "5641 Brenda Streets Apt. 008",
                City = "Lake Seanmouth",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "rankin@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Apartment"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 5, // Int32
                Bathrooms = 6, // Int32
                GuestsAllowed = 12, // Int32
                WeekdayPrice = 178.27m, // Decimal (2 decimal places)
                WeekendPrice = 153.42m, // Decimal (2 decimal places)
                CleaningFee = 24.69m, // Decimal (2 decimal places)
                DiscountMinStay = 23,
                DiscountRate = 0.06m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3119,
                Zip = 58221, // Int32
                State = "ME",
                Street = "92555 Shaw Spurs Suite 207",
                City = "New Randy",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "rice@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Hotel"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 7, // Int32
                Bathrooms = 8, // Int32
                GuestsAllowed = 13, // Int32
                WeekdayPrice = 92.51m, // Decimal (2 decimal places)
                WeekendPrice = 184.92m, // Decimal (2 decimal places)
                CleaningFee = 12.82m, // Decimal (2 decimal places)
                DiscountMinStay = 3,
                DiscountRate = 0.12m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3120,
                Zip = 18885, // Int32
                State = "NY",
                Street = "559 Foster Locks Suite 933",
                City = "Robinsonhaven",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "tanner@utexas.edu"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Condo"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 6, // Int32
                Bathrooms = 6, // Int32
                GuestsAllowed = 6, // Int32
                WeekdayPrice = 224.62m, // Decimal (2 decimal places)
                WeekendPrice = 225.85m, // Decimal (2 decimal places)
                CleaningFee = 17.90m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3121,
                Zip = 638, // Int32
                State = "WY",
                Street = "4647 Kristine Fields Suite 710",
                City = "New Dakota",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "morales@aol.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Condo"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 1, // Int32
                Bathrooms = 2, // Int32
                GuestsAllowed = 10, // Int32
                WeekdayPrice = 112.61m, // Decimal (2 decimal places)
                WeekendPrice = 174.02m, // Decimal (2 decimal places)
                CleaningFee = 17.48m, // Decimal (2 decimal places)
                DiscountMinStay = 5,
                DiscountRate = 0.08m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3122,
                Zip = 31451, // Int32
                State = "ME",
                Street = "92594 Emily Shoals",
                City = "North Cathyburgh",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "rankin@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "House"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 6, // Int32
                Bathrooms = 5, // Int32
                GuestsAllowed = 1, // Int32
                WeekdayPrice = 189.98m, // Decimal (2 decimal places)
                WeekendPrice = 119.06m, // Decimal (2 decimal places)
                CleaningFee = 25.11m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3123,
                Zip = 26297, // Int32
                State = "MS",
                Street = "551 Casey Squares Apt. 209",
                City = "Michaelborough",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "martinez@aol.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Apartment"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 1, // Int32
                Bathrooms = 1, // Int32
                GuestsAllowed = 6, // Int32
                WeekdayPrice = 72.03m, // Decimal (2 decimal places)
                WeekendPrice = 114.73m, // Decimal (2 decimal places)
                CleaningFee = 18.38m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3124,
                Zip = 4610, // Int32
                State = "PA",
                Street = "2998 Willis Wall",
                City = "North Brian",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "loter@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "House"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 3, // Int32
                Bathrooms = 4, // Int32
                GuestsAllowed = 3, // Int32
                WeekdayPrice = 216.21m, // Decimal (2 decimal places)
                WeekendPrice = 144.51m, // Decimal (2 decimal places)
                CleaningFee = 10.81m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3125,
                Zip = 86618, // Int32
                State = "MD",
                Street = "164 Schultz Road",
                City = "Lake Bryan",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "chung@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "House"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 5, // Int32
                Bathrooms = 7, // Int32
                GuestsAllowed = 13, // Int32
                WeekdayPrice = 132.69m, // Decimal (2 decimal places)
                WeekendPrice = 233.90m, // Decimal (2 decimal places)
                CleaningFee = 15.80m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3126,
                Zip = 80124, // Int32
                State = "GA",
                Street = "9541 Brock Estate Apt. 848",
                City = "Franklinchester",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "jacobs@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Apartment"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 2, // Int32
                Bathrooms = 1, // Int32
                GuestsAllowed = 9, // Int32
                WeekdayPrice = 220.97m, // Decimal (2 decimal places)
                WeekendPrice = 285.05m, // Decimal (2 decimal places)
                CleaningFee = 20.98m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3127,
                Zip = 63590, // Int32
                State = "MS",
                Street = "588 Alan Rest",
                City = "Port Stephanieville",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "ingram@gmail.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "House"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 6, // Int32
                Bathrooms = 6, // Int32
                GuestsAllowed = 12, // Int32
                WeekdayPrice = 224.98m, // Decimal (2 decimal places)
                WeekendPrice = 180.86m, // Decimal (2 decimal places)
                CleaningFee = 11.91m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3128,
                Zip = 53548, // Int32
                State = "MT",
                Street = "216 Brandon Loop Apt. 096",
                City = "New Jessica",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "rice@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Apartment"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 5, // Int32
                Bathrooms = 7, // Int32
                GuestsAllowed = 12, // Int32
                WeekdayPrice = 221.98m, // Decimal (2 decimal places)
                WeekendPrice = 239.97m, // Decimal (2 decimal places)
                CleaningFee = 9.24m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3129,
                Zip = 35611, // Int32
                State = "LA",
                Street = "782 Dawn Radial",
                City = "Port Christopher",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "ingram@gmail.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Cabin"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 1, // Int32
                Bathrooms = 3, // Int32
                GuestsAllowed = 1, // Int32
                WeekdayPrice = 76.56m, // Decimal (2 decimal places)
                WeekendPrice = 297.25m, // Decimal (2 decimal places)
                CleaningFee = 20.42m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3130,
                Zip = 42879, // Int32
                State = "WA",
                Street = "008 Nancy Route Suite 228",
                City = "North Stephanie",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "morales@aol.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Condo"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 2, // Int32
                Bathrooms = 3, // Int32
                GuestsAllowed = 3, // Int32
                WeekdayPrice = 128.71m, // Decimal (2 decimal places)
                WeekendPrice = 129.36m, // Decimal (2 decimal places)
                CleaningFee = 23.76m, // Decimal (2 decimal places)
                DiscountMinStay = 3,
                DiscountRate = 0.08m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3131,
                Zip = 71569, // Int32
                State = "MO",
                Street = "115 Jon Isle Suite 788",
                City = "North Lesliefurt",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "loter@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Hotel"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 1, // Int32
                Bathrooms = 2, // Int32
                GuestsAllowed = 9, // Int32
                WeekdayPrice = 114.21m, // Decimal (2 decimal places)
                WeekendPrice = 210.63m, // Decimal (2 decimal places)
                CleaningFee = 21.08m, // Decimal (2 decimal places)
                DiscountMinStay = 42,
                DiscountRate = 0.21m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3132,
                Zip = 87566, // Int32
                State = "DE",
                Street = "132 Poole Pass Suite 212",
                City = "North Patrick",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "tanner@utexas.edu"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Hotel"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 5, // Int32
                Bathrooms = 6, // Int32
                GuestsAllowed = 11, // Int32
                WeekdayPrice = 146.82m, // Decimal (2 decimal places)
                WeekendPrice = 280.37m, // Decimal (2 decimal places)
                CleaningFee = 26.78m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3133,
                Zip = 67652, // Int32
                State = "WY",
                Street = "457 Vargas Island Suite 853",
                City = "Lake Patrickstad",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "jacobs@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Hotel"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 4, // Int32
                Bathrooms = 3, // Int32
                GuestsAllowed = 1, // Int32
                WeekdayPrice = 134.72m, // Decimal (2 decimal places)
                WeekendPrice = 249.39m, // Decimal (2 decimal places)
                CleaningFee = 19.19m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3134,
                Zip = 45184, // Int32
                State = "HI",
                Street = "1569 Amy Path",
                City = "North Ashleyton",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "tanner@utexas.edu"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Cabin"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 7, // Int32
                Bathrooms = 8, // Int32
                GuestsAllowed = 7, // Int32
                WeekdayPrice = 111.60m, // Decimal (2 decimal places)
                WeekendPrice = 111.23m, // Decimal (2 decimal places)
                CleaningFee = 13.48m, // Decimal (2 decimal places)
                DiscountMinStay = 5,
                DiscountRate = 0.21m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3135,
                Zip = 4078, // Int32
                State = "IL",
                Street = "0375 Sandra Trace Suite 826",
                City = "Gailshire",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "tanner@utexas.edu"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Hotel"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 5, // Int32
                Bathrooms = 6, // Int32
                GuestsAllowed = 3, // Int32
                WeekdayPrice = 89.00m, // Decimal (2 decimal places)
                WeekendPrice = 168.47m, // Decimal (2 decimal places)
                CleaningFee = 14.93m, // Decimal (2 decimal places)
                DiscountMinStay = 36,
                DiscountRate = 0.21m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3136,
                Zip = 50437, // Int32
                State = "MN",
                Street = "759 Good Port",
                City = "New Russell",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "ingram@gmail.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "House"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 5, // Int32
                Bathrooms = 5, // Int32
                GuestsAllowed = 6, // Int32
                WeekdayPrice = 208.64m, // Decimal (2 decimal places)
                WeekendPrice = 208.35m, // Decimal (2 decimal places)
                CleaningFee = 7.09m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3137,
                Zip = 34147, // Int32
                State = "WV",
                Street = "3895 Allen Junction",
                City = "West John",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "chung@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Cabin"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 5, // Int32
                Bathrooms = 7, // Int32
                GuestsAllowed = 3, // Int32
                WeekdayPrice = 172.51m, // Decimal (2 decimal places)
                WeekendPrice = 195.41m, // Decimal (2 decimal places)
                CleaningFee = 21.53m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3138,
                Zip = 36340, // Int32
                State = "MS",
                Street = "7329 Jacobs Station",
                City = "New Tylerborough",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "jacobs@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "House"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 1, // Int32
                Bathrooms = 3, // Int32
                GuestsAllowed = 8, // Int32
                WeekdayPrice = 163.15m, // Decimal (2 decimal places)
                WeekendPrice = 146.12m, // Decimal (2 decimal places)
                CleaningFee = 18.98m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3139,
                Zip = 88806, // Int32
                State = "MD",
                Street = "5003 Cassandra Estates Suite 148",
                City = "Haleychester",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "tanner@utexas.edu"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Hotel"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 7, // Int32
                Bathrooms = 7, // Int32
                GuestsAllowed = 9, // Int32
                WeekdayPrice = 81.50m, // Decimal (2 decimal places)
                WeekendPrice = 161.49m, // Decimal (2 decimal places)
                CleaningFee = 16.41m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3140,
                Zip = 76853, // Int32
                State = "TN",
                Street = "10524 Parker Mall Suite 531",
                City = "Port Courtneyhaven",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "ingram@gmail.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Hotel"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 5, // Int32
                Bathrooms = 7, // Int32
                GuestsAllowed = 13, // Int32
                WeekdayPrice = 177.94m, // Decimal (2 decimal places)
                WeekendPrice = 120.73m, // Decimal (2 decimal places)
                CleaningFee = 9.50m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3141,
                Zip = 93533, // Int32
                State = "MO",
                Street = "300 Madison Stream",
                City = "Christophershire",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "loter@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Cabin"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 3, // Int32
                Bathrooms = 4, // Int32
                GuestsAllowed = 6, // Int32
                WeekdayPrice = 121.01m, // Decimal (2 decimal places)
                WeekendPrice = 187.08m, // Decimal (2 decimal places)
                CleaningFee = 16.48m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3142,
                Zip = 96763, // Int32
                State = "FL",
                Street = "4229 Derrick Wells",
                City = "West Tyler",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "martinez@aol.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "House"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 2, // Int32
                Bathrooms = 4, // Int32
                GuestsAllowed = 6, // Int32
                WeekdayPrice = 199.68m, // Decimal (2 decimal places)
                WeekendPrice = 241.45m, // Decimal (2 decimal places)
                CleaningFee = 25.94m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3143,
                Zip = 92174, // Int32
                State = "VA",
                Street = "26239 Michael Shoals",
                City = "Gregoryview",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "morales@aol.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Cabin"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 1, // Int32
                Bathrooms = 2, // Int32
                GuestsAllowed = 9, // Int32
                WeekdayPrice = 162.01m, // Decimal (2 decimal places)
                WeekendPrice = 111.91m, // Decimal (2 decimal places)
                CleaningFee = 14.35m, // Decimal (2 decimal places)
                DiscountMinStay = 29,
                DiscountRate = 0.10m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3144,
                Zip = 88294, // Int32
                State = "IN",
                Street = "302 Joy Spring Apt. 622",
                City = "Ryanhaven",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "ingram@gmail.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Apartment"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 1, // Int32
                Bathrooms = 3, // Int32
                GuestsAllowed = 12, // Int32
                WeekdayPrice = 173.36m, // Decimal (2 decimal places)
                WeekendPrice = 163.73m, // Decimal (2 decimal places)
                CleaningFee = 25.35m, // Decimal (2 decimal places)
                DiscountMinStay = 32,
                DiscountRate = 0.06m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3145,
                Zip = 23464, // Int32
                State = "CA",
                Street = "734 Craig Overpass Suite 589",
                City = "Jefferyside",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "martinez@aol.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Condo"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 1, // Int32
                Bathrooms = 3, // Int32
                GuestsAllowed = 8, // Int32
                WeekdayPrice = 216.10m, // Decimal (2 decimal places)
                WeekendPrice = 287.28m, // Decimal (2 decimal places)
                CleaningFee = 22.20m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3146,
                Zip = 35243, // Int32
                State = "CA",
                Street = "272 Green Street",
                City = "Port Lacey",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "martinez@aol.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "House"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 4, // Int32
                Bathrooms = 3, // Int32
                GuestsAllowed = 7, // Int32
                WeekdayPrice = 211.51m, // Decimal (2 decimal places)
                WeekendPrice = 247.34m, // Decimal (2 decimal places)
                CleaningFee = 11.73m, // Decimal (2 decimal places)
                DiscountMinStay = 6,
                DiscountRate = 0.13m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3147,
                Zip = 61935, // Int32
                State = "IL",
                Street = "8056 Dunn Trail Apt. 049",
                City = "Blackshire",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "loter@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Apartment"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 5, // Int32
                Bathrooms = 6, // Int32
                GuestsAllowed = 2, // Int32
                WeekdayPrice = 111.40m, // Decimal (2 decimal places)
                WeekendPrice = 189.08m, // Decimal (2 decimal places)
                CleaningFee = 19.58m, // Decimal (2 decimal places)
                DiscountMinStay = 9,
                DiscountRate = 0.07m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3148,
                Zip = 72324, // Int32
                State = "CA",
                Street = "86187 Antonio Fort",
                City = "North Carmen",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "tanner@utexas.edu"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "House"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 7, // Int32
                Bathrooms = 9, // Int32
                GuestsAllowed = 7, // Int32
                WeekdayPrice = 150.69m, // Decimal (2 decimal places)
                WeekendPrice = 109.87m, // Decimal (2 decimal places)
                CleaningFee = 13.30m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3149,
                Zip = 84393, // Int32
                State = "NJ",
                Street = "71318 Cassandra Plaza",
                City = "Burkeview",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "loter@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "House"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 7, // Int32
                Bathrooms = 7, // Int32
                GuestsAllowed = 10, // Int32
                WeekdayPrice = 184.21m, // Decimal (2 decimal places)
                WeekendPrice = 227.55m, // Decimal (2 decimal places)
                CleaningFee = 19.52m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3150,
                Zip = 62346, // Int32
                State = "NH",
                Street = "5303 Lewis Springs",
                City = "Port Adrian",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "tanner@utexas.edu"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "House"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 2, // Int32
                Bathrooms = 1, // Int32
                GuestsAllowed = 2, // Int32
                WeekdayPrice = 204.67m, // Decimal (2 decimal places)
                WeekendPrice = 207.51m, // Decimal (2 decimal places)
                CleaningFee = 26.36m, // Decimal (2 decimal places)
                DiscountMinStay = 44,
                DiscountRate = 0.22m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3151,
                Zip = 2837, // Int32
                State = "IA",
                Street = "465 Wiley Corners Apt. 759",
                City = "East Michellechester",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "gonzalez@aol.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Apartment"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 6, // Int32
                Bathrooms = 5, // Int32
                GuestsAllowed = 11, // Int32
                WeekdayPrice = 129.14m, // Decimal (2 decimal places)
                WeekendPrice = 213.84m, // Decimal (2 decimal places)
                CleaningFee = 12.81m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3152,
                Zip = 68847, // Int32
                State = "LA",
                Street = "521 Flores Stream",
                City = "West Rebeccaborough",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "rankin@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Cabin"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 3, // Int32
                Bathrooms = 5, // Int32
                GuestsAllowed = 3, // Int32
                WeekdayPrice = 77.06m, // Decimal (2 decimal places)
                WeekendPrice = 254.37m, // Decimal (2 decimal places)
                CleaningFee = 6.03m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3153,
                Zip = 35218, // Int32
                State = "NE",
                Street = "0271 Soto Drives Apt. 975",
                City = "New Edgar",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "tanner@utexas.edu"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Apartment"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 4, // Int32
                Bathrooms = 5, // Int32
                GuestsAllowed = 9, // Int32
                WeekdayPrice = 179.91m, // Decimal (2 decimal places)
                WeekendPrice = 233.17m, // Decimal (2 decimal places)
                CleaningFee = 11.04m, // Decimal (2 decimal places)
                DiscountMinStay = 32,
                DiscountRate = 0.18m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3154,
                Zip = 32697, // Int32
                State = "NM",
                Street = "27862 Kent Mountains",
                City = "Lake Michaelville",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "jacobs@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "House"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 6, // Int32
                Bathrooms = 5, // Int32
                GuestsAllowed = 14, // Int32
                WeekdayPrice = 90.54m, // Decimal (2 decimal places)
                WeekendPrice = 153.38m, // Decimal (2 decimal places)
                CleaningFee = 6.91m, // Decimal (2 decimal places)
                DiscountMinStay = 30,
                DiscountRate = 0.18m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3155,
                Zip = 95889, // Int32
                State = "OR",
                Street = "917 Mclaughlin Glens",
                City = "Martinville",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "rankin@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "House"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 7, // Int32
                Bathrooms = 6, // Int32
                GuestsAllowed = 2, // Int32
                WeekdayPrice = 225.59m, // Decimal (2 decimal places)
                WeekendPrice = 226.89m, // Decimal (2 decimal places)
                CleaningFee = 28.99m, // Decimal (2 decimal places)
                DiscountMinStay = 15,
                DiscountRate = 0.12m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3156,
                Zip = 82153, // Int32
                State = "KY",
                Street = "3032 Michelle Drives",
                City = "North Daniel",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "rankin@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Cabin"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 3, // Int32
                Bathrooms = 4, // Int32
                GuestsAllowed = 13, // Int32
                WeekdayPrice = 203.25m, // Decimal (2 decimal places)
                WeekendPrice = 157.15m, // Decimal (2 decimal places)
                CleaningFee = 15.68m, // Decimal (2 decimal places)
                DiscountMinStay = 9,
                DiscountRate = 0.23m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3157,
                Zip = 32202, // Int32
                State = "SD",
                Street = "601 Maria Mission Apt. 554",
                City = "Myerstown",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "tanner@utexas.edu"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Apartment"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 7, // Int32
                Bathrooms = 9, // Int32
                GuestsAllowed = 9, // Int32
                WeekdayPrice = 223.27m, // Decimal (2 decimal places)
                WeekendPrice = 269.55m, // Decimal (2 decimal places)
                CleaningFee = 11.35m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3158,
                Zip = 17431, // Int32
                State = "OH",
                Street = "238 Shawn Well",
                City = "Port Johnshire",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "ingram@gmail.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "House"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 7, // Int32
                Bathrooms = 8, // Int32
                GuestsAllowed = 14, // Int32
                WeekdayPrice = 173.63m, // Decimal (2 decimal places)
                WeekendPrice = 112.64m, // Decimal (2 decimal places)
                CleaningFee = 6.38m, // Decimal (2 decimal places)
                DiscountMinStay = 13,
                DiscountRate = 0.06m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3159,
                Zip = 37901, // Int32
                State = "SC",
                Street = "41743 Berger Inlet Apt. 527",
                City = "South Tammymouth",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "rice@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Apartment"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 7, // Int32
                Bathrooms = 9, // Int32
                GuestsAllowed = 9, // Int32
                WeekdayPrice = 176.23m, // Decimal (2 decimal places)
                WeekendPrice = 163.20m, // Decimal (2 decimal places)
                CleaningFee = 14.77m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3160,
                Zip = 17895, // Int32
                State = "MO",
                Street = "9983 Mary Grove Apt. 643",
                City = "Beardview",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "ingram@gmail.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Apartment"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 7, // Int32
                Bathrooms = 6, // Int32
                GuestsAllowed = 9, // Int32
                WeekdayPrice = 219.53m, // Decimal (2 decimal places)
                WeekendPrice = 209.33m, // Decimal (2 decimal places)
                CleaningFee = 24.51m, // Decimal (2 decimal places)
                DiscountMinStay = 16,
                DiscountRate = 0.10m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3161,
                Zip = 90576, // Int32
                State = "HI",
                Street = "03541 Ryan Islands Apt. 562",
                City = "East Michaelfort",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "rice@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Apartment"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 1, // Int32
                Bathrooms = 2, // Int32
                GuestsAllowed = 10, // Int32
                WeekdayPrice = 126.25m, // Decimal (2 decimal places)
                WeekendPrice = 269.63m, // Decimal (2 decimal places)
                CleaningFee = 8.27m, // Decimal (2 decimal places)
                DiscountMinStay = 8,
                DiscountRate = 0.16m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3162,
                Zip = 94980, // Int32
                State = "SC",
                Street = "6591 Angela Mission Apt. 108",
                City = "Penabury",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "chung@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Apartment"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 5, // Int32
                Bathrooms = 6, // Int32
                GuestsAllowed = 14, // Int32
                WeekdayPrice = 143.98m, // Decimal (2 decimal places)
                WeekendPrice = 286.86m, // Decimal (2 decimal places)
                CleaningFee = 20.48m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3163,
                Zip = 44974, // Int32
                State = "CO",
                Street = "492 Ramirez Crossing",
                City = "Aaronberg",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "rice@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "House"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 1, // Int32
                Bathrooms = 2, // Int32
                GuestsAllowed = 10, // Int32
                WeekdayPrice = 121.91m, // Decimal (2 decimal places)
                WeekendPrice = 144.60m, // Decimal (2 decimal places)
                CleaningFee = 10.12m, // Decimal (2 decimal places)
                DiscountMinStay = 8,
                DiscountRate = 0.22m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3164,
                Zip = 66170, // Int32
                State = "DE",
                Street = "35974 Sharon Locks Apt. 101",
                City = "Jennyport",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "martinez@aol.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Apartment"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 7, // Int32
                Bathrooms = 9, // Int32
                GuestsAllowed = 1, // Int32
                WeekdayPrice = 137.80m, // Decimal (2 decimal places)
                WeekendPrice = 114.46m, // Decimal (2 decimal places)
                CleaningFee = 17.74m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3165,
                Zip = 22495, // Int32
                State = "UT",
                Street = "89403 Gabriella Mills",
                City = "East Steven",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "gonzalez@aol.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "House"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 3, // Int32
                Bathrooms = 4, // Int32
                GuestsAllowed = 11, // Int32
                WeekdayPrice = 128.63m, // Decimal (2 decimal places)
                WeekendPrice = 155.10m, // Decimal (2 decimal places)
                CleaningFee = 23.05m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3166,
                Zip = 85059, // Int32
                State = "NH",
                Street = "601 Kyle Roads",
                City = "Clarkfurt",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "tanner@utexas.edu"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Cabin"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 4, // Int32
                Bathrooms = 5, // Int32
                GuestsAllowed = 4, // Int32
                WeekdayPrice = 209.11m, // Decimal (2 decimal places)
                WeekendPrice = 284.39m, // Decimal (2 decimal places)
                CleaningFee = 6.25m, // Decimal (2 decimal places)
                DiscountMinStay = 6,
                DiscountRate = 0.14m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3167,
                Zip = 61092, // Int32
                State = "IN",
                Street = "60969 Justin Passage Suite 774",
                City = "Joshuaburgh",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "loter@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Condo"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 1, // Int32
                Bathrooms = 1, // Int32
                GuestsAllowed = 7, // Int32
                WeekdayPrice = 128.59m, // Decimal (2 decimal places)
                WeekendPrice = 121.00m, // Decimal (2 decimal places)
                CleaningFee = 19.36m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3168,
                Zip = 43986, // Int32
                State = "PA",
                Street = "7943 Tina Mount",
                City = "East Lisa",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "gonzalez@aol.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Cabin"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 4, // Int32
                Bathrooms = 3, // Int32
                GuestsAllowed = 14, // Int32
                WeekdayPrice = 122.88m, // Decimal (2 decimal places)
                WeekendPrice = 104.47m, // Decimal (2 decimal places)
                CleaningFee = 25.31m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3169,
                Zip = 91397, // Int32
                State = "NC",
                Street = "6775 James Ford",
                City = "South Victorialand",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "jacobs@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Cabin"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 1, // Int32
                Bathrooms = 3, // Int32
                GuestsAllowed = 9, // Int32
                WeekdayPrice = 211.24m, // Decimal (2 decimal places)
                WeekendPrice = 275.50m, // Decimal (2 decimal places)
                CleaningFee = 15.74m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3170,
                Zip = 67849, // Int32
                State = "VT",
                Street = "431 Johnson Neck Suite 039",
                City = "Mariechester",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "rice@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Condo"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 1, // Int32
                Bathrooms = 1, // Int32
                GuestsAllowed = 9, // Int32
                WeekdayPrice = 124.65m, // Decimal (2 decimal places)
                WeekendPrice = 126.24m, // Decimal (2 decimal places)
                CleaningFee = 24.30m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3171,
                Zip = 20687, // Int32
                State = "NM",
                Street = "15666 Justin Locks",
                City = "Lake Ryanport",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "tanner@utexas.edu"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Cabin"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 6, // Int32
                Bathrooms = 6, // Int32
                GuestsAllowed = 3, // Int32
                WeekdayPrice = 70.11m, // Decimal (2 decimal places)
                WeekendPrice = 112.05m, // Decimal (2 decimal places)
                CleaningFee = 27.45m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3172,
                Zip = 30222, // Int32
                State = "TX",
                Street = "9947 Torres Viaduct Apt. 506",
                City = "Benjaminport",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "ingram@gmail.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Apartment"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 1, // Int32
                Bathrooms = 2, // Int32
                GuestsAllowed = 11, // Int32
                WeekdayPrice = 174.87m, // Decimal (2 decimal places)
                WeekendPrice = 152.09m, // Decimal (2 decimal places)
                CleaningFee = 18.44m, // Decimal (2 decimal places)
                DiscountMinStay = 8,
                DiscountRate = 0.08m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { DateTime.Parse("2024-12-30 00:00:00"), DateTime.Parse("2024-12-31 00:00:00"), DateTime.Parse("2025-01-01 00:00:00") } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3173,
                Zip = 21190, // Int32
                State = "NJ",
                Street = "20866 Keith Mill",
                City = "Susanton",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "chung@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Cabin"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 2, // Int32
                Bathrooms = 4, // Int32
                GuestsAllowed = 10, // Int32
                WeekdayPrice = 96.80m, // Decimal (2 decimal places)
                WeekendPrice = 174.06m, // Decimal (2 decimal places)
                CleaningFee = 28.15m, // Decimal (2 decimal places)
                DiscountMinStay = 21,
                DiscountRate = 0.10m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3174,
                Zip = 4838, // Int32
                State = "AL",
                Street = "04374 Nicholas Cliff Suite 001",
                City = "Adrianport",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "jacobs@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Condo"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 1, // Int32
                Bathrooms = 1, // Int32
                GuestsAllowed = 10, // Int32
                WeekdayPrice = 205.01m, // Decimal (2 decimal places)
                WeekendPrice = 108.24m, // Decimal (2 decimal places)
                CleaningFee = 6.56m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3175,
                Zip = 80130, // Int32
                State = "CA",
                Street = "271 Andrew Summit",
                City = "Port Craig",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "gonzalez@aol.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "House"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 7, // Int32
                Bathrooms = 6, // Int32
                GuestsAllowed = 7, // Int32
                WeekdayPrice = 197.52m, // Decimal (2 decimal places)
                WeekendPrice = 148.39m, // Decimal (2 decimal places)
                CleaningFee = 20.55m, // Decimal (2 decimal places)
                DiscountMinStay = 27,
                DiscountRate = 0.14m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3176,
                Zip = 96166, // Int32
                State = "MN",
                Street = "17611 Robbins Mission",
                City = "New Curtis",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "loter@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Cabin"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 3, // Int32
                Bathrooms = 3, // Int32
                GuestsAllowed = 9, // Int32
                WeekdayPrice = 219.69m, // Decimal (2 decimal places)
                WeekendPrice = 286.13m, // Decimal (2 decimal places)
                CleaningFee = 10.64m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3177,
                Zip = 40702, // Int32
                State = "MO",
                Street = "80831 Kemp Pines",
                City = "Annashire",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "loter@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Cabin"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 1, // Int32
                Bathrooms = 2, // Int32
                GuestsAllowed = 7, // Int32
                WeekdayPrice = 91.26m, // Decimal (2 decimal places)
                WeekendPrice = 123.93m, // Decimal (2 decimal places)
                CleaningFee = 19.36m, // Decimal (2 decimal places)
                DiscountMinStay = 19,
                DiscountRate = 0.23m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3178,
                Zip = 86023, // Int32
                State = "IL",
                Street = "96545 Smith Alley",
                City = "West Joy",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "martinez@aol.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "House"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 6, // Int32
                Bathrooms = 8, // Int32
                GuestsAllowed = 7, // Int32
                WeekdayPrice = 132.54m, // Decimal (2 decimal places)
                WeekendPrice = 254.38m, // Decimal (2 decimal places)
                CleaningFee = 14.83m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3179,
                Zip = 70897, // Int32
                State = "MT",
                Street = "6146 Johnson Isle",
                City = "South Arthur",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "chung@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "House"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 2, // Int32
                Bathrooms = 4, // Int32
                GuestsAllowed = 1, // Int32
                WeekdayPrice = 227.96m, // Decimal (2 decimal places)
                WeekendPrice = 228.04m, // Decimal (2 decimal places)
                CleaningFee = 6.99m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3180,
                Zip = 69154, // Int32
                State = "MN",
                Street = "0415 Smith Springs",
                City = "Jeremyburgh",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "loter@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "House"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 4, // Int32
                Bathrooms = 4, // Int32
                GuestsAllowed = 3, // Int32
                WeekdayPrice = 140.93m, // Decimal (2 decimal places)
                WeekendPrice = 228.81m, // Decimal (2 decimal places)
                CleaningFee = 29.74m, // Decimal (2 decimal places)
                DiscountMinStay = 21,
                DiscountRate = 0.15m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3181,
                Zip = 53524, // Int32
                State = "HI",
                Street = "3999 Ricky Via",
                City = "West Adamburgh",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "chung@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "House"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 7, // Int32
                Bathrooms = 6, // Int32
                GuestsAllowed = 6, // Int32
                WeekdayPrice = 137.35m, // Decimal (2 decimal places)
                WeekendPrice = 255.43m, // Decimal (2 decimal places)
                CleaningFee = 16.62m, // Decimal (2 decimal places)
                DiscountMinStay = 21,
                DiscountRate = 0.14m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3182,
                Zip = 24886, // Int32
                State = "MN",
                Street = "83787 Stuart Key",
                City = "Davetown",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "chung@yahoo.com"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Cabin"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 7, // Int32
                Bathrooms = 6, // Int32
                GuestsAllowed = 4, // Int32
                WeekdayPrice = 172.99m, // Decimal (2 decimal places)
                WeekendPrice = 146.75m, // Decimal (2 decimal places)
                CleaningFee = 26.24m, // Decimal (2 decimal places)
                DiscountMinStay = 6,
                DiscountRate = 0.23m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            AllProperties.Add(new Property
            {
                PropertyNumber = 3183,
                Zip = 56713, // Int32
                State = "TX",
                Street = "690 Christina Park",
                City = "Toddburgh",
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "tanner@utexas.edu"),
                Categories = db.Categories.FirstOrDefault(x => x.CategoryName == "Cabin"),
                PetsAllowed = true, // Boolean
                FreeParking = true, // Boolean
                Bedrooms = 3, // Int32
                Bathrooms = 5, // Int32
                GuestsAllowed = 1, // Int32
                WeekdayPrice = 188.53m, // Decimal (2 decimal places)
                WeekendPrice = 157.96m, // Decimal (2 decimal places)
                CleaningFee = 6.69m, // Decimal (2 decimal places)
                DiscountMinStay = 0,
                DiscountRate = 0.00m,
                PropertyStatus = true, // Boolean
                UnavailableDates = new List<DateTime> { } // List of dates
            });

            // Create a counter and flag to help with debugging
            int intPropertyID = 0;
            string strPropertyNumber = "Start";
            string strPropertyAddress = "Start";

            // Add the properties to the database in a Try/Catch block to handle potential errors
            try
            {
                // Loop through each property
                foreach (Property seedProperty in AllProperties)
                {
                    // Update debugging variables to track progress
                    intPropertyID = seedProperty.PropertyID;
                    strPropertyNumber = seedProperty.PropertyNumber.ToString();
                    strPropertyAddress = seedProperty.Street + ", " + seedProperty.City + ", " +
                                         seedProperty.State + " " + seedProperty.Zip;

                    // Check if the property already exists in the database
                    Property dbProperty = db.Properties.FirstOrDefault(c =>
                        c.PropertyNumber == seedProperty.PropertyNumber &&
                        c.Street == seedProperty.Street &&
                        c.City == seedProperty.City &&
                        c.State == seedProperty.State &&
                        c.Zip == seedProperty.Zip);

                    // If the property doesn't exist, add it to the database
                    if (dbProperty == null)
                    {
                        db.Properties.Add(seedProperty);
                        db.SaveChanges();
                    }
                    else // If the property exists, update the fields
                    {
                        dbProperty.PetsAllowed = seedProperty.PetsAllowed;
                        dbProperty.FreeParking = seedProperty.FreeParking;
                        dbProperty.Bedrooms = seedProperty.Bedrooms;
                        dbProperty.Bathrooms = seedProperty.Bathrooms;
                        dbProperty.GuestsAllowed = seedProperty.GuestsAllowed;
                        dbProperty.WeekdayPrice = seedProperty.WeekdayPrice;
                        dbProperty.WeekendPrice = seedProperty.WeekendPrice;
                        dbProperty.CleaningFee = seedProperty.CleaningFee;
                        dbProperty.DiscountMinStay = seedProperty.DiscountMinStay;
                        dbProperty.DiscountRate = seedProperty.DiscountRate;
                        dbProperty.PropertyStatus = seedProperty.PropertyStatus;
                        dbProperty.UnavailableDates = seedProperty.UnavailableDates; // Assuming List<DateTime>

                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex) // Handle errors during the database operation
            {
                // Build a custom error message for debugging
                StringBuilder msg = new StringBuilder();

                msg.Append("There was an error adding the property with number ");
                msg.Append(strPropertyNumber);
                msg.Append(" at address ");
                msg.Append(strPropertyAddress);
                msg.Append(" (PropertyID = ");
                msg.Append(intPropertyID);
                msg.Append(")");

                // Throw a new exception with the custom error message
                throw new Exception(msg.ToString(), ex);
            }
        }
    }
}