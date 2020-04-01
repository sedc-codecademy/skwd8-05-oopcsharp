using Class5.DomainServiceClasses.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Class5.DomainServiceClasses.Services
{
	class UserService
	{
		// private field ( like a varialbe to keep stuff in it locally for this class )
		private User[] Users;
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
				if (user.Username == username && user.Password == password) return user;
			}
			// null is basically saying that there is a class but the class has no object instance
			return null; // Our way of saying no user like that
		}
	}
}
