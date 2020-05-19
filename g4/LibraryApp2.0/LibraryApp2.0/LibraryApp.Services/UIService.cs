using LibraryApp.Models.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp.Services
{
    public class UIService
    {
        private static UserService _userService = new UserService();
        private static HelperService _helperService = new HelperService();
        public User RegisterFlow()
        {
            User _regiteredUser = null;

            while (true)
            {
                Console.WriteLine("Enter Firstname");
                string firstName = Console.ReadLine();
                Console.WriteLine("Enter Lastname");
                string lastName = Console.ReadLine();
                Console.WriteLine("Enter Username");
                string username = Console.ReadLine();
                Console.WriteLine("Enter Password");
                string password = Console.ReadLine();

                User newUser = new User(firstName, lastName, username, password);

                _regiteredUser = _userService.Register(newUser);

                if (_regiteredUser == null)
                {
                    _helperService.ErrorMessage("Register not successfull! Please try again! ");

                }
                else
                {
                    Console.Clear();
                    break;
                } 
            }

            return _regiteredUser;
        }
    }
}
