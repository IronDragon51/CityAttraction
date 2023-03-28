namespace CityAttraction.Attractions
{
    public class Attraction
    {
        public string? City { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; }
        public string? Description { get; set; }

        public override string ToString()
        {
            return $"{Name} ({Type})";
        }
    }
}