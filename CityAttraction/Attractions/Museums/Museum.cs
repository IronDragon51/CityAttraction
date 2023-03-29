using CityAttraction.Attractions.Museums.Artifacts;

namespace CityAttraction.Attractions.Museums
{
    public class Museum : Attraction
    {
        private const string _budapest = "Budapest";
        private const string _saoPaulo = "Sao Paulo";
        private const string _sydney = "Sydney";

        public required IReadOnlyList<Artifact> Artifacts { get; init; }

        public static List<Museum> FillMuseums()
        {
            List<Museum> museums = new()
            {
                new Museum
                {
                    City = _budapest,
                    Name = "Boo Museum",
                    Type = "Museum",
                    Description = "This museum is..",
                            Artifacts = new List<Artifact>()
                            {
                                new Statue
                                {
                                    Name = "Big Statue",
                                    FindPlace = "New Orleans",
                                    FindWhen = "1331",
                                    MadeOf = "Stone"
                                },
                                new Painting
                                {
                                    Name = "Dogs",
                                    FindPlace = "Amsterdam",
                                    FindWhen = "44 BC",
                                    Style="Abstract"
                                },
                                new Jewelry
                                {
                                    Name = "Shine",
                                    FindPlace = "Hungary",
                                    FindWhen = "1911",
                                    Whose="St. Peter"
                                }
                            }
                },
                new Museum
                {
                    City = _saoPaulo,
                    Name = "XY Museum",
                    Type = "Museum",
                    Description = "This museum is..",
                            Artifacts = new List<Artifact>()
                            {
                                new Statue
                                {
                                    Name = "Big Statue",
                                    FindPlace = "New Orleans",
                                    FindWhen = "1331",
                                    IsTemporaryExhibition = true,
                                    OnDisplayTill = new DateTime(2025, 12, 11),
                                    MadeOf = "Brick"
                                },
                                new Painting
                                {
                                    Name = "Dogs",
                                    FindPlace = "Amsterdam",
                                    FindWhen = "44 BC",
                                    IsTemporaryExhibition = true,
                                    OnDisplayTill = new DateTime(2023, 05, 31),
                                    Style = "Modern"
                                }
                            }
                }
            };

            return museums;
        }


    }
}