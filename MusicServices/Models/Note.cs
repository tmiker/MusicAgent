namespace MusicServices.Models
{
    public class Note
    {
        public string Name { get; set; } = default!;
        public int Position { get; set; }
        // public double Frequency { get; set; }

        public override string ToString()
        {
            return $"Note Name: {Name}, Position: {Position}";
        }
    }
}
