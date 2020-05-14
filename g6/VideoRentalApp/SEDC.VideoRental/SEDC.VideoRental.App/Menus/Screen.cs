using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.VideoRental.App.Menus
{
    public class Screen
    {
        public static void HomeScreen()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("==========================================================================");
            Console.WriteLine("==========================================================================");
            Console.WriteLine("==  \\\\    //  || ||||   ||||||  ||||||   ||||||  ||||||  ||  || ||||||  ==");
            Console.WriteLine("==   \\\\  //   || ||  || ||=     ||  ||   ||\\\\    ||=     ||\\\\||   ||    ==");
            Console.WriteLine("==    \\\\//    || ||||   ||||||  ||||||   ||  \\\\  ||||||  ||  ||   ||    ==");
            Console.WriteLine("==========================================================================");
            Console.WriteLine("==========================================================================");
            Console.ResetColor();
        }

        public static void StartMenu()
        {
            Console.WriteLine("Welcome to video rent store.");
            Console.WriteLine("Use the numbers in front of the selection to navigate thru the applicaton.");
            Console.WriteLine("1. Rent a movie with existing account.");
            Console.WriteLine("2. Rent a movie and create account.");
            Console.WriteLine("3. Exit application.");
        }
    }
}
