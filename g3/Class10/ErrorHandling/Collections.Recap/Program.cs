using System;
using System.Collections.Generic;
using System.Linq;

namespace Collections.Recap
{
    class Program
    {
        static List<Vehicle> vehicles { get; set; } = new List<Vehicle>
        {
            new Vehicle { Brand = Brand.Fico, Color = "red", Year = 1985 },
            new Vehicle { Brand = Brand.Fico, Color = "white", Year = 1988 },
            new Vehicle { Brand = Brand.Fiat101, Color = "blue", Year = 1990 },
            new Vehicle { Brand = Brand.Yugo, Color = "red", Year = 1991 },
            new Vehicle { Brand = Brand.Yugo, Color = "white", Year = 1995 },
            new Vehicle { Brand = Brand.Audi, Color = "black", Year = 2009 },
            new Vehicle { Brand = Brand.Opel, Color = "grey", Year = 2005 },
            new Vehicle { Brand = Brand.Fico, Color = "yellow", Year = 1990 }
        };

        static void Main(string[] args)
        {
            Vehicle fico1 = vehicles.ElementAt(1);
            Vehicle fico2 = vehicles.First();
            Vehicle fico3 = vehicles.First(v => v.Brand == Brand.Fico);
            Vehicle fico4 = vehicles.Last(v => v.Brand == Brand.Fico);
            Vehicle audi1 = vehicles.Single(v => v.Brand == Brand.Audi);
            //Vehicle purpleCar = vehicles.Single(v => v.Color == "purple"); // Throws an exception

            List<Vehicle> whiteCars = vehicles.Where(v => v.Color == "white").ToList();
            List<Vehicle> vehByBrand = vehicles.OrderBy(v => v.Brand).ToList();
            List<Vehicle> vehByBrandDesc = vehicles.OrderByDescending(v => v.Brand).ToList();
            //PrintList(whiteCars);
            //PrintList(vehByBrand);
            //PrintList(vehByBrandDesc);
            List<int> vehYears = vehicles
                .Where(v => v.Brand == Brand.Fico)
                .Select(v => v.Year)
                .ToList();

            int minYear = vehicles.Min(v => v.Year);
            int maxYear = vehicles.Max(v => v.Year);
            double avgYear = Math.Round(vehicles.Average(v => v.Year));

            List<Vehicle> firstThree = vehByBrand.Take(3).ToList();
            List<Vehicle> secondThree = vehByBrand.Skip(3).Take(3).ToList();
            List<Vehicle> thirdThree = vehByBrand.Skip(6).Take(3).ToList();

            PrintList(firstThree);
            PrintList(secondThree);
            PrintList(thirdThree);

            Console.ReadLine();
        }

        static void PrintList(List<Vehicle> list)
        {
            foreach (var veh in list)
            {
                Console.WriteLine($"{veh.Brand} {veh.Color} {veh.Year}");
            }
            Console.WriteLine("-------------------------------------------");
        }
    }
}
