using CompanyLibrary.Models;
using System;

namespace CompanyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager("Bob", "Bobsky");
            manager.PrintInfo();
            manager.AddBonus(3000);
            Console.WriteLine("Salary: {0}", manager.GetSalary());
            Console.WriteLine("------------------------------------");

            SalesPerson sales01 = new SalesPerson("John", "Snow");
            sales01.PrintInfo();
            sales01.ExtendSuccessSaleRevenue(1500);
            Console.WriteLine("Salary: {0}", sales01.GetSalary());


            Console.ReadLine();
        }
    }
}
