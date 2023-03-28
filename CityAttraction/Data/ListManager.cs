using CityAttraction.Attractions;
using CityAttraction.Attractions.Churches;
using CityAttraction.Attractions.Museums;
using CityAttraction.Attractions.Museums.Artifacts;
using CityAttraction.Attractions.Zoos;
using CityAttraction.Attractions.Zoos.Animals;
using CityAttraction.Cities;

namespace CityAttraction.Data
{
    public class ListManager
    {
        private const string _budapest = "Budapest";
        private const string _saoPaulo = "Sao Paulo";
        private const string _sydney = "Sydney";

        public static List<City> FillCities()
        {
            List<City> cities = new()
            {
                new City { Name = _budapest, Description = $"{_budapest} is the capital and largest city of Hungary, located in the heart of Europe" },
                new City { Name = _saoPaulo, Description = $"{_saoPaulo} is the largest city in Brazil and the economic powerhouse of the country" },
                new City { Name = _sydney, Description = $"{_sydney} is Australia's largest and most populous city, known for its iconic landmarks such as the Sydney Opera House" }
            };

            return cities;
        }

        public static List<Attraction> FillAttractions()
        {
            List<Attraction> attractions = new()
            {
                new Attraction { City = _budapest, Name = $"Parliament", Type = "Building", Description = "The seat of the National Assembly of Hungary"},
                new Attraction { City = _budapest, Name = $"Heroes' Square", Type = "Statue", Description = "Iconic Millennium Monument with statues featuring the Seven chieftains of the Magyars and other important Hungarian national leaders"},
                new Attraction { City = _saoPaulo, Name = $"Ibirapuera", Type = "Park", Description = "Ibirapuera Park was the first metropolitan park in São Paulo"},
                new Attraction { City = _saoPaulo, Name = $"São Paulo Museum of Art", Type = "Museum", Description = "Non-profit institution founded in 1947 by Assis Chateaubriand and Pietro Maria Bardi"},
                new Attraction { City = _sydney, Name = $"Sydney Opera House", Type = "Building", Description = "Multi-venue performing arts centre in Sydney"},
                new Attraction { City = _sydney, Name = $"Darling Harbour", Type = "Harbour", Description = "Originally named Long Cove, the locality extends northwards from Chinatown"}
            };

            return attractions;
        }

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


        public static List<Museum> FillMuseums()
        {
            List<Museum> museums = new()
            {
                new Museum
                {
                    City = _budapest,
                    Name = "Boo Museum",
                    Type = "Museum",
                    Description = "This museum is..",
                            Artifacts = new List<Artifact>()
                            {
                                new Statue
                                {
                                    Name = "Big Statue",
                                    FindPlace = "New Orleans",
                                    FindWhen = "1331",
                                    MadeOf = "Stone"
                                },
                                new Painting
                                {
                                    Name = "Dogs",
                                    FindPlace = "Amsterdam",
                                    FindWhen = "44 BC",
                                    Style="Abstract"
                                },
                                new Jewelry
                                {
                                    Name = "Shine",
                                    FindPlace = "Hungary",
                                    FindWhen = "1911",
                                    Whose="St. Peter"
                                }
                            }
                },
                new Museum
                {
                    City = _saoPaulo,
                    Name = "XY Museum",
                    Type = "Museum",
                    Description = "This museum is..",
                            Artifacts = new List<Artifact>()
                            {
                                new Statue
                                {
                                    Name = "Big Statue",
                                    FindPlace = "New Orleans",
                                    FindWhen = "1331",
                                    IsTemporaryExhibition = true,
                                    OnDisplayTill = new DateTime(2025, 12, 11),
                                    MadeOf = "Brick"
                                },
                                new Painting
                                {
                                    Name = "Dogs",
                                    FindPlace = "Amsterdam",
                                    FindWhen = "44 BC",
                                    IsTemporaryExhibition = true,
                                    OnDisplayTill = new DateTime(2023, 05, 31),
                                    Style = "Modern"
                                }
                            }
                }
            };

            return museums;
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