using System;

namespace Exe4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];

            for (int i = 0; i < 3; i++)
            {
                string input = Console.ReadLine();

                //if (Int32.TryParse(input, out numbers[i]))
                //{
                //}
                //else
                //{
                //    Console.WriteLine("Ne vnesovte broj");
                //    return;
                //}

                bool validParse = Int32.TryParse(input, out numbers[i]);

                if (!validParse) //if (validParse == false)
                {
                    Console.WriteLine("Ne vnesovte broj");
                    return;
                }
            }

            int suma = 0;

            foreach (var number in numbers)
            {
                suma += number;
            }

            Console.WriteLine("Zbirot e: " + suma);
        }
    }
}
