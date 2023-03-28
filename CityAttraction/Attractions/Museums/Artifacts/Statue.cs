namespace CityAttraction.Attractions.Museums.Artifacts
{
    public class Statue : Artifact
    {
        public required string MadeOf { get; set; }
        public override string ToString()
        {
            return $"Name: {Name}  |  Found here: {FindPlace}  |  In: {FindWhen}  |  Made of: {MadeOf}";
        }
    }
}
