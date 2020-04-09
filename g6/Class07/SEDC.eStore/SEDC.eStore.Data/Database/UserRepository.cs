using SEDC.eStore.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.eStore.Data.Database
{
    public class UserRepository : Database
    {
        public UserRepository()
            : base()
        {
        }

        public User GetUserById(int userId)
        {
            foreach (User user in Users)
            {
                if(user.Id == userId)
                {
                    return user;
                }
            }
            return null;
        }

        public User GetUserByEmail(string email)
        {
            foreach (User user in Users)
            {
                if(user.Email == email.ToLower().Trim())
                {
                    return user;
                }
            }
            return null;
        }
    }
}
