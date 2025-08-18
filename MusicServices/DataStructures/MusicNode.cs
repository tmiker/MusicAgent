using MusicServices.Models;

namespace MusicServices.DataStructures
{
    public class MusicNode
    {
        public Interval Interval { get; set; } = default!;
        public Note Note { get; set; } = default!;
        public MusicNode? Previous { get; set; }
        public MusicNode? Next { get; set; }

        public override string ToString()
        {
            return $"Node {Interval}, {Note}";
        }
    }
}
