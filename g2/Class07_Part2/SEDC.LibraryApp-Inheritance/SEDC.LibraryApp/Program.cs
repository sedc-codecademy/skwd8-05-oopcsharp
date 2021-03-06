﻿using SEDC.DomainModels.Book;
using SEDC.DomainModels.User;
using SEDC.Services;
using System;

namespace SEDC.LibraryApp
{// 1. Folder structure for our app 
    // 2. Create domain classes User and Book 
    // 3. Create Book and User service 
    // 4. Write the login questions and register questions
    // 5. Create a login and register method in the user service, as well as an array of users
    // 6. To validate things create a helper service
    // 7. Implement login and register methods in user service
    // 8. Implement get all books method in the book service 
    // 9. Implement class library project structure
    // 10.Implement register logic
    // 11.Implement hardcopy and online renting of the books

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
                else if (loginChoice == 2)
                {
                    while (true)
                    {
                        Console.WriteLine("Enter the first name:");
                        string firstName = Console.ReadLine();
                        Console.WriteLine("Enter the last name:");
                        string lastName = Console.ReadLine();
                        Console.WriteLine("Enter the username:");
                        string username = Console.ReadLine();
                        Console.WriteLine("Enter password:");
                        string password = Console.ReadLine();

                        User newUser = new User(_userService.GenerateId(), firstName, lastName, username, password);

                        _loggedUser = _userService.Register(newUser);

                        if (_loggedUser == null)
                        {
                            _helperService.ErrorMessage("Register not successfull! Please try again...");
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

                if (_loggedUser.Role == Roles.User)
                {
                    //Improve the logged user workflow
                    //Display message: Welcome #firstName #lastName. Please select an option:
                    //Give the user an option to: 
                    //1. Show my books - Done
                    //2. Show all books - Done
                    //3. Borrow book

                    //4. Add while for infinite control

                    Book[] usersBooks = _userService.GetBooksByUserId(_loggedUser.Id);
                    if(usersBooks.Length > 0)
                    {
                        foreach (Book book in usersBooks)
                        {
                            Console.WriteLine(book);
                        }
                    }
                    else
                    {
                        Console.WriteLine("You have't rented book yet!");
                    }
                    //_bookService.PrintAllBooks();
                }
                else if (_loggedUser.Role == Roles.Admin)
                {
                    //TODO: 
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
