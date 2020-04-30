namespace Classes
{
    public class Van : Vehicle
    {
        public int LoadCapacity { get; set; }
        public bool IsAutomatic { get; set; }

        public Van(string name, string model, int weight, int numberOfTires, int enginePower, int loadCapacity,
            bool isAutomatic)
            : base(name, model, weight, numberOfTires, enginePower)
        {
            LoadCapacity = loadCapacity;
            IsAutomatic = isAutomatic;
        }

        public Van() { }

        public override int CalculatePrice()
        {
            int price = base.CalculatePrice() * 2 + LoadCapacity;

            if (IsAutomatic)
                price += 3000;

            return price;
        }
    }
}
