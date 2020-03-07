using System;

namespace Parsing
{
    class Program
    {
        static void Main(string[] args)
        {
            // Parse

            // Possible exceptions: 
            //   - ArgumentNullException = if variable number is null
            //   - FormatException = if user enters invalid input
            //   - OverflowException = if user enters number larger then max. number that integer accepts

            string number = "10";
            int parsedNumber = int.Parse(number);
            Console.WriteLine(parsedNumber);

            // Convert.ToType - most used case in industry

            // Possible exceptions: 
            //   - FormatException = if user enters invalid input
            //   - OverflowException = if user enters number larger then max. number that integer accepts

            string anotherNumber = "100";
            int anotherParsedNumber = Convert.ToInt32(anotherNumber);
            Console.WriteLine(anotherParsedNumber);

            // Try Parse
            // Remember we are using it when we want to control the scenario if user enter an invalid input
            // so our console application won't throw exceptions like we saw on the class

            Console.Write("Please enter a number: ");
            string inputNumber = Console.ReadLine();
            int result;
            // if input is not converted successfully the result will have the default value of integer witch is 0
            // and canBeConvertedToInt will be false
            // ELSE result will be the converted input number and canBeConvertedToInt will be true
            bool canBeConvertedToInt = int.TryParse(inputNumber, out result);
            Console.WriteLine($"Input successfull converted to integer: {canBeConvertedToInt}, result: {result}");

            Console.ReadLine();

        }
    }
}
