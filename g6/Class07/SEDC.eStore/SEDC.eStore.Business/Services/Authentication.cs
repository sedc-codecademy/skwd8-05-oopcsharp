using SEDC.eStore.Data.Database;
using SEDC.eStore.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.eStore.Business.Services
{
    public static class Authentication
    {
        public static User Login(UserRepository userRepository, ValidationService validationSevice)
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

                User user = userRepository.GetUserByEmail(email);
                if (user == null)
                {
                    Console.WriteLine("User does not exists");
                    continue;
                }

                // TODO: add 3 tries for password

                Console.WriteLine("Enter password");
                string password = Console.ReadLine();
                if (user.Password != password)
                {
                    Console.WriteLine("Password is incorect.");
                    continue;
                }

                return user;
            }
        }
    }
}
