namespace CityAttraction.Attractions.Museums
{
    public class MuseumMethods
    {
        public static void ConsoleWriteMuseums(List<Museum> museums, string city)
        {
            Console.WriteLine("____________________________________");
            Console.WriteLine("\nArtifacts in this city's Museum(s):");
            foreach (var museum in museums)
            {
                if (museum.City == city)
                {
                    foreach (var artifact in museum.Artifacts)
                    {
                        Console.WriteLine(artifact);
                        if (artifact.IsTemporaryExhibition)
                        {
                            Console.WriteLine($" --- This artifact is for limited time only, till: {artifact.OnDisplayTill}\n");
                        }
                    }
                }
            }
        }
    }
}
