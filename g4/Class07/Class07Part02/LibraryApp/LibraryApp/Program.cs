using LibraryApp.Models.User;
using LibraryApp.Services;
using System;

namespace LibraryApp
{
    class Program
    {
        // 1. Folder structure for our app
        // 2. Create domain models for User and Book
        // 3. Create User and Book services
        // 4. Create methods in the coresponding services 
        // 5. Write the login or register flow (console questions)
        // 6. Add validation


        private static UserService _userService = new UserService();
        // book service instance

        private static User _loggedUser = null;

        static void Main(string[] args)
        {
            while (true)
            {
                // Main flow (questions) 
                Console.WriteLine("Do you want to login or register ? ");
                Console.WriteLine("1) Login");
                Console.WriteLine("2) Register");
                string userChoice = Console.ReadLine();

                // 1. Login flow
                if (userChoice == "1")
                {
                    Console.WriteLine("Enter Username");
                    string username = Console.ReadLine();
                    Console.WriteLine("Enter Password");
                    string password = Console.ReadLine();

                    _loggedUser = _userService.LogIn(username, password);

                    if (_loggedUser == null)
                    {
                        Console.WriteLine("Wrong username or password");
                    } 
                }

                // 2. Register flow
                if (userChoice == "2")
                {

                }


                // Different flows for User and Admin

                // Run again or end 

            }
        }
    }
}
