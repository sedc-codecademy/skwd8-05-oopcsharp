using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Class05.Classes.Classes
{
    public class Car
    {
        public string Model { get; set; }
        public string Brand { get; set; }
        public DateTime ProductionYear { get; set; }
        public bool IsRunning { get; set; }

        public void Start()
        {
            if (IsRunning)
            {
                Console.WriteLine("The car is running");
            }
            else
            {
                IsRunning = true;
            }
        }

        public void Stop()
        {
            if (!IsRunning)
            {
                Console.WriteLine("The car is not running");
            }
            else
            {
                IsRunning = false;
            }
        }

        public void Drive()
        {
            if (IsRunning)
            {
                Console.WriteLine("Car is driving.");
            }
            else
            {
                Console.WriteLine("You should first start the car in order to drive.");
            }
        }

        public string GetInfo()
        {
            return $"{this.Brand} {Model} is manufatored in {ProductionYear}";
        }
    }
}
