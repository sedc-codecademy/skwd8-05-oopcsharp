using System;

namespace Exe6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vnesi broj:");
            string input1 = Console.ReadLine();
            if (int.TryParse(input1, out int number1))
            {
                Console.WriteLine("Vnesi vtor broj:");
                string input2 = Console.ReadLine();
                if (int.TryParse(input2, out int number2))
                {
                    if (number1 > number2)
                    {
                        Console.WriteLine("Prviot broj e pogolem od vtoriot: " + number1);
                    } else if (number1 < number2)
                    {
                        Console.WriteLine("Prviot broj e pomal od vtoriot: " + number2);
                    }
                    else
                    {
                        Console.WriteLine("Broevite se ednakvi");
                    }

                    //Check if first number is odd or even
                    int number1mod = number1 % 2;
                    if (number1mod == 0)
                    {
                        Console.WriteLine("Prviot broj e paren");
                    }
                    else
                    {
                        Console.WriteLine("Prviot broj e neparen");
                    }

                    //Check if second number is odd or even
                    int number2mod = number2 % 2;
                    if (number2mod == 0)
                    {
                        Console.WriteLine("Vtoriot broj e paren");
                    }
                    else
                    {
                        Console.WriteLine("Vtoriot broj e neparen");
                    }
                }
                else
                {
                    Console.WriteLine("Vnesete validen broj.");
                }
            }
            else
            {
                Console.WriteLine("Vnesete validen broj.");
            }
        }
    }
}
