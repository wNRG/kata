using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kata.api.Models
{
    public class Payment
    {
        [Key]
        public Guid PaymentID { get; set; }

        [Required]
        public Guid InvoiceID { get; set; }

        [ForeignKey("InvoiceID")]
        public Invoice Invoice { get; set; }

        [Required]
        public Guid PaymentMethodID { get; set; }

        [ForeignKey("PaymentMethodID")]
        public PaymentMethod PaymentMethod { get; set; }

        [Required]
        public decimal PaymentAmount { get; set; }

        public DateTime PaymentDate { get; set; } = DateTime.UtcNow;

        [MaxLength(100)]
        public string? ReferenceNumber { get; set; }

        [MaxLength(500)]
        public string? Notes { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}