namespace CityAttraction.Attractions.Churches
{
    public class Church : Attraction
    {
        private const string _budapest = "Budapest";
        private const string _saoPaulo = "Sao Paulo";
        private const string _sydney = "Sydney";

        public required string Style { get; set; }
        public required string StyleDetails { get; set; }
        public required string Builder { get; set; }
        public required string Religion { get; set; }
    }
}
