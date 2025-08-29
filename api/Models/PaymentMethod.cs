using System;
using System.ComponentModel.DataAnnotations;

namespace kata.api.Models
{
    public class PaymentMethod
    {
        [Key]
        public Guid PaymentMethodID { get; set; }

        [Required, MaxLength(50)]
        public string MethodName { get; set; } = string.Empty;

        [MaxLength(255)]
        public string? Description { get; set; }

        public bool RequiresReference { get; set; } = false;
        public bool IsActive { get; set; } = true;
    }
}