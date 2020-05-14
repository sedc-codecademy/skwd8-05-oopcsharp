using System;
using CarLotApp.Domains;
using CarLotApp.Domains.Enums;
using CarLotApp.Services;

namespace CarLot.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            User damjan = new User(1, "Damjan", "Stojanovski", 28, true);
            Car audi = new Car(1, CarBrand.Audi, "A5", 2015, 150000);
            Car bmw = new Car(2, CarBrand.BMW, "X4", 2010, 200000);
            Car renault = new Car(3, CarBrand.Renault, "Menage", 2016, 90000);
            Car alfa = new Car(4, CarBrand.Alfa, "Romeo", 2009, 300000);

            Car audi2 = new Car(5, CarBrand.Audi, "A6", 2017, 150000);
            Car bmw2 = new Car(6, CarBrand.BMW, "X5", 2018, 200000);
            Car renault2 = new Car(7, CarBrand.Renault, "Talisman", 2018, 90000);
            Car alfa2 = new Car(8, CarBrand.Alfa, "Mito", 2009, 300000);
            damjan.Cars.Add(audi);

            
            damjan.Cars.Add(audi2);
            damjan.Cars.Add(bmw);
            damjan.Cars.Add(bmw2);
            damjan.Cars.Add(renault);
            damjan.Cars.Add(renault2);
            damjan.Cars.Add(alfa);
            damjan.Cars.Add(alfa2);

           

            Car carWithActualMaxKm = CarService.GetCarWithMaxKm(damjan.Cars);

            Console.WriteLine($"Car with most km :  {carWithActualMaxKm.BrandModel}");

            Console.Read();


        }
    }
}
