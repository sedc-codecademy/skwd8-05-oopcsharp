using System;
using System.Collections.Generic;
using System.Text;

// If you make the namespace Class07.Domain.ImportantClasses, this will be the address of this class
// Even if the folder is called Classes that is not important. The namespace is the address, not the folder structure
namespace Class07.Domain.Classes
{
	public class User
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		// This is a good implementation but we can't scale it
		//public bool IsAdmin { get; set; } // If we have 2 roles only we can use this property
		// public int RoleId { get; set; } // We need to either remember the IDs or make a class called Role and add an ID there
		public UserRole Role { get; set; } // This is enum because we need predefined values and we don't want them to change during runtime
		public User()
		{
			// If the user is empty, unknown, it will have the Standard role
			Role = UserRole.Standard;
		}
		public User(string firstName, string lastName, string username, string password, UserRole role)
		{
			FirstName = firstName;
			LastName = lastName;
			Username = username;
			Password = password;
			Role = role;
		}
	}
}
