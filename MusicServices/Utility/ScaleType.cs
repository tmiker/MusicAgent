using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicServices.Utility
{
    public class ScaleType
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ScaleType")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string? Name { get; set; }

        public string? Symbol { get; set; }

        public byte[]? Image { get; set; }

        public string? Sound { get; set; }

        public string? Description { get; set; }

        public string? IntervalSignature { get; set; }

    }

}
