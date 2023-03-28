using CityAttraction.Attractions.Museums.Artifacts;

namespace CityAttraction.Attractions.Museums
{
    public class Museum : Attraction
    {
        public required IReadOnlyList<Artifact> Artifacts { get; init; }
    }
}