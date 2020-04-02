using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesRetrospective.Models
{
    /// <summary>
    /// This Vehicle class is from Andrej Hristovski
    /// </summary>
    class Vehicle
    {
        public Vehicle(string brand, string model, int year, string type)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Type = type;
            isStarted = false;
            isDriving = false;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Type { get; set; }
        public bool isStarted { get; set; }
        public bool isDriving { get; set; }
        //public void Start()
        //{
        //    if (isStarted == false)
        //    {
        //        Console.WriteLine("The vehicle has started");
        //        isStarted = true;
        //    }
        //    else
        //    {
        //        Console.WriteLine("The vehicle was already started");
        //    }
        //}
        //public void Drive()
        //{
        //    if (isStarted == true && isDriving == false)
        //    {
        //        Console.WriteLine("The vehicle is now driving");
        //        isDriving = true;
        //    }
        //    else if (isStarted == false)
        //    {
        //        Console.WriteLine("You need to start your vehicle first!");
        //    }
        //    else
        //    {
        //        Console.WriteLine("The vehicle was already driving");
        //    }
        //}
        //public void ShutDown()
        //{
        //    if (isStarted == true)
        //    {
        //        Console.WriteLine("The vehicle will now shutdown");
        //        isStarted = false;
        //    }
        //    else
        //    {
        //        Console.WriteLine("The vehicle is not started!");
        //    }
        //}
        //public void StopDriving()
        //{
        //    if (isStarted == true && isDriving == true)
        //    {
        //        Console.WriteLine("The vehicle will now shutdown");
        //        isDriving = false;
        //    }
        //    else
        //    {
        //        Console.WriteLine("The vehicle is not started!");
        //    }
        //}
        public void Start()
        {
            if (ValidateState("start"))
                isStarted = true;
            else
                Console.WriteLine("");
        }
        public void ShutDown()
        {
            if (ValidateState("shutdown"))
                isStarted = false;
            else
                Console.WriteLine("");
        }
        public void Drive()
        {
            if (ValidateState("drive"))
                isDriving = true;
            else
                Console.WriteLine("");
        }
        public void StopDriving()
        {
            if (ValidateState("stopdriving"))
                isDriving = false;
            else
                Console.WriteLine("");
        }

        private bool ValidateState(string state)
        {
            switch (state)
            {
                case "start":
                    return (!isStarted && !isDriving);
                case "shutdown":
                case "drive":
                    return (isStarted && !isDriving);
                case "stopdriving":
                    return (isStarted && isDriving);
                default:
                    return false;
            }
        }
    }
}
