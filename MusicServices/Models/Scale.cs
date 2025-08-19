using System.Text;

namespace MusicServices.Models
{
    public class Scale : IComparable<Scale>, IEquatable<Scale>
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

        public int CompareTo(Scale? other)
        {
            if (other is null) return 1;
            if (Name == other.Name && RootNoteName == other.RootNoteName && ScaleType == other.ScaleType && ScaleNotes == other.ScaleNotes) return 0;
            return string.Compare(RootNoteName, other.RootNoteName, StringComparison.Ordinal);
        }

        public bool Equals(Scale? other)
        {
            if (other is null) return false;
            return Name == other.Name && RootNoteName == other.RootNoteName && ScaleType == other.ScaleType && ScaleNotes.SequenceEqual(other.ScaleNotes);
        }

        public override bool Equals(object? obj)
        {
            if (obj is Scale scale)
            {
                return Equals(scale);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, RootNoteName, ScaleType);
        }

        public static bool operator < (Scale left, Scale right) => left.CompareTo(right) < 0;
        public static bool operator > (Scale left, Scale right) => left.CompareTo(right) > 0;
        public static bool operator <= (Scale left, Scale right) => left.CompareTo(right) <= 0;
        public static bool operator >= (Scale left, Scale right) => left.CompareTo(right) >= 0;
    }
}
