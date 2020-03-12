using System;

namespace CSharpBranching
{
    class Program
    {
        static void Main(string[] args)
        {
            // Application for determining the exam points rank according to the given score

            Console.WriteLine("Please enter your exam score (number from 1 - 5):");

            int score = 0;
            bool validInput = int.TryParse(Console.ReadLine(), out score);

            //Using IF-ELSE IF-ELSE branching in C#
            if (validInput == true && score > 0)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Valid input, please read your result details:");
                Console.ResetColor();

                // Using SWITCH branching in C#
                switch (score)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Sorry, you got 1 to 20 points and failed the exam. :(");
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Sorry, you got 20 to 40 points and failed the exam. :(");
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Great, you got 40 to 60 points and passed the exam. :)");
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Excellent, you got 60 to 80 points and passed the exam. :))");
                        break;
                    case 5:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Fantastic, you got 80 to 100 points and passed the exam. :)))");
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("You have entered number bigger than the maximum allowed, please try again.");
                        break;
                }
            }
            else if (validInput == true && score < 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("The points cannot be negative, close the program and try again.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Invalid input, close the program and try again.");
            }

            Console.WriteLine($"asd {score}");
            Console.ReadLine();
        }
    }
}