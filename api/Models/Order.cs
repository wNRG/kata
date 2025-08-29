using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kata.api.Models
{
    public class Order
    {
        [Key]
        public Guid OrderID { get; set; }

        [Required]
        public Guid BusinessID { get; set; }

        [ForeignKey("BusinessID")]
        public Business Business { get; set; }

        public Guid? CustomerID { get; set; }

        [ForeignKey("CustomerID")]
        public Customer Customer { get; set; }

        [Required, MaxLength(50)]
        public string OrderNumber { get; set; } = string.Empty;

        [Required, MaxLength(20)]
        public string OrderType { get; set; } = "Sales Order"; // or "Purchase Order"

        public DateTime OrderDate { get; set; } = DateTime.UtcNow;

        [MaxLength(20)]
        public string Status { get; set; } = "Pending";

        public decimal SubTotal { get; set; } = 0;
        public decimal TotalDiscount { get; set; } = 0;
        public decimal VATAmount { get; set; } = 0;
        public decimal TotalAmount { get; set; } = 0;

        [MaxLength(1000)]
        public string? Notes { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}