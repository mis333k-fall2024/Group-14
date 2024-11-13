using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FA24_Group14.Models
{
  public class Transaction
{
    [Key]
    public int TransactionID { get; set; } // Primary Key

    [Required]
    public int PropertyID { get; set; } // Foreign Key to Property

    [Required]
    public int ReservationID { get; set; } // Foreign Key to Reservation

    [Required]
    [Range(0, 100)]
    [Column(TypeName = "decimal(5, 2)")]
    public decimal TaxRate { get; set; } // Tax rate as percentage (e.g., 8.25%)

    [Required]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal GrandTotal { get; set; } // Final amount after tax

    // Navigation Properties
    [ForeignKey(nameof(PropertyID))]
    public virtual Property Property { get; set; } // Link to Property

    [ForeignKey(nameof(ReservationID))]
    public virtual Reservation Reservation { get; set; } // Link to Reservation
}
