using System;

namespace Exceptions.Basic
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            ////Compile time errors
            //var result = 10 / 0;
            //Console.Writ("This will not be written");
            //var number = 0;
            //var result = 10 / number;
            //Console.WriteLine($"The result {result}");

            //try
            //{
            //    var number = 0;
            //    var result = 10 / number;
            //    Console.WriteLine($"The result {result}");
            //}
            //catch (NullReferenceException ex)
            //{
            //    throw ex;
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine($"ERROR: An error like this happened: {ex.Message}");
            //    //throw ex;
            //}
            //catch (Exception)
            //{

            //    throw;
            //}

            //Simple showing of try/catch/finally block and explanation of what happens when
            try
            {
                Console.WriteLine("Exceptions........");

                Console.WriteLine("This is the part of the code that throws Exceptions.");
                throw new Exception("This will be our custom exception");
                //This will be never executed because of the throw call!!!
                Console.WriteLine("This will be never executed because of the throw call!!!");

            }
            catch(Exception ex)
            {
                Console.WriteLine($"ERROR: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Exception or not, this will always be written");
            }
            Console.WriteLine("Application continues.... :)");

            Console.ReadLine();
        }
    }
}
