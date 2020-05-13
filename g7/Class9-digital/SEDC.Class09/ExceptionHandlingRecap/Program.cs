using System;
using System.Collections.Generic;
using System.Linq;

namespace ExceptionHandlingRecap
{
    class Program
    {
        static int TryParse(string input)
        {
            int number;
            try
            {
                number = int.Parse(input);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{input} is not a number. {ex.Message}");
                number = 0;
            }
            return number;
        }

        static void Divide(int num1, int num2)
        {
            Console.WriteLine(num2 / num1);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            string userInput = Console.ReadLine();
            int userNum = TryParse(userInput);

            try
            {
                Divide(0, 10);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            new List<int>().First(x => x == 1);

            Console.WriteLine($"The number is {userNum}");

            Console.ReadLine();
        }
    }
}
