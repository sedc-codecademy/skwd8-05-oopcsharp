using LibraryApp.Models.Book;
using LibraryApp.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryApp.Services
{
    public class UserService
    {
        private HelperService _helperService = new HelperService();
        public List<User> Users { get; set; }

        public UserService()
        {
            Users = new List<User>
            {
                new User()
                {
                    FirstName = "Dejan",
                    LastName = "Jovanov",
                    Username = "dejan_jovanov",
                    Password = "bigsecret123",
                    Role = Roles.Admin
                },
                new User("Kristina", "Spasevska", "kristina_spasevska", "unknown123"),
                new User("Trpe","Trpkovski","trpe","trpe1234")
            };
        }

        public User LogIn(string username, string password)
        {
            foreach (User user  in Users)
            {
                if (user.Username == username && user.Password == password)
                {
                    return user;
                }
            }
            return null;
        }

        public User Register(User user)
        {
            if (!_helperService.ValidateStringLength(user.FirstName, 2) ||
                !_helperService.ValidateStringLength(user.LastName, 2) ||
                !_helperService.ValidateStringLength(user.Username, 5))
            {
                return null;
            }

            if (!_helperService.ValidatePassword(user.Password))
            {
                return null;
            };

            Users.Add(user);

            return Users.LastOrDefault();
        }

        public void PrintUsers()
        {
            Users.ForEach(user => user.PrintFullName());
        }

        public List<Book> GetBooksByUserId(int id)
        {
            // User foundUser = Users.Where(user => user.Id == id).FirstOrDefault();
            User foundUser = Users.FirstOrDefault(user => user.Id == id);
            return foundUser.Books;
        }

        public void RemoveUserById(int id)
        {
            User foundUser = Users.FirstOrDefault(user => user.Id == id);

            if (foundUser != null)
            {
                Users.Remove(foundUser);
            } 
            else
            {
                Console.WriteLine($"A user with the specified id {id} does not exist");
            }
        }

        // HOMEWORK create the required methods for renting and returning a book
    }
}
