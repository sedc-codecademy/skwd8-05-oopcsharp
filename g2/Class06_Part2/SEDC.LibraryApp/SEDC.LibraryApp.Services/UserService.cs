using System;
using System.Collections.Generic;
using System.Text;
using SEDC.LibraryApp.Domain;
using SEDC.LibraryApp.DomainModels.User;

namespace SEDC.LibraryApp.Services
{
    public class UserService
    {
        private HelperService _helperService = new HelperService();

        public User[] Users { get; set; }
        public UserService()
        {
            Users = new User[]
            {
                new User()
                {
                    FirstName = "Martin",
                    LastName = "Panovski",
                    Username = "martin_panovski",
                    Password = "netigokazhuvam123",
                    Role = Roles.Admin
                },
                new User()
                {
                    FirstName = "Ivo",
                    LastName = "Kostovski",
                    Username = "ivo_kostovski",
                    Password = "negoznam123",
                    Role = Roles.User
                }
            };
        }

        // Validate Password
        public bool ValidatePassword(string password)
        {
            if (password.Length < 7) return false;
            char[] characters = password.ToCharArray();
            bool hasNumber = false;
            foreach (char character in characters)
            {
                int num = 0;
                if (int.TryParse(character.ToString(), out num))
                {
                    hasNumber = true;
                    break;
                }
            }
            if (!hasNumber) 
                return false;
            return true;
        }

        //Login method
        public User LogIn(string username, string password)
        {
            foreach (User user in Users)
            {
                if (user.Username == username && user.Password == password)
                    return user;
            }
            return null;
        }

        //Register method
        public User Register(User user)
        {
            //Validation
            if(!_helperService.ValidateStringLength(user.FirstName, 2) ||
               !_helperService.ValidateStringLength(user.LastName, 2)  ||
               !_helperService.ValidateStringLength(user.Username, 5))
            {
                return null;
            }

            if (!ValidatePassword(user.Password)) 
                return null;
            
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
                Console.WriteLine(user.FullName());
            }
        }
    }
}
