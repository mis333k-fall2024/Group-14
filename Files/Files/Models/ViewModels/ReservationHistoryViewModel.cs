using System.Collections.Generic;

namespace Files.Models
{
    public class ReservationHistoryViewModel
    {
        public List<Reservation> PastReservations { get; set; }
        public List<Reservation> FutureReservations { get; set; }
        public List<Reservation> CanceledReservations { get; set; }
    }
}

