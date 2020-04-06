using Class5.DomainServiceClasses.Domain;
using Class5.DomainServiceClasses.Services;
using System;

// JS
// script1 -> Code is here -> Can only access stuff from script1
// script2 -> Code is here -> Can only access stuff from script1 and script2
// script3 -> Code is here -> Can access stuff from all scripts

// C#
// You can access everything as long as it is in using above the namespace
namespace Class5.DomainServiceClasses
{
	// Somewhere in the project background this happens:
	// new Program(...) -> 
	class Program
	{
		// Example 2: Make na instance of the service in the class as private field
		// Underscore is naming convention for private fields
		// This example is better because we can use this _userService in EVERY method in this class
		// The Example 1 must be used and typed individualy for every method in the class so duplicating code
		private static UserService _userService = new UserService();
		static void Main(string[] args)
		{
			// Domain vs Service classes
			// Domain classes are classes that represent logical concepts ( business logic concepts )
			// Service classes are classes that represent functional concepts ( organizing methods and programming values better )

			Console.WriteLine("Welcome to the Bookthron 3000");
			Console.WriteLine("1) Log in");
			Console.WriteLine("2) Register");
			int initChoice = 
			// Example 1: Call a service class
			//UserService userService = new UserService();
			//userService.LogIn("", "");

			// Example 2: Call a service as private field
			Console.WriteLine("Enter username");
			string username = Console.ReadLine();
			Console.WriteLine("Enter password");
			string password = Console.ReadLine();
			User loggedInUser = _userService.LogIn(username, password);
			User random = new User();
			random.FirstName = "BillAgain";
			loggedInUser.FirstName = "Bill";
			if (loggedInUser == null) Console.WriteLine("Username or password is wrong...");
			else Console.WriteLine($"Welcome {loggedInUser.FirstName}!");
			Console.ReadLine();

			// Code flow: 
			// 1. Program class is instanciated in the background ( Just for console applications )
			// 2. _userService field is instanciated from the folder Services and we get a new instance of the class UserService
			// 3. The Main method is executed 
			// 4. We ask the user to enter username and password
			// 5. We send those username and password to the LogIn method
			// 6. The LogIn method executes INSIDE of the UserService class
			// 7. It compares the username and password and returns either the user or null
			// 8. We check if the result is null, we give an error message
			// 9. If the result is not null then we Welcome the user

			// While loop
			// Infinite while loop without any ReadLine anywhere -> Run forever -> Lag the PC
			// Why? -> The computer runs thorugh the loop with as much speed as possible and it never stops
			// Infinite while loop with a lot of ReadLine code -> Runs until it hits break -> Does not lag PC
			// Why? -> Runs code until it hits ReadLine -> When it hits ReadLine it waits and does not run anything

		}
	}
}
