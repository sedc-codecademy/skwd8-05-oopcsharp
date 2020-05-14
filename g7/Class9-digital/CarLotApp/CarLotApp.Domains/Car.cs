using CarLotApp.Domains.Enums;
using System;

namespace CarLotApp.Domains
{
    public class Car
    {
        public Car()
        {

        }
        public Car(int id, CarBrand brand, string brandModel,int yearOfProduction,int passedKM)
        {
            ID = id;
            Brand = brand;
            BrandModel = brandModel;
            YearOfProduction = yearOfProduction;
            PassedKM = passedKM;
        }
        public int ID { get; set; }
        public CarBrand  Brand { get; set; }
        public string BrandModel { get; set; }
        public int YearOfProduction { get; set; }
        public int PassedKM { get; set; }
    }
}
