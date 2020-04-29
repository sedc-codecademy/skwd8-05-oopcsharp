using Class07.Domain.Classes; // This namespace makes ALL classes available
// IF the two classes had different namespaces we will have to write them both here in order to work
using System;
using System.Collections.Generic;
using System.Text;

// NAMESPACES RULEBOOK - Dragan Gelevski 2020
// A namespace is an address
// You can't use a class without USING it's address
// We must write the namespace of the class in order to use it somewhere ( in another namespace )
// Classes that are in the same namspace can use each other functionality
// Multiple classes can have the same namespace 
// All those classes will be available if someone calls their address ( USING NAMESPACE )
// Folders do not affect the addresses of the classes
// Classes can be in a different folder and share an address ( same namespace )
// - > In this case with using we get both of them
// Classes can be in the same folder but have different addresses ( different namespace )
// - > In this case with using we get one and we have to write another using for the other class

namespace Class07.Domain.Services
{
	public class UserService
	{
		private HelperService _helperService = new HelperService();
		private User CurrentUser;
		private User[] Users; 
		public UserService()
		{
			Users = new User[]
			{
				new User("Bob", "Bobksy", "bob22", "bobbest1", UserRole.Administrator),
				new User("Jill", "Wayne", "Jillcool","sparkythedog1", UserRole.Standard)
			};
		}
		public User LogIn(string username, string password)
		{
			foreach (User user in Users)
			{
				if (user.Username == username && user.Password == password)
				{
					CurrentUser = user;
					return user;
				}
			}
			return null; 
		}
		private bool ValidatePassword(string password)
		{
			if (password.Length < 7) return false;
			char[] characters = password.ToCharArray();
			bool hasNumber = false;
			foreach (char character in characters)
			{
				int num = 0;
				if(int.TryParse(character.ToString(), out num))
				{
					hasNumber = true;
					break;
				}
			}
			if (!hasNumber) return false;
			return true;
		}
		public void PrintUsers()
		{
			foreach (User user in Users)
			{
				// [Administrator] Bob Bobsky
				// Fancy styling
				Console.ForegroundColor = ConsoleColor.Green;
				Console.Write($"[{user.Role}] ");
				Console.ResetColor();
				Console.WriteLine($"{user.FirstName} {user.LastName}");
			}
		}
		public User Register(User user)
		{
			if(!_helperService.ValidateString(user.FirstName, 2) ||
				!_helperService.ValidateString(user.LastName, 2) ||
				!_helperService.ValidateString(user.Username, 5))
			{
				return null;
			}
			if (!ValidatePassword(user.Password)) return null;
			// Standard role will be EVERY USER THAT REGISTERS
			// Administrators will be added manually if there is a need for that
			user.Role = UserRole.Standard;
			Array.Resize(ref Users, Users.Length + 1);
			Users[Users.Length - 1] = user;
			return Users[Users.Length - 1];
		}
		public User IsUserLoggedIn()
		{
			if (CurrentUser == null) return null;
			return CurrentUser;
		}
		public void LogOut()
		{
			CurrentUser = null;
		}
	}
}
