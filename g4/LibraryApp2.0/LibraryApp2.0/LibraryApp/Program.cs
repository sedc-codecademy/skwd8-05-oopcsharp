using LibraryApp.Models.Book;
using LibraryApp.Models.User;
using LibraryApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;

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
        // 8. Use collections (List) --- done
        // 9. Change Login & Register methods --- done
        // 10. Plus features of our library --- done
        // 11. Improve UI flow ----------> // HOMEWORK


        private static UserService _userService = new UserService();
        private static BookService _bookService = new BookService();
        private static HelperService _helperService = new HelperService();
        private static UIService _uiService = new UIService();

        private static User _loggedUser = null;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our LibraryApp");
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
                    _loggedUser = _uiService.RegisterFlow();
                }
                else
                {
                    Console.Clear();
                    continue;
                }


                // Different flows for User and Admin
                if(_loggedUser.Role == Roles.Admin)
                {
                    // Imporove admin flow
                    // Display welcome message ... Select specific option 
                    // 1. Add new user
                    // 2. Delete a user
                    // 3. Print all users

                    //** (optional) add while infinite control // HOMEWORK

                    _loggedUser.GreetPerson($"Welcome mr/mrs. {_loggedUser.LastName}");
                    Console.WriteLine("Please select one of the following options: ");
                    Console.WriteLine("1) Register a new user");
                    Console.WriteLine("2) Delete a user");
                    Console.WriteLine("3) Print all users");

                    string selectedOption = Console.ReadLine();

                    switch (selectedOption)
                    {
                        case "1":
                            _uiService.RegisterFlow();
                            break;

                        case "2":
                            Console.WriteLine("Please enter the ID of the user you want to delete");
                            int id = int.Parse(Console.ReadLine());
                            _userService.RemoveUserById(id);
                            break;

                        case "3":
                            _userService.PrintUsers();
                            break;

                        default:
                            Console.WriteLine("You have entered a non existing option");
                            break;
                    }


                }
                else if(_loggedUser.Role == Roles.User)
                {
                    // Imporove admin flow
                    // Display welcome message ... Select specific option 
                    // 1. Show my books
                    // 2. Show all books
                    // 3. Rent a book
                    // 4. Return a book

                    //** (optional) add while infinite control // HOMEWORK

                    _loggedUser.GreetPerson($"Welcome mr/mrs. {_loggedUser.LastName}");
                    Console.WriteLine("Please select one of the following options: ");
                    Console.WriteLine("1) Show my books");
                    Console.WriteLine("2) Show all books");
                    Console.WriteLine("3) Rent a book"); // HOMEWORK
                    Console.WriteLine("4) Return a book"); // HOMEWORK

                    string selectedOption = Console.ReadLine();

                    switch (selectedOption)
                    {
                        case "1":
                            try
                            {
                                List<Book> userBooks = _userService.GetBooksByUserId(_loggedUser.Id);
                                //if (userBooks.Count() > 0)
                                if(userBooks != null)
                                {
                                    userBooks.ForEach(Console.WriteLine);
                                }
                                else
                                {
                                    Console.WriteLine("You haven't rented a book yet !");
                                }
                            }
                            catch (NullReferenceException ex)
                            {
                                Console.WriteLine("Value can't be null!");
                                Console.WriteLine($"Original message: {ex.Message}");
                            }

                            break;
                        case "2":
                            _bookService.PrintAllBooks();
                            break;

                        case "3":
                            // homework
                            break;

                        case "4":
                            // homework
                            break;

                        default:
                            Console.WriteLine("You have entered a non existing option");
                            break;
                    }

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
