using CityAttraction.Attractions;
using CityAttraction.Attractions.Churches;
using CityAttraction.Attractions.Museums;
using CityAttraction.Attractions.Zoos;
using CityAttraction.Cities;

namespace CityAttraction.Data
{
    public class Fill
    {
        public static void FillLists(out List<City> cities, out List<Attraction> attractions, out List<Zoo> zoos, out List<Museum> museums, out List<Church> churches)
        {
            cities = ListManager.FillCities();
            attractions = ListManager.FillAttractions();
            zoos = ListManager.FillZoos();
            museums = ListManager.FillMuseums();
            churches = ListManager.FillChurches();
        }
    }
}
