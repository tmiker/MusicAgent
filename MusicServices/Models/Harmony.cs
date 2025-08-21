using System.Text;

namespace MusicServices.Models
{
    public class Harmony
    {
        public int Id { get; set; }
        public string ScaleType { get; set; } = default!;
        public string KeyNote { get; set; } = default!;
        public string Name { get; set; } = default!;
        public string Signature { get; set; } = default!;
        public ICollection<Chord> Chords { get; set; } = new List<Chord>();

        
    }
}
