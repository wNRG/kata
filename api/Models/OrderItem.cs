using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kata.api.Models
{
    public class OrderItem
    {
        [Key]
        public Guid OrderItemID { get; set; }

        [Required]
        public Guid OrderID { get; set; }

        [ForeignKey("OrderID")]
        public Order Order { get; set; }

        [Required]
        public Guid ProductID { get; set; }

        [ForeignKey("ProductID")]
        public Product Product { get; set; }

        [Required]
        public decimal Quantity { get; set; }

        [Required]
        public decimal UnitPrice { get; set; }

        public decimal LineDiscount { get; set; } = 0;
        public decimal LineTotal { get; set; }
        public decimal VATRate { get; set; } = 0.12M;
        public decimal VATAmount { get; set; } = 0;
    }
}