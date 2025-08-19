namespace MusicServices.Models
{
    public class Interval : IComparable<Interval>, IEquatable<Interval>
    {
        public string Name { get; set; } = default!;
        public int SemiTones { get; set; }
        public string? FullName { get; set; }
        public string? Symbol { get; set; }
        public string? Degree { get; set; }

        public override string ToString()
        {
            return $"Interval Name: {Name}, Semitones: {SemiTones}, Symbol: {Symbol}";
        }

        public int CompareTo(Interval? other)
        {
            if (other is null) return 1; 
            return SemiTones.CompareTo(other.SemiTones);
        }

        public bool Equals(Interval? other)
        {
            if (other is null) return false;
            return SemiTones == other.SemiTones && Name == other.Name && FullName == other.FullName && Symbol == other.Symbol && Degree == other.Degree;
        }

        public override bool Equals(object? obj)
        {
            if (obj is Interval interval)
            {
                return Equals(interval);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, SemiTones, FullName, Symbol, Degree);
        }

        public static bool operator  < (Interval left, Interval right) => left.CompareTo(right) < 0;
        public static bool operator > (Interval left, Interval right) => left.CompareTo(right) > 0;
        public static bool operator <= (Interval left, Interval right) => left.CompareTo(right) <= 0;
        public static bool operator >= (Interval left, Interval right) => left.CompareTo(right) >= 0;
    }
}
