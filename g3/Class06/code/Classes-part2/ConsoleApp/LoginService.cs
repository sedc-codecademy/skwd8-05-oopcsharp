using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    // Login Service
    public class LoginService
    {
        // One way for using a LogIn method
        public void LogIn(string userName, string password)
        {
            UserModel[] users = GetAllUsers();
            bool correct = false;

            foreach (UserModel user in users)
            {
                if (user.UserName == userName && user.Password == password)
                {
                    correct = true;
                    break;
                }
            }

            if (correct)
            {
                Console.WriteLine("You successfully logged in");
            }
            else
            {
                Console.WriteLine("Wrong username or password");
            }
        }

        // This is a private method that helps us get all the users from an imaginary database 
        private UserModel[] GetAllUsers()
        {
            UserModel user1 = new UserModel
            {
                UserName = "sedc.academy2",
                Password = "4321"
            };
            UserModel user2 = new UserModel
            {
                UserName = "sedc.academy3",
                Password = "4321"
            };

            UserModel[] users = new UserModel[2] { user1, user2 };

            return users;
        }

        // Another way of using LogIn method
        public void LogIn(UserModel user)
        {
            if (user.UserName == "sedc.academy2" && user.Password == "1234")
                Console.WriteLine("You successfully logged in");
            else
                Console.WriteLine("username or password is wrong");
        }

        public void LogOut(UserModel user)
        {
            if (user.UserName == "sedc.academy2")
            {
                Console.WriteLine("You successfully logged out");
            }
            else
            {
                Console.WriteLine("Error while logging out");
            }
        }
    }
}
