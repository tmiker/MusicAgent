namespace MusicServices.Models
{
    public class Interval
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

    }
}
