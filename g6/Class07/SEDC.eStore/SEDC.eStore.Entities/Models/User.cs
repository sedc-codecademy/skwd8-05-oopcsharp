using SEDC.eStore.Entities.BaseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.eStore.Entities.Models
{
    public class User : BaseEntity
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string City { get; set; }
        public Account Account { get; set; }
        public Cart Cart { get; set; }

        public User(string email, string password, string fullName)
            : base()
        {
            Email = email;
            Password = password;
            FullName = fullName;
            Cart = new Cart();
        }

        public void AddAccount(Account account)
        {
            Account = account;
        }
    }
}
