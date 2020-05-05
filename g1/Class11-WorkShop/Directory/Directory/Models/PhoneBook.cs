using System;
using System.Collections.Generic;
using System.Text;

namespace Directory.Models
{
    public class PhoneBook
    {
        public PhoneBook()
        {
            Directory = new Dictionary<User, string>();
        }
        public Dictionary<User, string> Directory { get; set; }

        public string SearchContactNumber(User user)
        {
            foreach (var contact in Directory)
            {
               if (contact.Key.Name == user.Name)
               {
                  return contact.Value;
               }
            }
            return "No such user!";
        }
        public void PrintContacts()
        {
            foreach (var contact in Directory)
            {
                Console.WriteLine($"Name: {contact.Key.Name}, PhoneNumber: {contact.Value}");
            }
        }
    }
}
