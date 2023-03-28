namespace CityAttraction.Attractions.Zoos.Animals
{
    public class Fish : Animal
    {
        public Fish() : base(nameof(Fish)) { }
        public Water Water { get; set; }

        public override string ToString()
        {
            return $"Name: {FirstName} | Species: {Species} | Sex: {Sex} | Age: {Age} | Water type: {Water}";
        }
    }
}
