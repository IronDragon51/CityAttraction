using CityAttraction.Attractions;
using CityAttraction.Attractions.Churches;
using CityAttraction.Attractions.Museums;
using CityAttraction.Attractions.Zoos;

namespace CityAttraction.Cities
{
    public class CityMethods
    {
        public static string ChooseCity(List<City> cities)
        {
            Console.Clear();
            Console.WriteLine("Choose a city:\n" + "Press ESC to exit\n");

            foreach (var city in cities)
            {
                Console.WriteLine(city.Name);
            }

            ConsoleKeyInfo lastKey = Console.ReadKey();
            if (lastKey.Key == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
            else
            {
                string input = lastKey.KeyChar + Console.ReadLine();
                bool cityLikeThisExists = cities.Any(city => city.Name == input);

                if (!cityLikeThisExists)
                {
                    Program.Main();
                }
                return input;
            }

            return "";
        }

        public static void ShowCityDescription(List<City> cities, List<Attraction> attractions, string choosenCity, List<Zoo> zoos, List<Museum> museums, List<Church> churches)
        {
            Console.Clear();
            Console.WriteLine("Press ESC to return to main menu");
            Console.WriteLine("________________________________\n");
            FindCity(cities, attractions, choosenCity, zoos, museums, churches);

            ConsoleKeyInfo lastKey = Console.ReadKey();
            if (lastKey.Key == ConsoleKey.Escape)
            {
                Program.Main();
            }
        }

        public static void FindCity(List<City> cities, List<Attraction> attractions, string choosenCity, List<Zoo> zoos, List<Museum> museums, List<Church> churches)
        {
            bool found = false;
            while (!found)
            {
                foreach (var city in cities)
                {
                    if (city.Name == choosenCity)
                    {
                        Console.WriteLine(city.Description);
                        AttractionMethods.ConsoleWriteAttractions(attractions, city);
                        ZooMethods.ConsoleWriteZoos(zoos, city.Name);
                        MuseumMethods.ConsoleWriteMuseums(museums, city.Name);
                        ChurchMethods.ConsoleWriteChurches(churches, city.Name);
                    }
                }
                found = true;
            }

            if (!found)
            {
                _ = ChooseCity(cities);
            }
        }




    }
}