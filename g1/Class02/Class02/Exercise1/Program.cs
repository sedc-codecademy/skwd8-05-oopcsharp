using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 100;
            int secondNumber = 50;
            int result = firstNumber + secondNumber;

            Console.WriteLine($"SUM INT RESULT: {result}");

            double firstDoubleNumber = 15.5;
            double secondDoubleNumber = 10.5;
            double secondResult = firstDoubleNumber / secondDoubleNumber;

            Console.WriteLine($"DIVIDED RESULT OF DOUBLE: {secondResult} ");

            Console.ReadLine();
        }
    }
}
