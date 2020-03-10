using System;

namespace SEDC.Class03.Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ForLoop
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Iteraation " + i);
            }

            //for(; ; )
            //{
            //    Console.WriteLine("Hello");
            //}

            Console.WriteLine("Creating droid army");
            for(int i = 0; i < 20; i++)
            {
                Console.WriteLine("Creating droid no: " + i );
                if(i == 5)
                {
                    Console.WriteLine("Problem in assembling with droid no:" + i );
                    continue;
                }
                if(i == 7)
                {
                    Console.WriteLine("Droid assembler broke down.");
                    break;
                }
                Console.WriteLine("Droid Batalion " + i + "is operational");
            }

            Console.ReadLine();

            #endregion

            #region WhileLoop

            int counter = 0;
            while(counter < 10)
            {
                Console.WriteLine("Iterattion: " + counter);
                counter++;
            }

            while (true)
            {
                Console.WriteLine("Vnesi broj:");
                string userInput = Console.ReadLine();

                //int parsedNumber = 0;
                if (int.TryParse(userInput, out int parsedNumber))
                {
                    Console.WriteLine("User has entered: " + parsedNumber);
                    break;
                }
                Console.WriteLine("Invalid input");
            }

            #endregion

            #region Do-WhileLoop

            int doWhileCounter = 0;
            do
            {
                Console.WriteLine("Iteration do while: " + doWhileCounter);
                doWhileCounter++;
            } while (doWhileCounter != 1);



            #endregion

            #region Excersise03

            Console.WriteLine("Vnesi broj");
            int userInputExcersise = int.Parse(Console.ReadLine());
            
            for(int i = 1; i < userInputExcersise; i++)
            {
                if(i % 3 == 0)
                {
                    continue;
                }
                if(i % 7 == 0)
                {
                    continue;
                }
                if(i == 100)
                {
                    Console.WriteLine("You have reached the limit");
                    break;
                }

                Console.WriteLine("Number: " + i);
            }

            #endregion
            Console.ReadLine();
        }
    }
}
