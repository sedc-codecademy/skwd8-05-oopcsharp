using System;

namespace SEDC.ExceptionHandling
{

    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Please enter a number!");
                int number = int.Parse(Console.ReadLine());


                double result = 10 / number;

                Console.WriteLine(number);
            }
            catch (Exception ex) 
            {
                //Console.WriteLine(ex.Message);
                Console.WriteLine("Ooops, something went wrong, please try again later!");
                Console.WriteLine(ex.GetType());
            }
            finally
            {
                Console.WriteLine("I'm here FINALLY!");
            }





            Console.ReadLine();
        }
    }
}
