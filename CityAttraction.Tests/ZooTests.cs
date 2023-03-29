using CityAttraction.Attractions.Zoos;
using CityAttraction.Attractions.Zoos.Animals;
using Moq;

namespace CityAttraction.Tests.Tests
{
    public class ZooTests
    {
        private const string _budapest = "Budapest";
        private const string _saoPaulo = "Sao Paulo";
        private const string _sydney = "Sydney";

        [Fact]
        public void PrintsAllAnimals()
        {
            //Arrange
            Mock<Zoo> mockZoos = new();
            List<Animal> animals = new(mockZoos.Object.Animals);

            List<Zoo> expectedZoos = new()
            {
                new Zoo
                {
                    City = _budapest,
                    Name = "Double Zoo",
                    Type = "Zoo",
                    Description = "Zoo Budapest",
                    Animals = new List<Animal>()
                    {
                        new Fish
                        {
                            FirstName = "Billy",
                            Sex = Sex.Male,
                            Age = 1,
                            Water = Water.Salty,
                            OriginalZoo = "Zoo1"
                        }
                    }
                },
                new Zoo
                {
                    City = _budapest,
                    Name = "Double Zoo",
                    Type = "Zoo",
                    Description = "Zoo Budapest",
                        Animals = new List<Animal>()
                        {
                            new Mammal
                            {
                                FirstName = "Thomas",
                                Sex = Sex.Female,
                                Age = 22,
                                LifeExpectancy = 44,
                                OriginalZoo = "Zoo1"
                            }
                        }
                },
                new Zoo
                {
                    City = _saoPaulo,
                    Name = "All Animals Zoo",
                    Type = "Zoo",
                    Description = "Zoo Budapest",
                        Animals = new List<Animal>()
                        {
                            new Reptile
                            {
                                FirstName = "Joe",
                                Sex = Sex.Male,
                                Age = 4,
                                FavoriteFood = "cucumber",
                                OriginalZoo = "Zoo1"
                            },
                            new Fish
                            {
                                FirstName = "Zoz",
                                Sex = Sex.Female,
                                Age = 3,
                                Water = Water.Freshwater,
                                OriginalZoo = "Zoo1"
                            },
                            new Mammal
                            {
                                FirstName = "Bill",
                                Sex = Sex.Female,
                                Age = 22,
                                LifeExpectancy = 44,
                                OriginalZoo = "Zoo1"
                            },
                        },
                },
                new Zoo
                {
                    City = _sydney,
                    Name = "Guest Zoo",
                    Type = "Zoo",
                    Description = "Zoo Budapest",
                        Animals = new List<Animal>()
                        {
                            new Fish
                            {
                                FirstName = "Gill",
                                Sex = Sex.Female,
                                Age = 2,
                                Water=Water.Freshwater,
                                IsGuest = true,
                                OriginalZoo = "MokaZoo"
                            }
                        }
                }
            };

            mockZoos.Setup(x => Zoo.FillZoos()).Returns(expectedZoos);

            //Act
            List<Zoo> actual = Zoo.FillZoos();

            //Assert
            //actual.Should().BeEquivalentTo(expectedZoos);
            Assert.Equal(expectedZoos, actual);
        }

        //[Theory]
        //[InlineData("Budapest", "Sao Paulo", "Sydney")]
        //public void PrintsAllAnimals(string budapest, string sao, string sydney)
        //{
        //    Mock<Animal> mockAnimals = new Mock<Animal>();
        //    Mock<Zoo> mockZoos = new Mock<Zoo>();

        //    mockZoos = Zoo.FillZoos();

        //    List<string> shouldContain = new();

        //    foreach (Zoo zoo in zoos)
        //    {
        //        foreach (var animal in zoo.Animals)
        //        {
        //            shouldContain.Add(animal.FirstName);
        //        }
        //    }

        //    //string? output = GetAllAnimals(budapest, sao, sydney);
        //    //output.Should().ContainAll(shouldContain);
        //}

        //[Theory]
        //[InlineData("Budapest", "Sao Paulo", "Sydney")]
        //public void PrintsAllAnimals(string budapest, string sao, string sydney)
        //{
        //    List<Zoo> zoos = Zoo.FillZoos();
        //    List<string> shouldContain = new();

        //    foreach (Zoo zoo in zoos)
        //    {
        //        foreach (var animal in zoo.Animals)
        //        {
        //            shouldContain.Add(animal.FirstName);
        //        }
        //    }

        //    string? output = GetAllAnimals(budapest, sao, sydney);
        //    output.Should().ContainAll(shouldContain);
        //}


        public static string? GetAllAnimals(string budapest, string sao, string sydney)
        {
            TextWriter stringWriter = new StringWriter();
            List<Zoo> zoos = Zoo.FillZoos();
            Console.SetOut(stringWriter);

            ZooMethods.ConsoleWriteZoos(zoos, budapest);
            ZooMethods.ConsoleWriteZoos(zoos, sao);
            ZooMethods.ConsoleWriteZoos(zoos, sydney);

            return stringWriter.ToString();
        }
    }
}