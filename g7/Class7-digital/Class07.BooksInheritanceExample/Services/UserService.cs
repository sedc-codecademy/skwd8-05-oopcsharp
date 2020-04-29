using Class07.BooksInheritanceExample.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Class07.BooksInheritanceExample.Services
{
	public class UserService
	{
		private HelperService _helperService = new HelperService();
		private User CurrentUser;
		// private field ( like a varialbe to keep stuff in it locally for this class )
		private User[] Users; // field -> similar to variable, keeps some data for internal use of the class
		public UserService()
		{
			Users = new User[]
			{
				new User()
				{
					FirstName = "Bob",
					LastName = "Bobksy",
					Username = "Bob22",
					Password = "bobbest1"
				},
				new User()
				{
					FirstName = "Jill",
					LastName = "Wayne",
					Username = "Jillcool",
					Password = "sparkythedog1"
				}
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
			// null is basically saying that there is a class but the class has no object instance
			return null; // Our way of saying no user like that
		}
		// Validate Password can only be used for passwords
		// This is logic connected to registering
		// Validate String is a general method, which we can use in any logic that needs validating strings
		// That is why it is in the Helper Service ( General purpose methods go there )
		private bool ValidatePassword(string password)
		{
			if (password.Length < 7) return false;
			char[] characters = password.ToCharArray();
			bool hasNumber = false;
			// bobbest12
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
