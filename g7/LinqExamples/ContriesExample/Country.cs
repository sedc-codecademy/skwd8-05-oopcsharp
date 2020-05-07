namespace ContriesExample
{
    public class Country
    {
        public string Name { get; set; }
        public int Population { get; set; }
        public int Area { get; set; } //sq mi

        public Country(string name, int population, int area)
        {
            Name = name;
            Population = population;
            Area = area;
        }

        public string GetInfo()
        {
            return $"{Name} {Population} - {Area} sq mi";
        }
    }
}
