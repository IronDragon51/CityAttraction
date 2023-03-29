using CityAttraction.Attractions.Museums;
using FluentAssertions;

namespace CityAttraction.Tests.Tests
{
    public class JewleryTests
    {
        [Fact]
        public void PrintsAllJewleries_AccordingToRequirements_ForBudapest()
        {
            TextWriter stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            List<Museum> museums = Museum.FillMuseums();

            MuseumMethods.ConsoleWriteMuseums(museums, "Budapest");

            var output = stringWriter.ToString();

            output.Should().Contain("Shine", "Hungary", "1911", "St. Peter");
        }
    }
}