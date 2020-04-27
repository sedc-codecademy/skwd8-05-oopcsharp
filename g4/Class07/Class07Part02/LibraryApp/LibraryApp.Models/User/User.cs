using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp.Models.User
{
    public class User
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public Roles Role { get; set; }

        public User()
        {
            Role = Roles.User;
        }

        public User(string fName, string lName, string uName, string pass)
        {
            FirstName = fName;
            LastName = lName;
            Username = uName;
            Password = pass;
            Role = Roles.User;
        }

        public string GreetPerson(string message)
        {
            return $"Hello {FirstName} welcome to the Library App";
        }

        public void PrintFullName()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }


    }
}
