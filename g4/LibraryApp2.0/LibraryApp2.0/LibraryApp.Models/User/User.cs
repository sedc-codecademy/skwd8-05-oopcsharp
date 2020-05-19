using System;
using System.Collections.Generic;
using System.Text;
// using BookModels = LibraryApp.Book;
// BookModels.Book

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

        // using BookModels = LibraryApp.Book;
        // BookModels.Book
        public List<Book.Book> Books { get; set; }

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
