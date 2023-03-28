namespace CityAttraction.Attractions.Zoos.Animals
{
    public enum Sex
    {
        Male,
        Female
    }

    public enum Water
    {
        Salty,
        Freshwater
    }

    public abstract class Animal
    {
        public Sex Sex { get; set; }
        public int Age { get; set; }
        public required string FirstName { get; set; }
        public string Species { get; set; }
        public required string OriginalZoo { get; set; }
        public bool IsGuest { get; set; }

        public Animal(string species)
        {
            Species = species;
        }
    }
}
