namespace Classes
{
    public class Truck : Vehicle
    {
        public int NumberOfTrailers { get; set; }

        public Truck(string name, string model, int weight, int numberOfTires, int enginePower, int numberOfTrailers)
        : base(name, model, weight, numberOfTires, enginePower)
        {
            NumberOfTrailers = numberOfTrailers;
        }

        public override int CalculatePrice()
        {
            return EnginePower * 5 + NumberOfTrailers * 10000;
        }
    }
}
