using System;

namespace Exe1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FOR Zdravo!");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i + ". Zdravo!");
            }


            Console.WriteLine("While Zdravo!");
            int k = 0;
            while (k < 10)
            {
                Console.WriteLine(k + ". Zdravo!");
                k++;
            }

            Console.WriteLine("DO-While Zdravo!");
            int t = 0;
            do
            {
                Console.WriteLine(t + ". Zdravo!");
                t++;
            } while (t < 10);

            Console.WriteLine("Break");
            for (int j = 0; j < 10; j++)
            {
                if(j == 2)
                    break;
                
                Console.WriteLine(j + ". Zdravo!");
            }
            
            Console.WriteLine("Continue");
            for (int u = 0; u < 10; u++)
            {
                if (u == 2)
                    continue;

                Console.WriteLine(u + ". Zdravo!");
            }

            Console.WriteLine("Kraj");
        }
    }
}
