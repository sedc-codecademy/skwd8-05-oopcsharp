using SEDC.Class06.Entites;
using SEDC.Class06.Enumerations;
using System;

namespace SEDC.Class06.App
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee epm1 = new Employee();
            //Console.WriteLine(epm1.CreateOn);
            //epm1.CreateOn = DateTime.Now;
            //Console.WriteLine(epm1.CreateOn);
            //Employee epm2 = new Employee() { CreateOn = DateTime.Now };

            Employee emp3 = new Employee();
            Console.WriteLine(emp3.PrintInfo());

            Employee emp4 = new Employee("Trajan", "Stevkovski", 100, Role.Trainer);
            Console.WriteLine(emp4.PrintInfo());

            Console.ReadLine();
        }
    }
}
