using System;

namespace Exe4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vnesete operator:");
            string oper = Console.ReadLine();

            Console.WriteLine("Vnesete prv broj:");
            string broj1String = Console.ReadLine();

            if (int.TryParse(broj1String, out int broj1))
            {
                Console.WriteLine("Vnesete vtor broj:");
                string broj2String = Console.ReadLine();
                if (int.TryParse(broj2String, out int broj2))
                {
                    switch (oper)
                    {
                        case "+":
                            int resultSum = Sum(broj1, broj2);
                            Console.WriteLine(resultSum);
                            break;
                        case "-":
                            int resultSub = Subtract(broj1, broj2);
                            Console.WriteLine(resultSub);
                            break;
                        default:
                            Console.WriteLine("Dozvoleni operatori se samo + i -");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Ne vnesovte validen broj");
                }
            }
            else
            {
                Console.WriteLine("Ne vnesovte validen broj");
            }
        }

        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }
    }
}
