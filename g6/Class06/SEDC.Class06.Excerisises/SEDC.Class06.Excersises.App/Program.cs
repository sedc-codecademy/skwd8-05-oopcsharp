using SEDC.Class06.Excersises.Business.Services;
using System;

namespace SEDC.Class06.Excersises.App
{
    class Program
    {
        static void Main(string[] args)
        {
            // ValidationSevice validationSevice = new ValidationSevice();
            var validationSevice = new ValidationSevice();

            string email = Console.ReadLine();
            if (!validationSevice.ValidateEmail(email))
            {
                Console.WriteLine("Enter valid email.");
            }
            else
            {
                Console.WriteLine("Great it works");
            }

            string password = Console.ReadLine();
            if (!validationSevice.ValidatePassword(password))
            {
                Console.WriteLine("Password is not valid, should be minimum 8 chars 1 upper letter and 1 digit");
            }
            else
            {
                Console.WriteLine("Super it works");
            }

            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
