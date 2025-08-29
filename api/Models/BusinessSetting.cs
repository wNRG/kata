using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kata.api.Models
{
    public class BusinessSetting
    {
        [Key]
        public Guid SettingID { get; set; }

        [Required]
        public Guid BusinessID { get; set; }

        [ForeignKey("BusinessID")]
        public Business Business { get; set; }

        [Required, MaxLength(100)]
        public string SettingKey { get; set; } = string.Empty;

        [Required, MaxLength(500)]
        public string SettingValue { get; set; } = string.Empty;

        [MaxLength(255)]
        public string? Description { get; set; }

        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}