using System;
namespace Files.Models
{
    public class PropertyViewModel
    {
        public int PropertyID { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Bedrooms { get; set; }
        public int Bathrooms { get; set; }
        public int GuestsAllowed { get; set; }
        public decimal WeekdayPrice { get; set; }
        public string Category { get; set; }
        public double GuestRating { get; set; }
    }
}

