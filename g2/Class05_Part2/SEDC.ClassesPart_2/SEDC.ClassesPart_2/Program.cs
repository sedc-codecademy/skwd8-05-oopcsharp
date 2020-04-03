using System;

namespace SEDC.ClassesPart_2
{

    public class Car
    {
        public string Brand;
        public string Model;
        public string Color;
        public int NumberOfWheels;
        public int FuelCapacity;

        public Car()
        {

        }

        public void StartEngine()
        {
            Console.WriteLine("Wroom Wroom!!!");
        }
        public void Drive()
        {
            Console.WriteLine("Start driving!");
        }
        public void Break()
        {
            Console.WriteLine("Breaaaaak!!!");
        }

        public void GetCarSpecification()
        {
            Console.WriteLine("The car brand is: {0}\n The car model {1}\n The car color is {2}\n The car fuel capacity is {3}", Brand, Model, Color, FuelCapacity);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car ford = new Car();
            ford.Brand = "Ford";
            ford.Model = "Mustang";
            ford.Color = "Red";
            ford.NumberOfWheels = 4;
            ford.FuelCapacity = 50;


            ford.GetCarSpecification();

            ford.StartEngine();
            ford.Drive();
            ford.Break();

            Console.ReadLine();
        }
    }
}
