using System;

namespace OgnenQuestion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ognen question:");

            int number = 100;

            SomethingToAsk(number);

            Console.ReadLine();
        }

        public static bool SomethingToAsk(int number)
        {
            Console.WriteLine("Please enter a number");

            //Not all code paths return value
            //if (number > 100)
            //    return true;

            if (number > 100)
                return true;
            else
                return false;
        }
    }
}
