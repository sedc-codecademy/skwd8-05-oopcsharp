namespace Classes
{
    public class Vehicle
    {
        public string Name { get; set; }
        public string Model { get; set; }
        //Weight in kg
        public int Weight { get; set; }
        public int NumberOfTires { get; set; }
        public int EnginePower { get; set; }

        public Vehicle(string name, string model, int weight, int numberOfTires, int enginePower)
        {
            Name = name;
            Model = model;
            Weight = weight;
            NumberOfTires = numberOfTires;
            EnginePower = enginePower;
        }

        public Vehicle() { }

        public virtual int CalculatePrice()
        {
            return Weight + EnginePower;
        }

        public string GetVehicleInfo()
        {
            return $"{Name} {Model}";
        }
    }
}
