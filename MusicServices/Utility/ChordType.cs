using MusicServices.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicServices.Utility
{
    public class ChordType
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Chord Type")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string? Name { get; set; }

        public string? Symbol { get; set; }

        public byte[]? Image { get; set; }

        public string? Sound { get; set; }

        public string? ThirdsSignature { get; set; }

        public string? Description { get; set; }


    }
}
