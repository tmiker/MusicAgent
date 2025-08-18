using System.Text;

namespace MusicServices.Models
{
    public class Scale
    {
        public string Name { get; set; } = default!;
        public string RootNoteName { get; set; } = default!;
        public string ScaleType { get; set; } = default!;
        public List<ScaleNote> ScaleNotes { get; set; } = new List<ScaleNote>();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Scale Name: {Name}, Root Note: {RootNoteName}, Scale Type: {ScaleType}:");
            foreach (var note in ScaleNotes)
            {
                sb.AppendLine($"    {note.Interval}, {note.Note}");
            }
            return sb.ToString();
        }
    }
}
