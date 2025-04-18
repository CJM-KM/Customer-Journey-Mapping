namespace CustomerJourney.API.Models
{
    public class Touchpoint
    {
        public int Id { get; set; }
        public string Type { get; set; } = null!;
        public string Notes { get; set; } = null!;
    }
}
