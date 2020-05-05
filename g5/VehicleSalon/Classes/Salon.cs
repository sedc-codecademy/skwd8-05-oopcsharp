using System.Collections.Generic;

namespace Classes
{
    public class Salon
    {
        public string Name { get; set; }
        //public List<Car> Cars { get; set; }
        //public List<Van> Vans { get; set; }
        //public List<Truck> Trucks { get; set; }
        public List<Vehicle> Vehicles { get; set; }

        public Salon(string name)
        {
            Name = name;
            Vehicles = new List<Vehicle>();
        }

        public void AddVehicle(Vehicle vehicle)
        {
            Vehicles.Add(vehicle);
        }

        //public void AddCar(Car car)
        //{
        //}
        //public void AddVan(Van car)
        //{
        //}
        //public void AddTruck(Truck car)
        //{
        //}

        public string GetCatalog()
        {
            string catalog = "Catalog 2020:\n";

            foreach (var vehicle in Vehicles)
            {
                catalog += $"{vehicle.GetVehicleInfo()} - {vehicle.CalculatePrice()}\n";
            }

            return catalog;
        }
    }
}
