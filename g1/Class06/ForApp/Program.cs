using System;

namespace ForApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 10, 20, 10, 50, 80 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("For(i): " + numbers[i]);

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("For(j): " + numbers[j]);
                }
            }
        }
    }
}