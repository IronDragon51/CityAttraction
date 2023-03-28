namespace CityAttraction.Attractions.Zoos
{
    public class ZooMethods
    {
        public static void ConsoleWriteZoos(List<Zoo> zoos, string city)
        {
            Console.WriteLine("____________________________________");
            Console.WriteLine("\nAnimals in this city's Zoo(s):");
            foreach (var zoo in zoos)
            {
                if (zoo.City == city)
                {
                    foreach (var animal in zoo.Animals)
                    {
                        Console.WriteLine(animal);
                        if (animal.IsGuest)
                        {
                            Console.WriteLine($" --- This animal is a guest, originally from {animal.OriginalZoo}\n");
                        }
                    }
                }
            }
        }
    }
}
