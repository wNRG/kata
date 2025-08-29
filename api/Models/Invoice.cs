using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kata.api.Models
{
    public class Invoice
    {
        [Key]
        public Guid InvoiceID { get; set; }

        [Required]
        public Guid BusinessID { get; set; }

        [ForeignKey("BusinessID")]
        public Business Business { get; set; }

        [Required]
        public Guid CustomerID { get; set; }

        [ForeignKey("CustomerID")]
        public Customer Customer { get; set; }

        public Guid? OrderID { get; set; }

        [ForeignKey("OrderID")]
        public Order Order { get; set; }

        [Required, MaxLength(50)]
        public string InvoiceNumber { get; set; } = string.Empty;

        [Required, MaxLength(20)]
        public string InvoiceType { get; set; } = "Sales Invoice";

        [Required, MaxLength(20)]
        public string SalesType { get; set; } = "Cash Sales";

        public DateTime InvoiceDate { get; set; } = DateTime.UtcNow;
        public DateTime? DueDate { get; set; }

        public decimal SubTotal { get; set; } = 0;
        public decimal VATableSales { get; set; } = 0;
        public decimal VATAmount { get; set; } = 0;
        public decimal ZeroRatedSales { get; set; } = 0;
        public decimal VATExemptSales { get; set; } = 0;
        public decimal TotalSales { get; set; } = 0;
        public decimal LessVAT { get; set; } = 0;
        public decimal AmountNetOfVAT { get; set; } = 0;
        public decimal LessDiscount { get; set; } = 0;
        public decimal AddVAT { get; set; } = 0;
        public decimal LessWithholdingTax { get; set; } = 0;
        public decimal TotalAmountDue { get; set; } = 0;

        public decimal PaidAmount { get; set; } = 0;
        public decimal Balance { get; set; } = 0;

        [MaxLength(20)]
        public string PaymentStatus { get; set; } = "Unpaid";

        [MaxLength(20)]
        public string Status { get; set; } = "Draft";

        [MaxLength(1000)]
        public string? Notes { get; set; }

        public bool IsPrinted { get; set; } = false;
        public DateTime? PrintedAt { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}