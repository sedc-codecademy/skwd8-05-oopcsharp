using SEDC.Class06.Excersises.Business.Models;
using SEDC.Class06.Excersises.Business.Services;
using System;

namespace SEDC.Class06.Excersises.App
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generate default users
            User[] users = GenerateUsers();
            // ValidationSevice validationSevice = new ValidationSevice();
            var validationSevice = new ValidationSevice();

            while (true)
            {
                Console.WriteLine("\nRegistration press 1 \nLogin press 2 \nExit press 3");
                string userSelection = Console.ReadLine();
                if(!int.TryParse(userSelection, out int validUserSelection))
                {
                    Console.WriteLine("Not valid input. Please try again.");
                    continue;
                }

                switch (validUserSelection)
                {
                    case 1:
                        User newUser = Authentication.Register(users, validationSevice);
                        Array.Resize(ref users, users.Length + 1);
                        users[users.Length - 1] = newUser;
                        Console.Clear();
                        Console.WriteLine($"Thank you for registering {newUser.GetFullName()} \n");
                        PrintUsers(users);
                        break;
                    case 2:
                        User user = Authentication.Login(users, validationSevice);
                        if(user == null)
                        {
                            break;
                        }
                        Console.Clear();
                        Console.WriteLine($"Welcome {user.GetFullName()} \n");
                        PrintUsers(users);
                        break;
                    case 3:
                        Console.WriteLine("Thank you for using our application");
                        Console.ReadLine();
                        return;
                    default:
                        Console.WriteLine("Wrong input");
                        Console.ReadLine();
                        return;
                }
            }
        }

        static User[] GenerateUsers()
        {
            return new User[]
            {
                new User("bob_bobsi@example.com", "eXample6", "Bob", "Bobski",  new DateTime(1979, 05, 25)),
                new User("trajanstevkovski@gmail.com", "Password5%", "Trajan", "Stevkovski",  new DateTime(1987, 04, 15)),
                new User("tosho_todorovski@yahoo.com", "Password5%","Tosho", "Todorovski",  new DateTime(1990, 06, 03))
            };
        }

        static void PrintUsers(User[] users)
        {
            foreach (User user in users)
            {
                Console.WriteLine(user.GetInfo()); 
            }
        }
    }
}
