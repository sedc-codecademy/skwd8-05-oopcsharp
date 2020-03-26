using System;

namespace Exe1
{
    class Program
    {
        static void Main(string[] args)
        {
            int zbir = Sum(3, 4);

            Console.WriteLine(zbir);
        }

        public static int Sum(int a, int b)
        {
            int result = a + b;
            return result;
        }
    }
}
