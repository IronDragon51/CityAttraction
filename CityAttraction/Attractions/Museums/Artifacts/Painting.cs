namespace CityAttraction.Attractions.Museums.Artifacts
{
    public class Painting : Artifact
    {
        public required string Style { get; set; }
        public override string ToString()
        {
            return $"Name: {Name}  |  Found here: {FindPlace}  |  In: {FindWhen}  |  Style: {Style}";
        }

    }
}
