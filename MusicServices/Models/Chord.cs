using System.Text;

namespace MusicServices.Models
{
    public class Chord : IComparable<Chord>, IEquatable<Chord>
    {
        // public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string RootNoteName { get; set; } = default!;
        public string ChordType { get; set; } = default!;
        public List<NoteInterval> ChordNotes { get; set; } = new List<NoteInterval>();

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

        public int CompareTo(Chord? other)
        {
            if (other is null) return 1; // null is less than any instance
            int rootNoteComparison = string.Compare(RootNoteName, other.RootNoteName, StringComparison.OrdinalIgnoreCase);
            if (rootNoteComparison != 0) return rootNoteComparison; // compare by root note name first
            int chordTypeComparison = string.Compare(ChordType, other.ChordType, StringComparison.OrdinalIgnoreCase);
            if (chordTypeComparison != 0) return chordTypeComparison; // compare by chord type
            return 0;
        }

        public static bool operator > (Chord? c1, Chord? c2) => c1?.CompareTo(c2) > 0;
        public static bool operator < (Chord? c1, Chord? c2) => c1?.CompareTo(c2) < 0;
        public static bool operator >= (Chord? c1, Chord? c2) => c1?.CompareTo(c2) >= 0;
        public static bool operator <= (Chord? c1, Chord? c2) => c1?.CompareTo(c2) <= 0;

        public bool Equals(Chord? other)
        {
            if (other is null) return false;
            return RootNoteName.Equals(other.RootNoteName, StringComparison.OrdinalIgnoreCase) &&
                   ChordType.Equals(other.ChordType, StringComparison.OrdinalIgnoreCase);
        }

        public override bool Equals(object? obj)
        {
            if (obj is Chord otherChord)
            {
                return Equals(otherChord);
            }
            return false;
        }

        public override int GetHashCode()
        {
            // Use a simple hash code combining the root note and chord type
            return HashCode.Combine(RootNoteName.ToLowerInvariant(), ChordType.ToLowerInvariant());
        }
    }
}
