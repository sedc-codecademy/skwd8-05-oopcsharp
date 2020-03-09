using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            #region TryParse example
            //bool parseSuccess = int.TryParse("25", out int parsedNum);
            //Console.WriteLine(parseSuccess);
            //Console.WriteLine(parsedNum);
            #endregion

            #region For Loop
            // // simple for loop
            //for(int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            // // infinite loop with for
            //for(; ; )
            //{
            //    Console.WriteLine("This will go on forever... Unless you enter X");
            //    string input = Console.ReadLine();
            //    if (input == "X" || input == "x") break;
            //}
            #endregion

            #region While Loop
            //int whileCounter = 1;
            //while(whileCounter <= 10)
            //{
            //    Console.WriteLine(whileCounter);
            //    whileCounter++;
            //}

            ////infinite loop with while
            //while (true)
            //{
            //    Console.WriteLine("This will go on forever... Unless you enter X");
            //    string input = Console.ReadLine();
            //    if (input == "X" || input == "x") break;
            //}
            #endregion

            #region Do While Loop
            //int doWhileCounter = 1;
            //do
            //{
            //    Console.WriteLine(doWhileCounter);
            //    doWhileCounter++;
            //}
            //while (doWhileCounter <= 10);

            //do
            //{
            //    Console.WriteLine("This will be printed!");
            //}
            //while (false);
            #endregion

            #region Break & Continue
            // break & continue
            //Console.WriteLine("------Break-------");

            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i == 3) break;
            //    Console.WriteLine(i);
            //}
            //// break exits the for loop immediately
            //Console.WriteLine("-------Continue-------");
            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i == 3) continue;
            //    Console.WriteLine(i);
            //}
            ////continue exit the current cycle and continues the next cycle
            #endregion

            #region Exercises 1-3
            //// exercise 1
            //Console.WriteLine("Enter a number:");
            //int ex1Input01 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Output:");
            //for (int i = 1; i <= ex1Input01; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("Enter a number:");
            //int ex1Input02 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Output:");

            //for (int i = ex1Input02; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //// exercise 2
            //Console.WriteLine("Enter a number:");
            //int ex2Input01 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Output even numbers:");

            //for (int i = 2; i <= ex2Input01; i++ )
            //{
            //    if (i % 2 == 0) Console.WriteLine(i);
            //}

            //Console.WriteLine("Enter a number:");
            //int ex2Input02 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Output odd numbers:");

            //for (int i = 1; i <= ex2Input02; i++)
            //{
            //    if (i % 2 != 0) Console.WriteLine(i);
            //}

            //// exercise 3
            //Console.WriteLine("Enter a number:");
            //int ex3Input = int.Parse(Console.ReadLine());
            //Console.WriteLine("Output weird numbers:");

            //for (int i = 1; i <= ex3Input; i++)
            //{
            //    if (i % 3 == 0 || i % 7 == 0) continue;
            //    if (i == 100)
            //    {
            //        Console.WriteLine("The limit is reached!");
            //        break;
            //    }
            //    Console.WriteLine(i);
            //}
            #endregion

            Console.ReadLine();

        }
    }
}
