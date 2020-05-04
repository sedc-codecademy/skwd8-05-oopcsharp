using SEDC.DomainModels.Book;
using SEDC.DomainModels.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Services
{
    public class UserService
    {
        private HelperService _helperService = new HelperService();

        public User[] Users { get; set; }
        public UserService()
        {
            Users = new User[]
            {
                new User(1, "Martin", "Panovski", "martin_panovski", "netigokazhuvam123", Roles.Admin),
                new User(2, "Ivo", "Kostovski", "ivo_kostovski", "negoznam123")
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

        public int GenerateId()
        {
            int id = Users.Length + 1;
            return id;
        }

        public Book[] GetBooksByUserId(int id)
        {
            User user = Users[id - 1];
            return user.Books;
        }
    }
}
