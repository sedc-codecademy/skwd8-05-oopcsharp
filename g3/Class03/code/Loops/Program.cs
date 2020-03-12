using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            #region OneTry
            //Console.WriteLine("Enter a number:");
            //string userInput = Console.ReadLine();
            //int userNum;
            //bool result = int.TryParse(userInput, out userNum);
            //if (result)
            //{
            //    Console.WriteLine("Successful conversion!");
            //}
            //else
            //{
            //    Console.WriteLine("unsuccessful conversion!");
            //}
            #endregion

            #region Until userInput is a valid number, using while
            //Console.WriteLine("Enter a number:");
            //string userInput = Console.ReadLine();
            //int userNum;
            //while (!int.TryParse(userInput, out userNum))
            //{
            //    Console.WriteLine("You entered an invalid number, please try again!");
            //    userInput = Console.ReadLine();
            //}
            //Console.WriteLine($"Cool, you entered a valid number {userNum}, the validation was done with while!");
            #endregion

            #region Until userInput is a valid number, using do-while
            string userInput = null; // We are intentionally setting the initial value of userInput to null, because if we don't we would get compile-time error(use of unassigned variable) in the code where we use it
            int userNum;
            do
            {
                Console.WriteLine(userInput == null ? "Enter a number:" : "You entered an invalid number, please try again!");
                userInput = Console.ReadLine();

            } while (!int.TryParse(userInput, out userNum));
            Console.WriteLine($"Cool, you entered a valid number {userNum}, the validation was done with do-while!");
            #endregion

            Console.ReadLine();
        }
    }
}
