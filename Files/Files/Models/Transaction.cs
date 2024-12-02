using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Files.Models
{
    public class Transaction
    {
        public int TransactionId { get; set; }

        [Required]
        public string ConfirmationNumber { get; set; }

        public DateTime TransactionDate { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal Subtotal { get; set; }

        [DataType(DataType.Currency)]
        public decimal Tax { get; set; }

        [DataType(DataType.Currency)]
        public decimal GrandTotal { get; set; }

        public string UserId { get; set; } // Foreign key for User

        public List<Reservation> Reservations { get; set; } = new List<Reservation>();
    }
}
