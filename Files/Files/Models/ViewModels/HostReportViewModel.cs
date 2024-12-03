using System;
using System.Collections.Generic;

namespace Files.Models
{
    public class HostReportViewModel
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<HostReport> Reports { get; set; }
    }

    public class HostReport
    {
        public string Street { get; set; } // Street Address as the identifier
        public int PropertyNumber { get; set; } // Optional: Property Number for clarity
        public decimal TotalStayRevenue { get; set; }
        public decimal TotalCleaningFees { get; set; }
        public decimal TotalCombinedRevenue { get; set; }
        public int TotalReservations { get; set; }
    }
}

