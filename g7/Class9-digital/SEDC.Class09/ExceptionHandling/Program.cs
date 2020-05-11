using System;

namespace ExceptionHandling
{
    class Program
    {
        static int TryPrase(string input) // Similar re-implementation of int.TryParse()
        {
            int num;

            try
            {
                num = int.Parse(input); // This line could potentially throw an Exception, we're not sure so that's why we are putting it in a Try block
            }
            catch (Exception ex)// The catch block is called whenever an Exception is thrown
                // Exception class contains information about the exception that could potentially happen
            { 
                Console.WriteLine($"Error: Cannot convert {input} to int. Message: {ex.Message}");
                num = 0;
            }

            return num;
        }

        static int AddNumbers(string number1, string numbers2)
        {
            return int.Parse(number1) + int.Parse(numbers2); // This line could also throw an Exception
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            string userInput1 = Console.ReadLine();
            int userNum1 = TryPrase(userInput1);

            Console.WriteLine("Enter the second number");
            string userInput2 = Console.ReadLine();
            int userNum2 = TryPrase(userInput2);

            Console.WriteLine($"The result is {userNum1 + userNum2}");

            // We can also use try-catch outside of a function, as a wrapper.
            try
            {
                Console.WriteLine(AddNumbers(userInput1, userInput2));
            } 
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }

            Console.ReadLine();
        }
    }
}
