using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Remeber when we are initialising a variable from input its string by default
            Console.WriteLine("Please enter some value");
            string input = Console.ReadLine();
            Console.WriteLine($"You entered: {input}");
            Console.ReadLine();
        }
    }
}
