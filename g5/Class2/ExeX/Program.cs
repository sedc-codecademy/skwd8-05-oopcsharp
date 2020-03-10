using System;

namespace ExeX
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int number;

            bool success = int.TryParse(input, out number);

            if (success)
            {
                switch (number)
                {
                    case 1:
                        Console.WriteLine("Eden");
                        break;
                    case 2:
                        Console.WriteLine("Dva");
                        break;
                    case 3:
                        Console.WriteLine("Tri");
                        break;
                    default: 
                        Console.WriteLine("Vnese broj");
                        break;
                }
            }
            else
            {
                Console.Write("Vnese text: ");
                Console.WriteLine(input);
            }
        }
    }
}
