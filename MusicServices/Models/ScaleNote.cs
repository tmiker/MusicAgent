namespace MusicServices.Models
{
    public class ScaleNote
    {
        public Interval Interval { get; set; } = default!;
        public Note Note { get; set; } = default!;
    }
}
