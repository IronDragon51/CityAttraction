namespace CityAttraction.Attractions.Zoos.Animals
{
    class Mammal : Animal
    {
        public Mammal() : base(nameof(Mammal)) { }
        public int LifeExpectancy { get; set; }

        public override string ToString()
        {
            return $"Name: {FirstName} | Species: {Species} | Sex: {Sex} | Age: {Age} | Life Expectancy: {LifeExpectancy}";
        }
    }
}
