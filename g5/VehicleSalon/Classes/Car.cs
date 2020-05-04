namespace Classes
{
    public class Car : Vehicle
    {
        public InteriorType InteriorType { get; set; }
        public ColorType ColorType { get; set; }
        public bool HasSensors { get; set; }

        public Car(string name, string model, int weight, int numberOfTires, int enginePower, InteriorType interiorType,
            ColorType colorType, bool hasSensors)
            : base(name, model, weight, numberOfTires, enginePower)
        {
            InteriorType = interiorType;
            ColorType = colorType;
            HasSensors = hasSensors;
        }

        public override int CalculatePrice()
        {
            int price = base.CalculatePrice();

            if (InteriorType == InteriorType.Leather)
                price += 1000;

            if (ColorType == ColorType.Metalik)
                price += 500;

            if (HasSensors)
                price += 1500;

            return price;
        }
    }
}
