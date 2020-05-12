using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionsRecap
{
    class Vehicle
    {
        public Brand Brand { get; set; }
        public string Color { get; set; }
    }

    enum Brand
    {
        BMW,
        Fico,
        Fiat,
        Yugo
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Single
            List<Vehicle> vehicles = new List<Vehicle>()
            {
                new Vehicle { Brand = Brand.BMW, Color = "red" },
                new Vehicle { Brand = Brand.BMW, Color = "white" },
                new Vehicle { Brand = Brand.Fico, Color = "white" },
                new Vehicle { Brand = Brand.Fico, Color = "white" },
                new Vehicle { Brand = Brand.Fico, Color = "white" },
                new Vehicle { Brand = Brand.Fiat, Color = "blue" },
                new Vehicle { Brand = Brand.Fico, Color = "black" }
            };

            vehicles.Add(new Vehicle { Brand = Brand.Yugo, Color = "yellow" });

            Vehicle bmw1 = vehicles.First();
            Vehicle fico = vehicles.FirstOrDefault(x => x.Brand == Brand.Fico);
            Vehicle bwm2 = vehicles.Single(x => x.Brand == Brand.Fiat);

            //let ficos = vehicles.filter(v => v.Brand === "Fico") // This is how it's done i JS
            List<Vehicle> ficos = vehicles.Where(v => v.Brand == Brand.Fico).ToList();
            List<Vehicle> whiteVehs = vehicles.Where(v => v.Color == "white").ToList();

            List<string> ficosColors = vehicles.Select(v => v.Color).ToList();

            //var veh = vehicles[190]; // ArgumentsOutOfRangeException


            Console.ReadLine();
        }
    }
}
