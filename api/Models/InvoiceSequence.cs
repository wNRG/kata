using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kata.api.Models
{
    public class InvoiceSequence
    {
        [Key]
        public Guid SequenceID { get; set; }

        [Required]
        public Guid BusinessID { get; set; }

        [ForeignKey("BusinessID")]
        public Business Business { get; set; }

        [Required, MaxLength(20)]
        public string InvoiceType { get; set; } = string.Empty;

        [MaxLength(10)]
        public string? Prefix { get; set; }

        public int CurrentNumber { get; set; } = 1;

        [MaxLength(10)]
        public string? Suffix { get; set; }

        public int PadLength { get; set; } = 6;
    }
}