using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.LibraryApp.Services
{
    public class HelperService
    {
        public void ErrorMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public bool ValidateStringLength(string value, int range)
        {
            int maxValue = 20;
            if (value.Length < range && range < maxValue)
                return false;
            return true;
        }

        public int ValidatePositiveNumber(string number, int range)
        {
            int result = 0;
            bool isNumber = int.TryParse(number, out result);
            if (!isNumber)
            {
                Console.WriteLine("You must enter a number. Press enter to try again!");
                Console.ReadLine();
                Console.Clear();
                return -1;
            }
            if(result < 1 || result > range)
            {
                Console.WriteLine("The number is out of range. Press enter to try again!");
                Console.ReadLine();
                Console.Clear();
                return -1;
            }
            return result;
        }

        public bool RunAgain()
        {
            while (true)
            {
                Console.WriteLine("Wouldyou like to run again? Y/N");
                string answer = Console.ReadLine().ToLower();
                if (answer == "y") return true;
                if (answer == "n") return false;
            }
        }
    }
}
