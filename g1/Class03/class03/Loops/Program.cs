using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            // SYNTAX


            // FOR
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            //Print all even numbers to 100 with for
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }


            // WHILE
            int m = 0;

            while (m < 10)
            {
                Console.WriteLine(m);
                m++;
            }

            //Print all even numbers to 100 with while
            int increment = 1;
            while (increment <= 100)
            {
                if (increment % 2 == 0)
                    Console.WriteLine(increment);

                increment++;
            }


            // DO WHILE
            int n = 0;
            do
            {
                Console.WriteLine(n);
                n++;

            } while (n < 10);

            //Print all even numbers to 100 with do while
            int i = 1;
            do
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);

                i++;
            } while (i <= 100);

        }
    }
}
