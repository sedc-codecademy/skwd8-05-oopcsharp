using System;

namespace SEDC.Class04.Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print();
            //PrintName("Hello SEDC!");

            //int result = Sum(1, 5);
            int num1 = Parse();
            int num2 = Parse();

            int result = PowerOfTwo(num1, num2);


            //Program pg = new Program();
            //pg.SayHello();

            Console.WriteLine(result);

            Console.ReadLine();
        }

        public static void Print() 
        {
            Console.WriteLine("Hello World!");
            return;
        }

        public static void PrintName(string message)
        {
            Console.WriteLine(message);
        }

        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int PowerOfTwo(int num1, int num2)
        {
            int result = Sum(num1, num2);
            return result * result;
        }

        public void SayHello()
        {
            Console.WriteLine("Hello World!");
        }

        public static int Parse()
        {
            string input;
            int parsedNumber;
            do
            {
                Console.WriteLine("Please enter a number: ");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out parsedNumber));
            return parsedNumber;
        }
    }
}
