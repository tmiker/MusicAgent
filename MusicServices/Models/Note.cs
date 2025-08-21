namespace MusicServices.Models
{
    public class Note : IComparable<Note>, IEquatable<Note>
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public int Position { get; set; }  // Position from root in a scale or chord

        public Note Clone() => new Note() { Id = Id, Name = Name, Position = Position };

        public override string ToString()
        {
            return $"Note Name: {Name}, Position: {Position}";
        }

        public int CompareTo(Note? other)
        {
            if (other is null) return 1;
            return Name.CompareTo(other.Name);
        }

        public bool Equals(Note? other)
        {
            if (other is null) return false;
            return Name == other.Name;
        }

        public override bool Equals(object? obj)
        {
            if (obj is Note note)
            {
                return Equals(note);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name);
        }

        public static bool operator < (Note left, Note right) => left.CompareTo(right) < 0;
        public static bool operator > (Note left, Note right) => left.CompareTo(right) > 0;
        public static bool operator <= (Note left, Note right) => left.CompareTo(right) <= 0;
        public static bool operator >= (Note left, Note right) => left.CompareTo(right) >= 0;
    }
}
