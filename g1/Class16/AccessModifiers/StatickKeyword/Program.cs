using System;
using System.Collections.Generic;

namespace StatickKeyword
{
    class Program
    {
        //public static class StaticClass
        //{
        //    public static int MyProperty { get; set; }
        //}
        public class Employee
        {
            static Employee()
            {
                Console.WriteLine("New instance is created from static constructor");
                // Friends = new List<string>();
            }
            public Employee()
            {
                Console.WriteLine("New instance is created from default constructor");
                NumberOfEmployees++;
            }
            public string Name { get; set; }
            public static int NumberOfEmployees { get; set; }
            public List<string> Friends { get; set; }
            public static void GetFriends(int number)
            {
                //Console.WriteLine(NumberOfEmployees);
                //Frie
                NumberOfEmployees = number;
            }
        }
        static int x = 10;
        static int y = 20;
        static void Main(string[] args)
        {
            // var staticClass = new StaticClass();
            var firstEmployee = new Employee() { Name = "Miodrag" };
            //var secondEmployee = new Employee() { Name = "Buco" };
            //var thirdEmployee = new Employee() { Name = "Viktor" };
            //Employee.
            Console.WriteLine(x);
            Console.WriteLine(y);
            //Console.WriteLine(Employee.NumberOfEmployees);
            //Console.WriteLine(Employee.NumberOfEmployees);
            Console.ReadLine();
        }
    }
}
