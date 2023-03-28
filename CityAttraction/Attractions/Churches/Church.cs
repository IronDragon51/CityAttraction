namespace CityAttraction.Attractions.Churches
{
    public class Church : Attraction
    {
        public required string Style { get; set; }
        public required string StyleDetails { get; set; }
        public required string Builder { get; set; }
        public required string Religion { get; set; }
    }
}
