namespace MusicServices.Models
{
    public class ScaleNote : IComparable<ScaleNote>, IEquatable<ScaleNote>
    {
        public Interval Interval { get; set; } = default!;
        public Note Note { get; set; } = default!;

        public int CompareTo(ScaleNote? other)
        {
            if (other is null) return 1;
            int intervalComparison = Interval.Name.CompareTo(other.Interval.Name);   // for brevity since immutable vs comparing entire object
            if (intervalComparison != 0) return intervalComparison;
            return Note.CompareTo(other.Note);
        }
        public bool Equals(ScaleNote? other)
        {
            if (other is null) return false;
            return Interval.Equals(other.Interval) && Note.Equals(other.Note);
        }
        public override bool Equals(object? obj)
        {
            if (obj is ScaleNote scaleNote)
            {
                return Equals(scaleNote);
            }
            return false;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Interval, Note);
        }
        public static bool operator <(ScaleNote left, ScaleNote right) => left.CompareTo(right) < 0;
        public static bool operator >(ScaleNote left, ScaleNote right) => left.CompareTo(right) > 0;
        public static bool operator <=(ScaleNote left, ScaleNote right) => left.CompareTo(right) <= 0;
        public static bool operator >=(ScaleNote left, ScaleNote right) => left.CompareTo(right) >= 0;
    }
}
