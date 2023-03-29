namespace CityAttraction.Attractions.Zoos.Animals
{
    public class Reptile : Animal
    {
        public Reptile() : base(nameof(Reptile)) { }

        public string? FavoriteFood { get; set; }

        public override string ToString()
        {
            return $"Name: {FirstName} | Species: {Species} | Sex: {Sex} | Age: {Age} | Favorite food: {FavoriteFood}";
        }
    }
}
