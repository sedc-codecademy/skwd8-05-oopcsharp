using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare a new array of integers with 5 elements
            int[] numbers = new int[5];

            //initialize the array elements with values from input

            // we use numberOfElement only for printing which element user is entering
            int numberOfElements = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                numberOfElements = i + 1;

                Console.WriteLine("enter the " + numberOfElements + " number:");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            //sum all the values and print the result in the console
            int suma = 0;

            foreach (var num in numbers)
            {
                suma += num;
            }

            Console.WriteLine(suma);

            Console.ReadLine();

        }
    }
}
