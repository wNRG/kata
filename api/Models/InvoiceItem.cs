using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kata.api.Models
{
    public class InvoiceItem
    {
        [Key]
        public Guid InvoiceItemID { get; set; }

        [Required]
        public Guid InvoiceID { get; set; }

        [ForeignKey("InvoiceID")]
        public Invoice Invoice { get; set; }

        [Required]
        public Guid ProductID { get; set; }

        [ForeignKey("ProductID")]
        public Product Product { get; set; }

        [Required, MaxLength(500)]
        public string ItemDescription { get; set; } = string.Empty;

        [Required]
        public decimal Quantity { get; set; }

        [Required]
        public decimal UnitPrice { get; set; }

        [Required]
        public decimal Amount { get; set; }

        public decimal VATRate { get; set; } = 0.12M;
        public decimal VATAmount { get; set; } = 0;
        public bool IsVATExempt { get; set; } = false;
    }
}