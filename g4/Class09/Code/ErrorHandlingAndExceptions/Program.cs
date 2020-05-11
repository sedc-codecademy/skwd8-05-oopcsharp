using ErrorHandlingAndExceptions.Exceptions;
using System;

namespace ErrorHandlingAndExceptions
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Try/catch/finally example
            //try
            //{
            //    Console.WriteLine("Please enter a number");
            //    int numberFromUser = int.Parse(Console.ReadLine());

            //    int powOf2 = numberFromUser * numberFromUser;

            //    Console.WriteLine($"Power of two for {numberFromUser} is {powOf2}");

            //    if (powOf2 < 10)
            //    {
            //        throw new Exception("The result can't be smaller that 10 !");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Something went wrong ! An exception with the following message occurred: {ex.Message}");
            //}
            //finally
            //{
            //    Console.WriteLine("Application ended. Press any key to continue ... ");
            //    Console.ReadLine();
            //} 
            #endregion

            #region Multiple catch blocks for different types od Exceptions
            //try
            //{
            //    int[] oddNumbers = new int[] { 1, 3, 5, 7 };

            //    //throw new Exception("Before out of range exception !");

            //    //Console.WriteLine(oddNumbers[5]);

            //}
            //catch (IndexOutOfRangeException indexException)
            //{
            //    Console.WriteLine($"{indexException.Message}");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"The exception with the following message:  {ex.Message} - happend !"); 
            //} 
            #endregion

            #region Custom and nested Exceptions
            try
            {
                Console.WriteLine("Please enter two numbers to divide");
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());

                DivisionMethod(first, second);

                //throw new Exception("This is another exception");

            }
            catch (MathDivisionException customException)
            {
                Console.WriteLine(customException.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            } 
            #endregion

            Console.ReadLine();
        }
    
        // helper method to show the nested excpetions flow
        public static decimal DivisionMethod(decimal dividend, decimal devisor)
        {
            try
            {
                return dividend / devisor;
            }
            catch (Exception ex)
            {
                if (ex.Message == "Attempted to divide by zero.")
                {
                    throw new MathDivisionException($" You can't divide with zero SERIOUSLY ! ", ex);
                }
                else
                {
                    throw ex;
                }
               
            }
        }
        
    }
}
