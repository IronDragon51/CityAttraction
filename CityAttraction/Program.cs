using CityAttraction.Attractions;
using CityAttraction.Attractions.Churches;
using CityAttraction.Attractions.Museums;
using CityAttraction.Attractions.Zoos;
using CityAttraction.Cities;
using CityAttraction.Data;

namespace CityAttraction
{
    public class Program
    {
        public static void Main()
        {
            Fill.FillLists(out List<City> cities, out List<Attraction> attractions, out List<Zoo> zoos, out List<Museum> museums, out List<Church> churches);

            string choosenCity = "";
            while (choosenCity != "")
            {
                choosenCity = CityMethods.ChooseCity(cities);
            }
            CityMethods.ShowCityDescription(cities, attractions, choosenCity, zoos, museums, churches);
        }
    }
}