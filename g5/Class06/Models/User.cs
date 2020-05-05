using System;

namespace Models
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public User(string username)
        {
            Username = username;
            Random rnd = new Random();
            Password = rnd.Next(1000, 9999).ToString();
        }

        public User() { }
    }
}
