using SEDC.LibraryApp.Domain;
using SEDC.LibraryApp.Services;
using System;

namespace SEDC.LibraryApp
{
    // 1. Folder structure for our app - Done
    // 2. Create domain classes User and Book - Done
    // 3. Create Book and User service - in progress...
    // 4. Writn the login questions and register questions
    // 5. Create a login and register method in the user service, as well as an array of users
    // 6. To validate things create a helper service
    // 7. Implement login and register methods in user service
    // 8. Implement get all books method in the book service 


    class Program
    {
        private static UserService _userService = new UserService();
        private static BookService _bookService = new BookService();
        private static HelperService _helperService = new HelperService();
        private static User _loggedUser = null;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Do you want to login or register");
                Console.WriteLine("1) Login");
                Console.WriteLine("2) Register");
                int loginChoice = _helperService.ValidatePositiveNumber(Console.ReadLine(), 2);

                if (loginChoice == 1)
                {
                    while (true)
                    {
                        Console.WriteLine("Enter username:");
                        string username = Console.ReadLine();
                        Console.WriteLine("Enter password:");
                        string password = Console.ReadLine();
                        _loggedUser = _userService.LogIn(username, password);

                        if (_loggedUser == null)
                        {
                            _helperService.ErrorMessage("Wrong username or password");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else
                        {
                            Console.Clear();
                            break;
                        }
                    }
                }
                 //Implement register logic for homework
                if (_loggedUser.Role == "user")
                {
                    _bookService.PrintAllBooks();
                }
                else if (_loggedUser.Role == "admin")
                {
                    _userService.PrintUsers();
                }
                else
                {
                    _helperService.ErrorMessage("Something went wrong... Please try again!");
                }
                if (_helperService.RunAgain() == false) break;
                Console.Clear();
            }
        }
    }
}