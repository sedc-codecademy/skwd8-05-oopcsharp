using System;
using System.Collections.Generic;

namespace InheritanceApp
{
    class Program
    {
        class FirstClass
        {
            public string Name { get; set; } = "Goce";
        }
        class SecondClass : FirstClass
        {

        }
        class CustomList<T> where T : class
        {
            // our implementation
        }
        static void Main(string[] args)
        {
            var secondClass = new SecondClass();
            Console.WriteLine(secondClass.Name);
            var list = new List<int>();
            var listNew = new CustomList<SecondClass>();
            Console.ReadLine();
        }
    }
}
