using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kata.api.Models
{
    public class StatementOfAccount
    {
        [Key]
        public Guid SOAID { get; set; }

        [Required]
        public Guid BusinessID { get; set; }

        [ForeignKey("BusinessID")]
        public Business Business { get; set; }

        [Required]
        public Guid CustomerID { get; set; }

        [ForeignKey("CustomerID")]
        public Customer Customer { get; set; }

        [Required, MaxLength(50)]
        public string StatementNumber { get; set; } = string.Empty;

        public DateTime StatementDate { get; set; } = DateTime.UtcNow;
        public DateTime PeriodFrom { get; set; }
        public DateTime PeriodTo { get; set; }

        public decimal PreviousBalance { get; set; } = 0;
        public decimal CurrentCharges { get; set; } = 0;
        public decimal PaymentsReceived { get; set; } = 0;
        public decimal CurrentBalance { get; set; } = 0;

        [MaxLength(1000)]
        public string? Notes { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}