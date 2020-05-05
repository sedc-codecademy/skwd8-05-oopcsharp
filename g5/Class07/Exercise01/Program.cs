using System;
using Models;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Manager("Risto", "Panchevski", 10000);

            Console.WriteLine(employee.GetInfo());
        }
    }
}
