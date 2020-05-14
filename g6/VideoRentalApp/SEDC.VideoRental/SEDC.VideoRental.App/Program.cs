using SEDC.VideoRental.App.Menus;
using SEDC.VideoRental.Data.Models;
using SEDC.VideoRental.Services.Helpers;
using SEDC.VideoRental.Services.Services;
using System;

namespace SEDC.VideoRental.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var _userService = new UserService();
            User user;

            Screen.HomeScreen();
            bool isLoggedIn = false;
            while (!isLoggedIn)
            {
                Screen.StartMenu();
                var startMenuInput = InputParser.ToInteger(1, 3);
                switch (startMenuInput)
                {
                    case 1:
                        while (!isLoggedIn)
                        {
                            user = _userService.Login();
                            isLoggedIn = !isLoggedIn;
                        }
                        break;
                    case 2:
                        while (!isLoggedIn)
                        {
                            user = _userService.SignUp();
                            isLoggedIn = !isLoggedIn;
                        }
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                }
            }

            Console.WriteLine("Cool");
            Console.ReadLine();
        }
    }
}
