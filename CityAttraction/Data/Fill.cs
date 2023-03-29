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
            cities = City.FillCities();
            attractions = Attraction.FillAttractions();
            zoos = Zoo.FillZoos();
            museums = Museum.FillMuseums();
            churches = ChurchMethods.FillChurches(); //other class
        }
    }
}