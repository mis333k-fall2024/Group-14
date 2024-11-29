
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


    public static class SeedReservations
    {
        public static void SeedAllReservations(AppDbContext db)
        {
            List<Reservation> AllReservations = new List<Reservation>();


            AllReservations.Add(new Reservation
            {

                Properties = db.Properties.FirstOrDefault(c => c.PropertyNumber == 3133),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "sheff44@puppy.com"),
                CheckIn = new DateTime(2024, 11, 1),
                CheckOut = new DateTime(2024, 11, 3),
                WeekdayPrice = 134.72m,
                WeekendPrice = 249.39m,
                CleaningFee = 19.19m,
                DiscountRate = 0.00m,
                NumOfGuests = 1,
                ConfirmationNumber = 21900,
                ReservationStatus = true,
            });

            AllReservations.Add(new Reservation
            {

                Properties = db.Properties.FirstOrDefault(c => c.PropertyNumber == 3150),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "luce_chuck@puppy.com"),
                CheckIn = new DateTime(2024, 11, 4),
                CheckOut = new DateTime(2024, 11, 6),
                WeekdayPrice = 204.67m,
                WeekendPrice = 207.51m,
                CleaningFee = 26.36m,
                DiscountRate = 0.22m,
                NumOfGuests = 2,
                ConfirmationNumber = 21901,
                ReservationStatus = true,
            });

            AllReservations.Add(new Reservation
            {

                Properties = db.Properties.FirstOrDefault(c => c.PropertyNumber == 3116),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "luce_chuck@puppy.com"),
                CheckIn = new DateTime(2024, 11, 6),
                CheckOut = new DateTime(2024, 11, 10),
                WeekdayPrice = 163.30m,
                WeekendPrice = 262.77m,
                CleaningFee = 13.74m,
                DiscountRate = 0.16m,
                NumOfGuests = 14,
                ConfirmationNumber = 21901,
                ReservationStatus = true,
            });

            AllReservations.Add(new Reservation
            {

                Properties = db.Properties.FirstOrDefault(c => c.PropertyNumber == 3133),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "lamemartin.Martin@aool.com"),
                CheckIn = new DateTime(2024, 11, 7),
                CheckOut = new DateTime(2024, 11, 12),
                WeekdayPrice = 134.72m,
                WeekendPrice = 249.39m,
                CleaningFee = 19.19m,
                DiscountRate = 0.00m,
                NumOfGuests = 1,
                ConfirmationNumber = 21902,
                ReservationStatus = true,
            });

            AllReservations.Add(new Reservation
            {

                Properties = db.Properties.FirstOrDefault(c => c.PropertyNumber == 3067),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "tuck33@puppy.com"),
                CheckIn = new DateTime(2024, 11, 6),
                CheckOut = new DateTime(2024, 11, 18),
                WeekdayPrice = 163.68m,
                WeekendPrice = 286.53m,
                CleaningFee = 25.57m,
                DiscountRate = 0.00m,
                NumOfGuests = 9,
                ConfirmationNumber = 21903,
                ReservationStatus = true,
            });

            AllReservations.Add(new Reservation
            {

                Properties = db.Properties.FirstOrDefault(c => c.PropertyNumber == 3075),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "liz@puppy.com"),
                CheckIn = new DateTime(2024, 11, 7),
                CheckOut = new DateTime(2024, 11, 15),
                WeekdayPrice = 147.55m,
                WeekendPrice = 209.77m,
                CleaningFee = 27.65m,
                DiscountRate = 0.09m,
                NumOfGuests = 3,
                ConfirmationNumber = 21904,
                ReservationStatus = true,
            });

            AllReservations.Add(new Reservation
            {

                Properties = db.Properties.FirstOrDefault(c => c.PropertyNumber == 3127),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "orielly@foxnets.com"),
                CheckIn = new DateTime(2024, 11, 17),
                CheckOut = new DateTime(2024, 11, 22),
                WeekdayPrice = 224.98m,
                WeekendPrice = 180.86m,
                CleaningFee = 11.91m,
                DiscountRate = 0.00m,
                NumOfGuests = 12,
                ConfirmationNumber = 21905,
                ReservationStatus = true,
            });

            AllReservations.Add(new Reservation
            {

                Properties = db.Properties.FirstOrDefault(c => c.PropertyNumber == 3133),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "orielly@foxnets.com"),
                CheckIn = new DateTime(2024, 11, 22),
                CheckOut = new DateTime(2024, 11, 27),
                WeekdayPrice = 134.72m,
                WeekendPrice = 249.39m,
                CleaningFee = 19.19m,
                DiscountRate = 0.00m,
                NumOfGuests = 1,
                ConfirmationNumber = 21906,
                ReservationStatus = true,
            });

            AllReservations.Add(new Reservation
            {

                Properties = db.Properties.FirstOrDefault(c => c.PropertyNumber == 3082),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "elowe@netscrape.net"),
                CheckIn = new DateTime(2024, 11, 23),
                CheckOut = new DateTime(2024, 12, 1),
                WeekdayPrice = 93.35m,
                WeekendPrice = 271.49m,
                CleaningFee = 8.54m,
                DiscountRate = 0.18m,
                NumOfGuests = 5,
                ConfirmationNumber = 21907,
                ReservationStatus = true,
            });

            AllReservations.Add(new Reservation
            {

                Properties = db.Properties.FirstOrDefault(c => c.PropertyNumber == 3172),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "victoria@puppy.com"),
                CheckIn = new DateTime(2024, 11, 24),
                CheckOut = new DateTime(2024, 12, 4),
                WeekdayPrice = 174.87m,
                WeekendPrice = 152.09m,
                CleaningFee = 18.44m,
                DiscountRate = 0.08m,
                NumOfGuests = 11,
                ConfirmationNumber = 21908,
                ReservationStatus = true,
            });

            AllReservations.Add(new Reservation
            {

                Properties = db.Properties.FirstOrDefault(c => c.PropertyNumber == 3056),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "wjhearniii@umch.edu"),
                CheckIn = new DateTime(2024, 11, 29),
                CheckOut = new DateTime(2024, 12, 18),
                WeekdayPrice = 117.45m,
                WeekendPrice = 167.53m,
                CleaningFee = 24.75m,
                DiscountRate = 0.17m,
                NumOfGuests = 10,
                ConfirmationNumber = 21909,
                ReservationStatus = true,
            });

            AllReservations.Add(new Reservation
            {

                Properties = db.Properties.FirstOrDefault(c => c.PropertyNumber == 3065),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "fd@puppy.com"),
                CheckIn = new DateTime(2024, 11, 28),
                CheckOut = new DateTime(2024, 12, 1),
                WeekdayPrice = 155.03m,
                WeekendPrice = 139.83m,
                CleaningFee = 21.05m,
                DiscountRate = 0.09m,
                NumOfGuests = 13,
                ConfirmationNumber = 21910,
                ReservationStatus = true,
            });

            AllReservations.Add(new Reservation
            {

                Properties = db.Properties.FirstOrDefault(c => c.PropertyNumber == 3067),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "tfreeley@puppy.com"),
                CheckIn = new DateTime(2024, 11, 1),
                CheckOut = new DateTime(2024, 11, 5),
                WeekdayPrice = 163.68m,
                WeekendPrice = 286.53m,
                CleaningFee = 25.57m,
                DiscountRate = 0.00m,
                NumOfGuests = 9,
                ConfirmationNumber = 21911,
                ReservationStatus = true,
            });

            AllReservations.Add(new Reservation
            {

                Properties = db.Properties.FirstOrDefault(c => c.PropertyNumber == 3094),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "wendy@puppy.com"),
                CheckIn = new DateTime(2024, 11, 15),
                CheckOut = new DateTime(2024, 12, 1),
                WeekdayPrice = 215.38m,
                WeekendPrice = 117.17m,
                CleaningFee = 24.31m,
                DiscountRate = 0.00m,
                NumOfGuests = 14,
                ConfirmationNumber = 21912,
                ReservationStatus = true,
            });

            AllReservations.Add(new Reservation
            {

                Properties = db.Properties.FirstOrDefault(c => c.PropertyNumber == 3148),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "444444.Dave@aool.com"),
                CheckIn = new DateTime(2024, 11, 5),
                CheckOut = new DateTime(2024, 12, 3),
                WeekdayPrice = 150.69m,
                WeekendPrice = 109.87m,
                CleaningFee = 13.30m,
                DiscountRate = 0.00m,
                NumOfGuests = 7,
                ConfirmationNumber = 21913,
                ReservationStatus = true,
            });

            AllReservations.Add(new Reservation
            {

                Properties = db.Properties.FirstOrDefault(c => c.PropertyNumber == 3127),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "father.Ingram@aool.com"),
                CheckIn = new DateTime(2024, 11, 1),
                CheckOut = new DateTime(2024, 11, 16),
                WeekdayPrice = 224.98m,
                WeekendPrice = 180.86m,
                CleaningFee = 11.91m,
                DiscountRate = 0.00m,
                NumOfGuests = 12,
                ConfirmationNumber = 21914,
                ReservationStatus = true,
            });

            AllReservations.Add(new Reservation
            {

                Properties = db.Properties.FirstOrDefault(c => c.PropertyNumber == 3085),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "orielly@foxnets.com"),
                CheckIn = new DateTime(2024, 12, 8),
                CheckOut = new DateTime(2024, 12, 10),
                WeekdayPrice = 194.84m,
                WeekendPrice = 278.17m,
                CleaningFee = 5.88m,
                DiscountRate = 0.00m,
                NumOfGuests = 11,
                ConfirmationNumber = 21915,
                ReservationStatus = true,
            });

            AllReservations.Add(new Reservation
            {

                Properties = db.Properties.FirstOrDefault(c => c.PropertyNumber == 3180),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "hicks43@puppy.com"),
                CheckIn = new DateTime(2024, 12, 9),
                CheckOut = new DateTime(2024, 12, 11),
                WeekdayPrice = 140.93m,
                WeekendPrice = 228.81m,
                CleaningFee = 29.74m,
                DiscountRate = 0.15m,
                NumOfGuests = 3,
                ConfirmationNumber = 21916,
                ReservationStatus = true,
            });

            AllReservations.Add(new Reservation
            {

                Properties = db.Properties.FirstOrDefault(c => c.PropertyNumber == 3161),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "orielly@foxnets.com"),
                CheckIn = new DateTime(2024, 12, 2),
                CheckOut = new DateTime(2024, 12, 5),
                WeekdayPrice = 126.25m,
                WeekendPrice = 269.63m,
                CleaningFee = 8.27m,
                DiscountRate = 0.16m,
                NumOfGuests = 10,
                ConfirmationNumber = 21917,
                ReservationStatus = true,
            });

            AllReservations.Add(new Reservation
            {

                Properties = db.Properties.FirstOrDefault(c => c.PropertyNumber == 3085),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "sheff44@puppy.com"),
                CheckIn = new DateTime(2024, 12, 1),
                CheckOut = new DateTime(2024, 12, 4),
                WeekdayPrice = 194.84m,
                WeekendPrice = 278.17m,
                CleaningFee = 5.88m,
                DiscountRate = 0.00m,
                NumOfGuests = 11,
                ConfirmationNumber = 21918,
                ReservationStatus = true,
            });

            AllReservations.Add(new Reservation
            {

                Properties = db.Properties.FirstOrDefault(c => c.PropertyNumber == 3021),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "sheff44@puppy.com"),
                CheckIn = new DateTime(2024, 12, 8),
                CheckOut = new DateTime(2024, 12, 9),
                WeekdayPrice = 112.62m,
                WeekendPrice = 165.32m,
                CleaningFee = 24.26m,
                DiscountRate = 0.00m,
                NumOfGuests = 12,
                ConfirmationNumber = 21919,
                ReservationStatus = true,
            });

            AllReservations.Add(new Reservation
            {

                Properties = db.Properties.FirstOrDefault(c => c.PropertyNumber == 3174),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "sheff44@puppy.com"),
                CheckIn = new DateTime(2024, 12, 10),
                CheckOut = new DateTime(2024, 12, 11),
                WeekdayPrice = 205.01m,
                WeekendPrice = 108.24m,
                CleaningFee = 6.56m,
                DiscountRate = 0.00m,
                NumOfGuests = 10,
                ConfirmationNumber = 21919,
                ReservationStatus = true,
            });

            AllReservations.Add(new Reservation
            {

                Properties = db.Properties.FirstOrDefault(c => c.PropertyNumber == 3005),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "sheff44@puppy.com"),
                CheckIn = new DateTime(2024, 12, 9),
                CheckOut = new DateTime(2024, 12, 10),
                WeekdayPrice = 170.25m,
                WeekendPrice = 100.37m,
                CleaningFee = 18.64m,
                DiscountRate = 0.00m,
                NumOfGuests = 12,
                ConfirmationNumber = 21919,
                ReservationStatus = true,
            });

            AllReservations.Add(new Reservation
            {

                Properties = db.Properties.FirstOrDefault(c => c.PropertyNumber == 3161),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "father.Ingram@aool.com"),
                CheckIn = new DateTime(2024, 11, 22),
                CheckOut = new DateTime(2024, 12, 1),
                WeekdayPrice = 126.25m,
                WeekendPrice = 269.63m,
                CleaningFee = 8.27m,
                DiscountRate = 0.16m,
                NumOfGuests = 10,
                ConfirmationNumber = 21919,
                ReservationStatus = true,
            });

            AllReservations.Add(new Reservation
            {

                Properties = db.Properties.FirstOrDefault(c => c.PropertyNumber == 3087),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "fd@puppy.com"),
                CheckIn = new DateTime(2024, 12, 8),
                CheckOut = new DateTime(2024, 12, 12),
                WeekdayPrice = 127.97m,
                WeekendPrice = 182.77m,
                CleaningFee = 13.02m,
                DiscountRate = 0.17m,
                NumOfGuests = 1,
                ConfirmationNumber = 21920,
                ReservationStatus = true,
            });

            AllReservations.Add(new Reservation
            {

                Properties = db.Properties.FirstOrDefault(c => c.PropertyNumber == 3107),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "father.Ingram@aool.com"),
                CheckIn = new DateTime(2024, 12, 8),
                CheckOut = new DateTime(2024, 12, 12),
                WeekdayPrice = 83.34m,
                WeekendPrice = 128.05m,
                CleaningFee = 11.29m,
                DiscountRate = 0.21m,
                NumOfGuests = 8,
                ConfirmationNumber = 21921,
                ReservationStatus = true,
            });

            AllReservations.Add(new Reservation
            {

                Properties = db.Properties.FirstOrDefault(c => c.PropertyNumber == 3051),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "father.Ingram@aool.com"),
                CheckIn = new DateTime(2024, 12, 12),
                CheckOut = new DateTime(2024, 12, 15),
                WeekdayPrice = 204.04m,
                WeekendPrice = 204.28m,
                CleaningFee = 11.07m,
                DiscountRate = 0.00m,
                NumOfGuests = 10,
                ConfirmationNumber = 21921,
                ReservationStatus = true,
            });

            AllReservations.Add(new Reservation
            {

                Properties = db.Properties.FirstOrDefault(c => c.PropertyNumber == 3073),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "jeff@puppy.com"),
                CheckIn = new DateTime(2024, 12, 7),
                CheckOut = new DateTime(2024, 12, 31),
                WeekdayPrice = 130.47m,
                WeekendPrice = 196.09m,
                CleaningFee = 14.53m,
                DiscountRate = 0.00m,
                NumOfGuests = 3,
                ConfirmationNumber = 21923,
                ReservationStatus = true,
            });

            AllReservations.Add(new Reservation
            {

                Properties = db.Properties.FirstOrDefault(c => c.PropertyNumber == 3097),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "cmiller@mapster.com"),
                CheckIn = new DateTime(2024, 12, 11),
                CheckOut = new DateTime(2024, 12, 24),
                WeekdayPrice = 170.07m,
                WeekendPrice = 176.37m,
                CleaningFee = 8.54m,
                DiscountRate = 0.09m,
                NumOfGuests = 13,
                ConfirmationNumber = 21923,
                ReservationStatus = true,
            });

            AllReservations.Add(new Reservation
            {

                Properties = db.Properties.FirstOrDefault(c => c.PropertyNumber == 3087),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "tuck33@puppy.com"),
                CheckIn = new DateTime(2024, 11, 22),
                CheckOut = new DateTime(2024, 11, 29),
                WeekdayPrice = 127.97m,
                WeekendPrice = 182.77m,
                CleaningFee = 13.02m,
                DiscountRate = 0.17m,
                NumOfGuests = 1,
                ConfirmationNumber = 21924,
                ReservationStatus = true,
            });

            AllReservations.Add(new Reservation
            {

                Properties = db.Properties.FirstOrDefault(c => c.PropertyNumber == 3038),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "tfreeley@puppy.com"),
                CheckIn = new DateTime(2024, 12, 16),
                CheckOut = new DateTime(2024, 12, 22),
                WeekdayPrice = 104.05m,
                WeekendPrice = 158.42m,
                CleaningFee = 5.36m,
                DiscountRate = 0.23m,
                NumOfGuests = 5,
                ConfirmationNumber = 21925,
                ReservationStatus = true,
            });

            AllReservations.Add(new Reservation
            {

                Properties = db.Properties.FirstOrDefault(c => c.PropertyNumber == 3107),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "tfreeley@puppy.com"),
                CheckIn = new DateTime(2024, 11, 20),
                CheckOut = new DateTime(2024, 12, 1),
                WeekdayPrice = 83.34m,
                WeekendPrice = 128.05m,
                CleaningFee = 11.29m,
                DiscountRate = 0.21m,
                NumOfGuests = 8,
                ConfirmationNumber = 21925,
                ReservationStatus = true,
            });

            AllReservations.Add(new Reservation
            {

                Properties = db.Properties.FirstOrDefault(c => c.PropertyNumber == 3113),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "tfreeley@puppy.com"),
                CheckIn = new DateTime(2024, 12, 22),
                CheckOut = new DateTime(2024, 12, 28),
                WeekdayPrice = 106.30m,
                WeekendPrice = 192.46m,
                CleaningFee = 17.59m,
                DiscountRate = 0.00m,
                NumOfGuests = 4,
                ConfirmationNumber = 21925,
                ReservationStatus = true,
            });

            AllReservations.Add(new Reservation
            {

                Properties = db.Properties.FirstOrDefault(c => c.PropertyNumber == 3142),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "tfreeley@puppy.com"),
                CheckIn = new DateTime(2024, 12, 28),
                CheckOut = new DateTime(2024, 12, 31),
                WeekdayPrice = 199.68m,
                WeekendPrice = 241.45m,
                CleaningFee = 25.94m,
                DiscountRate = 0.00m,
                NumOfGuests = 6,
                ConfirmationNumber = 21925,
                ReservationStatus = true,
            });

            AllReservations.Add(new Reservation
            {

                Properties = db.Properties.FirstOrDefault(c => c.PropertyNumber == 3071),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "tfreeley@puppy.com"),
                CheckIn = new DateTime(2024, 12, 14),
                CheckOut = new DateTime(2024, 12, 16),
                WeekdayPrice = 89.88m,
                WeekendPrice = 123.04m,
                CleaningFee = 19.14m,
                DiscountRate = 0.00m,
                NumOfGuests = 1,
                ConfirmationNumber = 21925,
                ReservationStatus = true,
            });

            AllReservations.Add(new Reservation
            {

                Properties = db.Properties.FirstOrDefault(c => c.PropertyNumber == 3065),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "tfreeley@puppy.com"),
                CheckIn = new DateTime(2024, 12, 2),
                CheckOut = new DateTime(2024, 12, 6),
                WeekdayPrice = 155.03m,
                WeekendPrice = 139.83m,
                CleaningFee = 21.05m,
                DiscountRate = 0.09m,
                NumOfGuests = 13,
                ConfirmationNumber = 21926,
                ReservationStatus = true,
            });

            AllReservations.Add(new Reservation
            {

                Properties = db.Properties.FirstOrDefault(c => c.PropertyNumber == 3157),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "peterstump@hootmail.com"),
                CheckIn = new DateTime(2024, 12, 15),
                CheckOut = new DateTime(2024, 12, 24),
                WeekdayPrice = 223.27m,
                WeekendPrice = 269.55m,
                CleaningFee = 11.35m,
                DiscountRate = 0.00m,
                NumOfGuests = 9,
                ConfirmationNumber = 21927,
                ReservationStatus = true,
            });

            AllReservations.Add(new Reservation
            {

                Properties = db.Properties.FirstOrDefault(c => c.PropertyNumber == 3107),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "ra@aoo.com"),
                CheckIn = new DateTime(2024, 12, 1),
                CheckOut = new DateTime(2024, 12, 4),
                WeekdayPrice = 83.34m,
                WeekendPrice = 128.05m,
                CleaningFee = 11.29m,
                DiscountRate = 0.21m,
                NumOfGuests = 8,
                ConfirmationNumber = 21928,
                ReservationStatus = true,
            });

            AllReservations.Add(new Reservation
            {

                Properties = db.Properties.FirstOrDefault(c => c.PropertyNumber == 3065),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "orielly@foxnets.com"),
                CheckIn = new DateTime(2024, 12, 1),
                CheckOut = new DateTime(2024, 12, 2),
                WeekdayPrice = 155.03m,
                WeekendPrice = 139.83m,
                CleaningFee = 21.05m,
                DiscountRate = 0.09m,
                NumOfGuests = 13,
                ConfirmationNumber = 21929,
                ReservationStatus = true,
            });

            AllReservations.Add(new Reservation
            {

                Properties = db.Properties.FirstOrDefault(c => c.PropertyNumber == 3034),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "orielly@foxnets.com"),
                CheckIn = new DateTime(2024, 12, 28),
                CheckOut = new DateTime(2025, 1, 3),
                WeekdayPrice = 172.83m,
                WeekendPrice = 229.98m,
                CleaningFee = 23.55m,
                DiscountRate = 0.00m,
                NumOfGuests = 14,
                ConfirmationNumber = 21929,
                ReservationStatus = true,
            });

            AllReservations.Add(new Reservation
            {

                Properties = db.Properties.FirstOrDefault(c => c.PropertyNumber == 3099),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "orielly@foxnets.com"),
                CheckIn = new DateTime(2024, 12, 25),
                CheckOut = new DateTime(2024, 12, 28),
                WeekdayPrice = 111.73m,
                WeekendPrice = 260.62m,
                CleaningFee = 15.89m,
                DiscountRate = 0.24m,
                NumOfGuests = 1,
                ConfirmationNumber = 21929,
                ReservationStatus = true,
            });

            AllReservations.Add(new Reservation
            {

                Properties = db.Properties.FirstOrDefault(c => c.PropertyNumber == 3183),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "tanner@puppy.com"),
                CheckIn = new DateTime(2024, 12, 29),
                CheckOut = new DateTime(2024, 12, 31),
                WeekdayPrice = 188.53m,
                WeekendPrice = 157.96m,
                CleaningFee = 6.69m,
                DiscountRate = 0.00m,
                NumOfGuests = 1,
                ConfirmationNumber = 21930,
                ReservationStatus = true,
            });

            AllReservations.Add(new Reservation
            {

                Properties = db.Properties.FirstOrDefault(c => c.PropertyNumber == 3127),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "tuck33@puppy.com"),
                CheckIn = new DateTime(2024, 11, 29),
                CheckOut = new DateTime(2024, 12, 2),
                WeekdayPrice = 224.98m,
                WeekendPrice = 180.86m,
                CleaningFee = 11.91m,
                DiscountRate = 0.00m,
                NumOfGuests = 12,
                ConfirmationNumber = 21931,
                ReservationStatus = true,
            });

            AllReservations.Add(new Reservation
            {

                Properties = db.Properties.FirstOrDefault(c => c.PropertyNumber == 3027),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "fd@puppy.com"),
                CheckIn = new DateTime(2024, 12, 14),
                CheckOut = new DateTime(2024, 12, 26),
                WeekdayPrice = 70.24m,
                WeekendPrice = 126.45m,
                CleaningFee = 18.69m,
                DiscountRate = 0.08m,
                NumOfGuests = 4,
                ConfirmationNumber = 21932,
                ReservationStatus = true,
            });

            AllReservations.Add(new Reservation
            {

                Properties = db.Properties.FirstOrDefault(c => c.PropertyNumber == 3122),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "fd@puppy.com"),
                CheckIn = new DateTime(2024, 12, 26),
                CheckOut = new DateTime(2024, 12, 31),
                WeekdayPrice = 189.98m,
                WeekendPrice = 119.06m,
                CleaningFee = 25.11m,
                DiscountRate = 0.00m,
                NumOfGuests = 1,
                ConfirmationNumber = 21932,
                ReservationStatus = true,
            });

            AllReservations.Add(new Reservation
            {

                Properties = db.Properties.FirstOrDefault(c => c.PropertyNumber == 3107),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "fd@puppy.com"),
                CheckIn = new DateTime(2024, 12, 4),
                CheckOut = new DateTime(2024, 12, 6),
                WeekdayPrice = 83.34m,
                WeekendPrice = 128.05m,
                CleaningFee = 11.29m,
                DiscountRate = 0.21m,
                NumOfGuests = 8,
                ConfirmationNumber = 21932,
                ReservationStatus = true,
            });

            AllReservations.Add(new Reservation
            {

                Properties = db.Properties.FirstOrDefault(c => c.PropertyNumber == 3065),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "ra@aoo.com"),
                CheckIn = new DateTime(2024, 12, 6),
                CheckOut = new DateTime(2024, 12, 10),
                WeekdayPrice = 155.03m,
                WeekendPrice = 139.83m,
                CleaningFee = 21.05m,
                DiscountRate = 0.09m,
                NumOfGuests = 13,
                ConfirmationNumber = 21933,
                ReservationStatus = true,
            });

            AllReservations.Add(new Reservation
            {

                Properties = db.Properties.FirstOrDefault(c => c.PropertyNumber == 3105),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "louielouie@puppy.com"),
                CheckIn = new DateTime(2024, 12, 26),
                CheckOut = new DateTime(2025, 1, 5),
                WeekdayPrice = 212.86m,
                WeekendPrice = 212.70m,
                CleaningFee = 6.82m,
                DiscountRate = 0.00m,
                NumOfGuests = 1,
                ConfirmationNumber = 21934,
                ReservationStatus = true,
            });

            AllReservations.Add(new Reservation
            {

                Properties = db.Properties.FirstOrDefault(c => c.PropertyNumber == 3053),
                AppUsers = db.Users.FirstOrDefault(r => r.Email == "rwood@voyager.net"),
                CheckIn = new DateTime(2024, 11, 25),
                CheckOut = new DateTime(2024, 11, 27),
                WeekdayPrice = 106.87m,
                WeekendPrice = 121.74m,
                CleaningFee = 5.62m,
                DiscountRate = 0.06m,
                NumOfGuests = 6,
                ConfirmationNumber = 21935,
                ReservationStatus = true,
            });

            // Create a counter and flag to help with debugging
            int intReservationID = 0;
            string strCustomerEmail = "Start";
            string strPropertyNumber = "Start";
            string strCheckInDate = "Start";
            string strCheckOutDate = "Start";

            // Add the reservations to the database in a Try/Catch block to handle potential errors
            try
            {
                // Loop through each reservation
                foreach (Reservation seedReservation in AllReservations)
                {
                    // Update debugging variables to track progress
                    intReservationID = seedReservation.ReservationID;
                    strCustomerEmail = seedReservation.AppUsers.Email;
                    strPropertyNumber = seedReservation.Properties.PropertyNumber.ToString();
                    strCheckInDate = seedReservation.CheckIn.ToString("yyyy-MM-dd");
                    strCheckOutDate = seedReservation.CheckOut.ToString("yyyy-MM-dd");

                    // Check if the reservation already exists in the database
                    Reservation dbReservation = db.Reservations.FirstOrDefault(r =>
                        r.Properties.PropertyNumber == seedReservation.Properties.PropertyNumber &&
                        r.AppUsers.Email == seedReservation.AppUsers.Email &&
                        r.CheckIn == seedReservation.CheckIn &&
                        r.CheckOut == seedReservation.CheckOut);

                    // If the reservation doesn't exist, add it to the database
                    if (dbReservation == null)
                    {
                        db.Reservations.Add(seedReservation);
                        db.SaveChanges();
                    }
                    else // If the reservation exists, update the fields
                    {
                        dbReservation.WeekdayPrice = seedReservation.WeekdayPrice;
                        dbReservation.WeekendPrice = seedReservation.WeekendPrice;
                        dbReservation.CleaningFee = seedReservation.CleaningFee;
                        dbReservation.DiscountRate = seedReservation.DiscountRate;
                        dbReservation.NumOfGuests = seedReservation.NumOfGuests;
                        dbReservation.ConfirmationNumber = seedReservation.ConfirmationNumber;
                        dbReservation.ReservationStatus = seedReservation.ReservationStatus;

                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex) // Handle errors during the database operation
            {
                // Build a custom error message for debugging
                StringBuilder msg = new StringBuilder();

                msg.Append("There was an error adding the reservation for customer ");
                msg.Append(strCustomerEmail);
                msg.Append(" at property number ");
                msg.Append(strPropertyNumber);
                msg.Append(" (ReservationID = ");
                msg.Append(intReservationID);
                msg.Append(") with check-in date ");
                msg.Append(strCheckInDate);
                msg.Append(" and check-out date ");
                msg.Append(strCheckOutDate);

                // Throw a new exception with the custom error message
                throw new Exception(msg.ToString(), ex);
            }
        }
    }
}
