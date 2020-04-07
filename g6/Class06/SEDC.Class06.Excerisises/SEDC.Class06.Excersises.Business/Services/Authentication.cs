using SEDC.Class06.Excersises.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Class06.Excersises.Business.Services
{
    public static class Authentication
    {
        public static User Register(User[] users, ValidationSevice validationSevice)
        {
            string email = EnterEmail(validationSevice, users);
            string password = EnterPassword(validationSevice);
            // Same with return
            // User user = CreateUser(email, password);
            // return user;
            return CreateUser(email, password);
        }

        public static User Login(User[] users, ValidationSevice validationSevice)
        {
            while (true)
            {
                Console.Write("Enter email: ");
                string email = Console.ReadLine();

                if (!validationSevice.ValidateEmail(email))
                {
                    Console.WriteLine("Enter valid email.");
                    continue;
                }

                User user = FindUser(email, users);
                if(user == null)
                {
                    Console.WriteLine("User does not exists");
                    continue;
                }

                // TODO: add 3 tries for password

                Console.WriteLine("Enter password");
                string password = Console.ReadLine();
                if(user.Password != password)
                {
                    Console.WriteLine("Password is incorect.");
                    continue;
                }

                return user;
            }
        }

        private static string EnterEmail(ValidationSevice validationSevice, User[] users)
        {
            while (true)
            {
                Console.WriteLine("Enter email: ");
                string email = Console.ReadLine();
                if (!validationSevice.IsEmailUnique(email, users))
                {
                    Console.WriteLine("Email is already taken.");
                    continue;
                }

                if (!validationSevice.ValidateEmail(email))
                {
                    Console.WriteLine("Please enter valid mail.");
                    continue;
                }

                return email;
            }
        }

        private static string EnterPassword(ValidationSevice validationSevice)
        {
            while (true)
            {
                Console.WriteLine("Enter password. Password should contain 1 upper charater, 1 digit and should be 8 letter long");
                string password = Console.ReadLine();
                if (!validationSevice.ValidatePassword(password))
                {
                    Console.WriteLine("Enter valid password");
                    continue;
                }

                return password;
            }
        }

        private static User CreateUser(string email, string password)
        {
            Console.Write("Enter first name: ");
            string fname = Console.ReadLine();

            Console.Write("Enter last name: ");
            string lname = Console.ReadLine();

            while (true)
            {
                Console.WriteLine("Enter date of birth (format 02/19/1998)");
                string dob = Console.ReadLine();
                if(!DateTime.TryParse(dob, out DateTime dateOfBirth))
                {
                    Console.WriteLine("Please enter valid date of birth.");
                    continue;
                }

                User user = new User(email, password, fname, lname, dateOfBirth);
                return user;
            }
        }

        private static User FindUser(string email, User[] users)
        {
            foreach (var user in users)
            {
                if(user.Email.ToLower() == email.Trim().ToLower())
                {
                    return user;
                }
            }
            return null;
        }
    }
}
