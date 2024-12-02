using System.Collections.Generic;

namespace Files.Models
{
    public class ReservationList
    {
        public List<Reservation> Reservations { get; set; } = new List<Reservation>();

        public decimal TotalPrice
        {
            get
            {
                decimal total = 0;
                foreach (var reservation in Reservations)
                {
                    total += reservation.CalculateStayPrice();
                }
                return total;
            }
        }
    }
}
