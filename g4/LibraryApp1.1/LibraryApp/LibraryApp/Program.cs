using LibraryApp.Models.User;
using LibraryApp.Services;
using System;

namespace LibraryApp
{
    class Program
    {
        // 1. Folder structure for our app --- done
        // 2. Create domain models for User and Book --- done
        // 3. Create User and Book services --- done
        // 4. Create methods in the coresponding services --- done
        // 5. Write the login or register flow (console questions) --- done
        // 6. Add validation --- done
        // 7. Inheritance of classes --- done
        // TO DO
        // 8. Use collections (List)
        // 9. Change Login & Register methods
        // 10. Plus features of our library


        private static UserService _userService = new UserService();
        private static BookService _bookService = new BookService();
        private static HelperService _helperService = new HelperService();

        private static User _loggedUser = null;

        static void Main(string[] args)
        {
            while (true)
            {
                // Main flow (questions) 
                Console.WriteLine("Do you want to login or register ? ");
                Console.WriteLine("1) Login");
                Console.WriteLine("2) Register");
                //string userChoice = Console.ReadLine();
                int userChoice = _helperService.ValidatePositiveNumber(Console.ReadLine(), 2);

                // 1. Login flow
                if (userChoice == 1)
                {
                    while (true)
                    {
                        Console.WriteLine("Enter Username");
                        string username = Console.ReadLine();
                        Console.WriteLine("Enter Password");
                        string password = Console.ReadLine();

                        _loggedUser = _userService.LogIn(username, password);

                        if (_loggedUser == null)
                        {
                            _helperService.ErrorMessage("Wrong username or password");                          
                        }
                        else
                        {
                            Console.Clear();
                            break;
                        }
                    }                  
                }

                // 2. Register flow
                else if (userChoice == 2)
                {
                    while (true)
                    {
                        Console.WriteLine("Enter Firstname");
                        string firstName = Console.ReadLine();
                        Console.WriteLine("Enter Lasstname");
                        string lastName = Console.ReadLine();
                        Console.WriteLine("Enter Username");
                        string username = Console.ReadLine();
                        Console.WriteLine("Enter Password");
                        string password = Console.ReadLine();

                        User newUser = new User(firstName, lastName, username, password);

                        _loggedUser = _userService.Register(newUser);

                        if (_loggedUser == null)
                        {
                            _helperService.ErrorMessage("Register not successfull! Please try again! ");
                            
                        }
                        else
                        {
                            Console.Clear();
                            break;
                        }

                    }
                }
                else
                {
                    Console.Clear();
                    continue;
                }


                // Different flows for User and Admin
                if(_loggedUser.Role == Roles.Admin)
                {
                    _userService.PrintUsers();
                }
                else if(_loggedUser.Role == Roles.User)
                {
                    _bookService.PrintAllBooks();
                }
                else
                {
                    _helperService.ErrorMessage("Something went wrong... Please try again!");
                }

                // Run again or end 
                if (!_helperService.RunAgain()) break;
                Console.Clear();
            }
        }
    }
}
