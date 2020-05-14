using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CarLotApp.Domains;
using CarLotApp.Domains.Enums;

namespace CarLotApp.Services
{
    public static class CarService
    {
        public static Car GetCarById(List<Car> cars,int id)
        {
            Car distingushedCar = new Car();

            try
            {
                distingushedCar = cars.Single(car => car.ID == id);
            }
            catch(NullReferenceException nullException)
            {
                Console.WriteLine($"The method is returning null. Here is the message from the original exception {nullException.Message}");
            }
            catch (Exception error)
            {
                Console.WriteLine("There was not a single element with that ID. There were eather more or none!");
            }
            return distingushedCar;
        }

        public static List<Car> GetCarsByBrand(List<Car> cars,CarBrand brand)
        {
            List<Car> fillteredCars = cars.Where(car => car.Brand == brand).ToList();

            return fillteredCars;
        }
        public static Car GetCarWithMaxKm(List<Car> cars)
        {
            int maxKm = cars.Max(car => car.PassedKM);

            Car carWithMostKm = new Car();
            carWithMostKm = cars.Single(car => car.PassedKM == maxKm);

            //try
            //{
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("There were more cars with same milage. Or cars don't have milage");
            //}

            return carWithMostKm;
        }
    }
}
