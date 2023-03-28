using CityAttraction.Cities;

namespace CityAttraction.Attractions
{
    public class AttractionMethods
    {
        public static void ConsoleWriteAttractions(List<Attraction> attractions, City city)
        {
            Console.WriteLine("\n   Attractions: ");
            Console.WriteLine("____________________________________");

            foreach (var attraction in attractions)
            {
                if (attraction.City == city.Name)
                {
                    Console.WriteLine($"{attraction} - {attraction.Description}");
                }
            }
        }
    }
}