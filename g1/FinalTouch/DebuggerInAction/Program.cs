using System;

namespace DebuggerInAction
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);

                Console.WriteLine("Something else...");

                // logic
            }

            int number = 10;
            string name = "G1";
            Console.WriteLine(number);
            Console.WriteLine(name);

            if(number > 10)
            {
                number = 1000;
            }

            Test(number);

            number = 100;
            Console.WriteLine(number);

            name = "G! Rocks! :)))";

            number = 200;
            Console.WriteLine(number);

            Console.ReadLine();
        }

        public static void Test(int num)
        {
            num++;
            Console.WriteLine(num);

            num = 120;
            Console.WriteLine(num);

            num = 0;
            Console.WriteLine(num);
        }
    }
}
