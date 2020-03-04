using System;

namespace ConsoleApp.NetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            // We use console writeln when we want to print something on the console

            Console.WriteLine("       *        ");
            Console.WriteLine("      * *       ");
            Console.WriteLine("     * * *      ");
            Console.WriteLine("    * * * *     ");
            Console.WriteLine("  * * * * * *   ");

            Console.WriteLine("  ******       *   ");
            Console.WriteLine("  *         *  *   ");
            Console.WriteLine("  *       *    *   ");
            Console.WriteLine("  *            *   ");
            Console.WriteLine("  *            *   ");

            // We use console readline when we expect some input from the user,
            // or to stop our console application at specific point like in this example

            Console.ReadLine();
        }
    }
}
