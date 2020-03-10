using System;

namespace SEDC.Class03.Excersises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vnesi broj:");
            string userInput = Console.ReadLine();

            //int parsedNumber = 0;
            if(!int.TryParse(userInput, out int parsedNumber))
            {
                Console.WriteLine("Invalid number");
            }

            Console.WriteLine(parsedNumber);

            Console.ReadLine();
        }
    }
}
