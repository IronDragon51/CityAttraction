using CityAttraction.Attractions.Zoos.Animals;

namespace CityAttraction.Attractions.Zoos
{
    public class Zoo : Attraction
    {
        public required IReadOnlyList<Animal> Animals { get; init; }
    }
}
