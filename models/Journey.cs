namespace CustomerJourney.API.Models
{
    public class Journey
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public Customer Customer { get; set; } = null!;
        public List<Touchpoint> Touchpoints { get; set; } = new List<Touchpoint>();
    }
}
