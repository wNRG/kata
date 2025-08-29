using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kata.api.Models
{
    public class Customer
    {
        [Key]
        public Guid CustomerID { get; set; }

        [Required]
        public Guid BusinessID { get; set; }

        [ForeignKey("BusinessID")]
        public Business Business { get; set; }

        [MaxLength(20)]
        public string? TIN { get; set; }
         
        [Required, MaxLength(20)]
        public string CustomerType { get; set; } = "Individual";

        [Required, MaxLength(255)]
        public string RegisteredName { get; set; } = string.Empty;

        [MaxLength(500)]
        public string? BusinessAddress { get; set; }

        [MaxLength(20)]
        public string? ContactNumber { get; set; }

        [MaxLength(255)]
        public string? EmailAddress { get; set; }

        [MaxLength(255)]
        public string? ContactPerson { get; set; }

        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}