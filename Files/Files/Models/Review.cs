using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Xml.Linq;

namespace Files.Models
{
    public enum StatusDispute { Accepted , Rejected}
    public class Review
    {
        [Key]
        public Int32 ReviewID { get; set; }

        [Required(ErrorMessage = "Rating is required")]
        [Range(1, 5)]
        public Int32 Rating { get; set; }

        [Display(Name = "Text Review")]
        [StringLength(280)]
        public string? TextReview { get; set; }

        [Display(Name = "Host Comments")]
        [StringLength(280)]
        public string? HostComments { get; set; }

        [Display(Name = "Dispute Status")]
        public StatusDispute DisputeStatus { get; set; }

        //one property
        public Property Properties { get; set; }

        //one user
        public AppUser AppUsers { get; set; }
    }
}


