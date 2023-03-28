namespace CityAttraction.Attractions.Churches
{
    public class ChurchMethods
    {
        public static void ConsoleWriteChurches(List<Church> churches, string city)
        {
            Console.WriteLine("____________________________________");
            Console.WriteLine("\nChurches in this city:\n");
            foreach (var church in churches)
            {
                if (church.City == city)
                {
                    Console.WriteLine("Church's religion: " + church.Religion);
                    Console.WriteLine("Church style: " + church.Style);
                    Console.WriteLine("About this style: " + church.StyleDetails);
                    Console.WriteLine("\tBuilder: " + church.Builder);
                    Console.WriteLine("____________________________________");
                }
            }
        }
    }
}
