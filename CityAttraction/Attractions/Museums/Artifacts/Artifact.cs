namespace CityAttraction.Attractions.Museums.Artifacts
{
    public abstract class Artifact
    {
        public required string Name { get; set; }
        public required string FindPlace { get; set; }
        public required string FindWhen { get; set; }
        public bool IsTemporaryExhibition { get; set; }
        public DateTime OnDisplayTill { get; set; }
    }
}
