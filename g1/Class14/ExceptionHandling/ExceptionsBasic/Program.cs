using System;

namespace ExceptionsBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number for division: ");

            int result = 0;

            // TRY => always the code that can generate an ERROR!
            try
            {
                int number = int.Parse(Console.ReadLine());
                result = 10 / number;
            }

            // CATCH -> always the code for HANDLING the ERROR :/
            catch (Exception ex)
            {
                Console.WriteLine("Something wrong happened... :(");
            }

            // FINALLY -> always code that will be EXECUTED :))
            finally
            {
                Console.WriteLine("I`m here FINALLY :)))))");
            }

            //Console.WriteLine("The division of 10 with the entered number is: " + result );


            Console.WriteLine("The application continues... :)");

            // more application code and implementation

            Console.ReadLine();
        }
    }
}