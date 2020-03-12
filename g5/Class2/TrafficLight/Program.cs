using System;
using System.Threading;

namespace TrafficLight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Red!");
            Console.ResetColor();

            Thread.Sleep(5000);

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Yellow!");
            Console.ResetColor();

            Thread.Sleep(2000);
            
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Green!");
            Console.ResetColor();
        }
    }
}
