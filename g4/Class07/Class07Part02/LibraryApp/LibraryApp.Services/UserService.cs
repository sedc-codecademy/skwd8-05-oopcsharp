using LibraryApp.Models.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp.Services
{
    public class UserService
    {
        public User[] Users { get; set; }

        public UserService()
        {
            Users = new User[]
            {
                new User() 
                {
                    FirstName = "Dejan", 
                    LastName = "Jovanov", 
                    Username = "dejan_jovanov", 
                    Password = "bigsecret123",
                    Role = Roles.Admin
                },
                new User("Kristina", "Spasevska", "kristina_spasevska", "unknown123")
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
            User[] newArr = Users;
            Array.Resize(ref newArr, newArr.Length + 1);
            newArr[newArr.Length - 1] = user;
            Users = newArr;

            return Users[Users.Length - 1];
        }

        public void PrintUsers()
        {
            foreach (User user in Users)
            {
                user.PrintFullName();
            }
        }
    }
}
