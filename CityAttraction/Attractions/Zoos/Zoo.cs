using CityAttraction.Attractions.Zoos.Animals;

namespace CityAttraction.Attractions.Zoos
{
    public class Zoo : Attraction
    {
        private const string _budapest = "Budapest";
        private const string _saoPaulo = "Sao Paulo";
        private const string _sydney = "Sydney";

        public required IReadOnlyList<Animal> Animals { get; init; }

        public static List<Zoo> FillZoos()
        {
            List<Zoo> zoos = new()
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

            return zoos;
        }
    }
}
