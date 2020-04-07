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
        public string Role { get; set; }

        public User()
        {
            Role = "user";
        }

        public string FullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
