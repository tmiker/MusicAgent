namespace MusicServices.Models
{
    public class ScaleType
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public string? Symbol { get; set; }

        public byte[]? Image { get; set; }

        public string? Sound { get; set; }

        public string? Description { get; set; }

        public string? IntervalSignature { get; set; }

    }

}
