using System;
using System.Threading;

namespace FirstDemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Martin Panovski!");
            Console.WriteLine("Hi we are learning C#, and it is so cool!");

            //Exercise 1
            //Console.WriteLine("     *     ");
            //Console.WriteLine("    ***    ");
            //Console.WriteLine("   *****   ");
            //Console.WriteLine("  *******  ");
            //Console.WriteLine(" ********* ");
            //Console.WriteLine("    | |    ");

            Console.WriteLine("============================");

            //Exercise 2
            Console.WriteLine("    *   ");
            Thread.Sleep(2000);

            Console.WriteLine("    *   ");
            Thread.Sleep(2000);

            Console.WriteLine("   ***  ");
            Thread.Sleep(2000);

            Console.WriteLine(" *  *  *");
            Thread.Sleep(2000);

            Console.WriteLine("    *  ");
            Thread.Sleep(2000);

            Console.WriteLine("    *  ");
            Thread.Sleep(2000);

            Console.WriteLine("  *   *");
            Thread.Sleep(2000);

            Console.WriteLine("*       *");

            
            Console.ReadLine();     
        }
    }
}
