using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

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
        [Display(Name = "Weekday Price")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal WeekdayPrice { get; set; }
        [Display(Name = "Weekend Price")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal WeekendPrice { get; set; }
        // Category dropdown
        [Display(Name = "Category")]
        //public int SelectedCategoryID { get; set; }
        public string Category { get; set; }
        [Display(Name = "Guest Rating")]
        public decimal? GuestRating { get; set; }
        //public IEnumerable<SelectListItem> Categories { get; set; }
    }
}

