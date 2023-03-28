namespace CityAttraction.Attractions.Museums.Artifacts
{
    public class Jewelry : Artifact
    {
        public required string Whose { get; set; }
        public override string ToString()
        {
            return $"Name: {Name}  |  Found here: {FindPlace}  |  In: {FindWhen}  |  It was {Whose}'s jewelry";
        }
    }
}
