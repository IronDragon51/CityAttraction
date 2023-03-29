namespace CityAttraction.Cities
{
    public class City
    {
        private const string _budapest = "Budapest";
        private const string _saoPaulo = "Sao Paulo";
        private const string _sydney = "Sydney";

        public string? Name { get; set; }
        public string? Description { get; set; }

        public static List<City> FillCities()
        {
            List<City> cities = new()
            {
                new City { Name = _budapest, Description = $"{_budapest} is the capital and largest city of Hungary, located in the heart of Europe" },
                new City { Name = _saoPaulo, Description = $"{_saoPaulo} is the largest city in Brazil and the economic powerhouse of the country" },
                new City { Name = _sydney, Description = $"{_sydney} is Australia's largest and most populous city, known for its iconic landmarks such as the Sydney Opera House" }
            };

            return cities;
        }
    }


}