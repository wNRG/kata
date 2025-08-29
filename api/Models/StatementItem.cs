using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kata.api.Models
{
    public class StatementItem
    {
        [Key]
        public Guid StatementItemID { get; set; }

        [Required]
        public Guid SOAID { get; set; }

        [ForeignKey("SOAID")]
        public StatementOfAccount StatementOfAccount { get; set; }

        [Required]
        public Guid InvoiceID { get; set; }

        [ForeignKey("InvoiceID")]
        public Invoice Invoice { get; set; }

        [Required]
        public decimal InvoiceAmount { get; set; }

        public decimal PaymentAmount { get; set; } = 0;
        [Required]
        public decimal Balance { get; set; }
    }
}