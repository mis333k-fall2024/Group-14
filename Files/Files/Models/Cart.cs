using System.Collections.Generic;

namespace Files.Models
{
    public class Cart
    {
        public int CartId { get; set; }

        public List<Reservation> Reservations { get; set; } = new List<Reservation>();

        public string UserId { get; set; } // Foreign key for User
    }
}
