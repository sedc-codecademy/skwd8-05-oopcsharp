using System;

namespace ExeptionsMultipleCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            // GLOBAL EXCEPTION HANDLING MECHANISM

            //try
            //{
            //    // code here :))

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine();
            //}

            Console.WriteLine("Please be nice and enter a value for BYTE data type:");
            byte number = 0;


            // 1. Catch exception if occurred because of the code logic 
            // 2. Re throw/ Throw the exepction!
            try
            {
                // BYTE as Data Type in C# -> 0 - 255
                number = byte.Parse(Console.ReadLine());
                //number = byte.Parse(null);

                //throw new OverflowException("No such a contact :)");
            }
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);

            //    // code for email here => always if exception happened!!
            //}
            catch (FormatException ex)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Format exception occured!");
                Console.WriteLine("You have entered text instead of byte number.");
                Console.ResetColor();
            }
            catch (OverflowException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Overflow exception occured!");
                Console.WriteLine("You have entered negative or number bigger than 255.");
                Console.ResetColor();
            }
            //catch (ArgumentNullException ex)
            //{
            //    Console.ForegroundColor = ConsoleColor.Yellow;
            //    Console.WriteLine("ArgumentNull exception occured!");
            //    Console.WriteLine("You are trying to parse NULL.");
            //    Console.ResetColor();
            //}

            //Console.WriteLine("The value is: " + number);

            Console.ReadLine();
        }
    }
}