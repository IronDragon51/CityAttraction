namespace CityAttraction.Attractions
{
    public class Attraction
    {
        private const string _budapest = "Budapest";
        private const string _saoPaulo = "Sao Paulo";
        private const string _sydney = "Sydney";

        public string? City { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; }
        public string? Description { get; set; }

        public override string ToString()
        {
            return $"{Name} ({Type})";
        }

        public static List<Attraction> FillAttractions()
        {
            List<Attraction> attractions = new()
            {
                new Attraction { City = _budapest, Name = $"Parliament", Type = "Building", Description = "The seat of the National Assembly of Hungary"},
                new Attraction { City = _budapest, Name = $"Heroes' Square", Type = "Statue", Description = "Iconic Millennium Monument with statues featuring the Seven chieftains of the Magyars and other important Hungarian national leaders"},
                new Attraction { City = _saoPaulo, Name = $"Ibirapuera", Type = "Park", Description = "Ibirapuera Park was the first metropolitan park in São Paulo"},
                new Attraction { City = _saoPaulo, Name = $"São Paulo Museum of Art", Type = "Museum", Description = "Non-profit institution founded in 1947 by Assis Chateaubriand and Pietro Maria Bardi"},
                new Attraction { City = _sydney, Name = $"Sydney Opera House", Type = "Building", Description = "Multi-venue performing arts centre in Sydney"},
                new Attraction { City = _sydney, Name = $"Darling Harbour", Type = "Harbour", Description = "Originally named Long Cove, the locality extends northwards from Chinatown"}
            };

            return attractions;
        }
    }
}