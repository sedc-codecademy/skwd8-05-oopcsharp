using System;
using System.Linq;
using Models;
using Services.Data;

namespace Services
{
    public class UserService
    {
        public void AddNewUser(string name, string cardNumber)
        {
            if (DataHelper.Users.Any(x => x.CardNumber == cardNumber))
            {
                throw new Exception("Already register user.");
            }

            if (DataHelper.Users.Any(x => x.Username == name))
            {
                throw new Exception("Username is already in use.");
            }

            DataHelper.Users.Add(new User(name, cardNumber));
        }

        public User Login(string card)
        {
            User user = DataHelper.Users.FirstOrDefault(x => x.CardNumber == card);

            if (user == null)
            {
                throw new Exception("The card does not exist.");
            }

            return user;
        }
    }
}
