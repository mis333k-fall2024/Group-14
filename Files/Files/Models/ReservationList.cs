using System.Collections.Generic;
using System.Linq;

namespace Files.Models
{
    public class ReservationList
    {
        public List<Reservation> Reservations { get; set; } = new List<Reservation>();

        public decimal TotalPrice
        {
            get
            {
                return Reservations.Sum(r => r.CalculateStayPrice() + r.CleaningFee);
            }
        }
    }
}
