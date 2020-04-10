using SEDC.LibraryApp.DomainModels.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.LibraryApp.Domain
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Roles Role { get; set; }

        public User()
        {
            Role = Roles.User;
        }

        public User(string firstName, string lastName, string username, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            Username = username;
            Password = password;
            Role = Roles.User;
        }

        public string FullName()
        {
            return $"{FirstName} {LastName}";
        }

        public string GreetPerson(string message)
        {
            return message;
        }
    }
}
