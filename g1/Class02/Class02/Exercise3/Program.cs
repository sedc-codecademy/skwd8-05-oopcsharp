using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            // set variable from input
            // convert it to integer
            // print the remainder of dividing that number with 10

            Console.WriteLine("Please enter some number");
            var number = Console.ReadLine();
            int converted;
            bool isConverted = int.TryParse(number, out converted);

            // we are checking if the input from user is successfully converted to integer
            if (isConverted)
            {
                // if it is converted then we do the calculation and print the result
                var result = converted % 10;
                Console.WriteLine($"RESULT: {result}");
            }
            else
            {
                // else we are printing a message to the user that he/she entered invalid input
                Console.WriteLine("You entered invalid input");
            }

            Console.ReadLine();
        }
    }
}
