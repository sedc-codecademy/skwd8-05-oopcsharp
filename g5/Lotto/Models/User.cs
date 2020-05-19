using System;

namespace Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string CardNumber { get; set; }
        public float Balance { get; set; }

        public User()
        {
        }

        public User(string username, string cardNumber)
        {
            Id = Guid.NewGuid();
            Username = username;
            CardNumber = cardNumber;
            Balance = 1000f;
        }
    }
}
