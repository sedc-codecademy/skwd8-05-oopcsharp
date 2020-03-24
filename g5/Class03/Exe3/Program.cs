using System;

namespace Exe3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];

            var number1 = Console.ReadLine();

            if (Int32.TryParse(number1, out numbers[0]))
            {
                var number2 = Console.ReadLine();
                if (Int32.TryParse(number2, out numbers[1]))
                {
                    var number3 = Console.ReadLine();
                    if (Int32.TryParse(number3, out numbers[2]))
                    {
                        int suma = 0;

                        foreach (var number in numbers)
                        {
                            suma += number;
                        }

                        Console.WriteLine("Zbirot e: " + suma);
                    }
                    else
                    {
                        Console.WriteLine("Ne vnesovte broj!");
                    }
                }
                else
                {
                    Console.WriteLine("Ne vnesovte broj!");
                }
            }
            else
            {
                Console.WriteLine("Ne vnesovte broj!");
            }
        }
    }
}
