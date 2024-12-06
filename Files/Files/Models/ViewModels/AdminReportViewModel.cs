using System;
using System.Collections.Generic;

namespace Files.Models
{
    public class AdminReportViewModel
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public AdminReport Report { get; set; }
    }

    public class AdminReport
    {
        public decimal TotalCommissionEarned { get; set; }
        public int TotalNumberOfReservations { get; set; }
        public decimal AverageCommissionPerReservation { get; set; }
        public int TotalNumberOfProperties { get; set; }
    }
}

