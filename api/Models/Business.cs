using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kata.api.Models
{
    public class Business
    {
        [Key]
        public Guid BusinessID { get; set; }

        [Required]
        public Guid UserID { get; set; }

        [ForeignKey("UserID")]
        public User user { get; set; }

        [Required, MaxLength(20)]
        public string TIN { get; set; } = string.Empty;

        [Required, MaxLength(255)]
        public string RegisteredName { get; set; } = string.Empty;

        [Required, MaxLength(500)]
        public string BusinessAddress { get; set; } = string.Empty;

        [MaxLength(20)]
        public string? ContactNumber { get; set; }

        [MaxLength(255)]
        public string? EmailAddress { get; set; }

        [Required, MaxLength(20)]
        public string TaxTytpe { get; set; } = "Non-VAT";

        public bool IsVATRegistered { get; set; } = false;
        public decimal VATRate { get; set; } = 0.12m;

        [MaxLength(100)]
        public string? BusinessType { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}