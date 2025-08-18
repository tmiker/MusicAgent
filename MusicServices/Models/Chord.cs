using System.Text;

namespace MusicServices.Models
{
    public class Chord
    {
        // public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string RootNoteName { get; set; } = default!;
        public string ChordType { get; set; } = default!;
        public List<ChordNote> ChordNotes { get; set; } = new List<ChordNote>();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Chord Name: {Name}, Root Note: {RootNoteName}, Chord Type: {ChordType}:");
            foreach (var note in ChordNotes)
            {
                sb.AppendLine($"    {note.Interval}, {note.Note}");
            }
            return sb.ToString();
        }
    }
}
