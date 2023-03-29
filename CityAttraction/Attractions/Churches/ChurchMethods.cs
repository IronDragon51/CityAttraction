namespace CityAttraction.Attractions.Churches
{
    public class ChurchMethods
    {
        private const string _budapest = "Budapest";
        private const string _saoPaulo = "Sao Paulo";
        private const string _sydney = "Sydney";

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

        public static List<Church> FillChurches()
        {
            List<Church> churches = new()
            {
                new Church
                {
                    City = _budapest,
                    Style = "Christian",
                    StyleDetails = "Christian architecture and design were the great churches of Byzantium, the Romanesque abbey churches, Gothic cathedrals and Renaissance basilicas with its emphasis on harmony. These large, often ornate and architecturally prestigious buildings were dominant features of the towns and countryside in which they stood",
                    Builder = "John F",
                    Religion = "Christian"
                },
                new Church
                {
                    City = _budapest,
                    Style = "Oriental Orthodoxy",
                    StyleDetails = "The Oriental Orthodox Churches are Eastern Christian churches adhering to Miaphysite Christology,with approximately 60 million members worldwide.The Oriental Orthodox Churches are part of the Nicene Christian tradition, and represent one of its oldest branches.",
                    Builder = "Bob B",
                    Religion = "Orthodox"
                },
                new Church{
                    City = _saoPaulo,
                    Style = "Christian",
                    StyleDetails = "Christian architecture and design were the great churches of Byzantium, the Romanesque abbey churches, Gothic cathedrals and Renaissance basilicas with its emphasis on harmony. These large, often ornate and architecturally prestigious buildings were dominant features of the towns and countryside in which they stood",
                    Builder = "Marie Po",
                    Religion = "Christian"
                },
                new Church{
                    City = _sydney,
                    Style = "Christian",
                    StyleDetails = "Christian architecture and design were the great churches of Byzantium, the Romanesque abbey churches, Gothic cathedrals and Renaissance basilicas with its emphasis on harmony. These large, often ornate and architecturally prestigious buildings were dominant features of the towns and countryside in which they stood",
                    Builder = "Yzi Su",
                    Religion = "Christian"
                }
            };

            return churches;
        }
    }
}
