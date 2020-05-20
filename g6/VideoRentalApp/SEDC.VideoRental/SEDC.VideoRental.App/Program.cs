using SEDC.VideoRental.Data.Models;
using SEDC.VideoRental.Services.Helpers;
using SEDC.VideoRental.Services.Menus;
using SEDC.VideoRental.Services.Services;
using System;

namespace SEDC.VideoRental.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Video Rental";

            var _userService = new UserService();
            var _movieService = new MovieService();
            User user = null;

            #region Login
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
            #endregion


            while (true)
            {
                Screen.ClearScreen();
                Screen.MainMenu(user.FullName);
                var selection = InputParser.ToInteger(1, 4);
                switch (selection)
                {
                    case 1:
                        _movieService.ViewMovieList(user);
                        break;
                    case 2:
                        _movieService.ViewRentedVideos(user);
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                }
            }
        }
    }
}
