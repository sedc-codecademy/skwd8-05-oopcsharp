using Calculator.Models;
using System;
using System.Collections.Generic;

namespace Digitron
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 10, 20, 40, 30, 5 };
            int maxNumber = Calc.Max(numbers);
            Console.WriteLine(maxNumber);
            Console.WriteLine("----------------------------------");
            Console.WriteLine(Calc.Avg(numbers));
            Console.ReadLine();
        }
    }
}
