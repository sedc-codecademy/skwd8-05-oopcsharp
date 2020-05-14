using System;
using System.Data.Common;

namespace SEDC.ExceptionMultipleCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            // BYTE is a data type in C#, it can accept a number in the range from 0 to 255
            //byte num = 0;

            Console.WriteLine("Please enter a value for BYTE data type:");
            byte number = 0;

            try
            {
                //number = byte.Parse(Console.ReadLine());
                number = byte.Parse(null);
            }
            catch (FormatException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Format exception occured!");
                Console.WriteLine("You have entered a text instead of byte number.");
                Console.ReadLine();
            }
            catch (OverflowException ex)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Overflow exception occured!");
                Console.WriteLine("You have entered a negative or number bigger than 255.");
                Console.ReadLine();
            }
            //catch (ArgumentNullException ex)
            //{
            //    Console.ForegroundColor = ConsoleColor.Yellow;
            //    Console.WriteLine("Argument null exception occured!");
            //    Console.WriteLine("You are trying to parse NULL into byte.");
            //    Console.ReadLine();
            //}
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Main exception occured!");
                Console.WriteLine("Something bad happend!");
                Console.WriteLine($"Message: {ex.Message} | Exception: {ex.GetType()}");

                Console.ReadLine();
            }

        }
    }
}
