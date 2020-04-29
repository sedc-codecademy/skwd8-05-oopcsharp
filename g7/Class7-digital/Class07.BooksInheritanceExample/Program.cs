using Class07.BooksInheritanceExample.Domain;
using Class07.BooksInheritanceExample.Services;
using System;

namespace Class07.BooksInheritanceExample
{
	class Program
	{
		private static UserService _userService = new UserService();
		private static HelperService _helperService = new HelperService();
		private static User _loggedUser = null;
		static void Main(string[] args)
		{
			while (true)
			{
				int initChoice;
				while (true)
				{
					Console.WriteLine("Welcome to the Bookthron 3000");
					Console.WriteLine("1) Log in");
					Console.WriteLine("2) Register");
					initChoice = _helperService.ValidatePositiveNumber(Console.ReadLine(), 2);
					if (initChoice == -1) continue;
					break;
				}

				if (initChoice == 1)
				{
					while (true)
					{
						Console.WriteLine("Enter username");
						string username = Console.ReadLine();
						Console.WriteLine("Enter password");
						string password = Console.ReadLine();
						User loggedInUser = _userService.LogIn(username, password);
						User random = new User();
						if (loggedInUser == null)
						{
							Console.WriteLine("Username or password is wrong...");
							Console.ReadLine();
							continue;
						}
						_loggedUser = loggedInUser;
						break;
					}
				}
				else if (initChoice == 2)
				{
					while (true)
					{
						Console.WriteLine("Enter first name:");
						string firstName = Console.ReadLine();
						Console.WriteLine("Enter last name:");
						string lastName = Console.ReadLine();
						Console.WriteLine("Enter username:");
						string username = Console.ReadLine();
						Console.WriteLine("Enter password:");
						string password = Console.ReadLine();
						User newUser = new User()
						{
							FirstName = firstName,
							LastName = lastName,
							Username = username,
							Password = password
						};
						User registeredUser = _userService.Register(newUser);
						if (registeredUser == null)
						{
							Console.WriteLine("There was an invalid input. Please try again...");
							Console.ReadLine();
							continue;
						}
						_loggedUser = registeredUser;
						break;
					}
				}
				Console.WriteLine($"Welcome {_loggedUser.FirstName}!");
				Console.ReadLine();
				bool runAgain = _helperService.RunAgain();
				if (!runAgain) break;
			}
		}
	}
}
