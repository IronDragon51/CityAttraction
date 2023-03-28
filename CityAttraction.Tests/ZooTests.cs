using CityAttraction.Attractions.Zoos;
using CityAttraction.Data;
using FluentAssertions;

namespace CityAttraction.Tests.Tests
{
    public class ZooTests
    {
        [Theory]
        [InlineData("Budapest", "Sao Paulo", "Sydney")]
        public void PrintsAllAnimals(string budapest, string sao, string sydney)
        {
            List<Zoo> zoos = ListManager.FillZoos();
            List<string> shouldContain = new();

            foreach (Zoo zoo in zoos)
            {
                foreach (var animal in zoo.Animals)
                {
                    shouldContain.Add(animal.FirstName);
                }
            }

            string? output = GetAllAnimals(budapest, sao, sydney);
            output.Should().ContainAll(shouldContain);
        }

        public static string? GetAllAnimals(string budapest, string sao, string sydney)
        {
            TextWriter stringWriter = new StringWriter();
            List<Zoo> zoos = ListManager.FillZoos();
            Console.SetOut(stringWriter);

            ZooMethods.ConsoleWriteZoos(zoos, budapest);
            ZooMethods.ConsoleWriteZoos(zoos, sao);
            ZooMethods.ConsoleWriteZoos(zoos, sydney);

            return stringWriter.ToString();
        }
    }
}