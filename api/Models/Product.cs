using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kata.api.Models
{
    public class Product
    {
        [Key]
        public Guid ProductID { get; set; }

        [Required]
        public Guid BusinessID { get; set; }

        [ForeignKey("BusinessID")]
        public Business Business { get; set; }

        [Required, MaxLength(50)]
        public string ProductCode { get; set; } = string.Empty;

        [Required, MaxLength(255)]
        public string ProductName { get; set; } = string.Empty;

        [MaxLength(1000)]
        public string? Description { get; set; }

        [Required, MaxLength(20)]
        public string ProductType { get; set; } = "Product"; // or "Service"

        [Required]
        public decimal UnitPrice { get; set; }

        [MaxLength(20)]
        public string? Unit { get; set; }

        public bool IsVATExempt { get; set; } = false;
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
