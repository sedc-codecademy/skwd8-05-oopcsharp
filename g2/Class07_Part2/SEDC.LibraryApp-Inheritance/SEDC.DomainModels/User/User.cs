using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.DomainModels.User
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Roles Role { get; set; }
        public Book.Book[] Books { get; set; }

        public User()
        {
            this.Role = Roles.User;
        }

        public User(int id, string firstName, string lastName, string username, string password, Roles role)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Username = username;
            this.Password = password;
            this.Role = role;
        }

        public User(int id, string firstName, string lastName, string username, string password)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Username = username;
            this.Password = password;
            this.Role = Roles.User;

            this.Books = new Book.Book[0];
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
