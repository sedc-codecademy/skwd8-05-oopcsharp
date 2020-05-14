using System;
using System.Collections.Generic;
using System.Threading;

namespace WhileLoopExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> accountNumbers = new List<string>() {"111", "222", "333"};

            while (true)
            {
                try
                {
                    Console.WriteLine("Dobredojdovte vo marketot!");
                    Console.WriteLine("Vnesete broj na karticka:");
                    string account = Console.ReadLine();

                    if (!accountNumbers.Contains(account))
                    {
                        throw new Exception("Vnesovte nevalidna karticka!");
                    }

                    Console.WriteLine($"{account}: Pocnete so kupuvanje");
                    Thread.Sleep(5000);
                    Console.WriteLine($"{account} Vi blagodarime!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
            }
        }
    }
}
