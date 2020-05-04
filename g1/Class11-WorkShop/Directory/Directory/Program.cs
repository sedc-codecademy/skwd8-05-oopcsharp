using Directory.Models;
using System;
using System.Collections.Generic;

namespace Directory
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneBook phonebook = new PhoneBook();
            // phonebook.Directory = new Dictionary<User, string>();
            phonebook.Directory
                .Add(new User(){ Name = "Miodrag", Adress = "Aerodrom" },
                    "077-655-555");
            phonebook.Directory
                .Add(new User() { Name = "Goce", Adress = "Centar" },
                    "078-665-111");
            phonebook.Directory
                .Add(new User() { Name = "John", Adress = "Chicago" },
                    "070-100-007");

            var user = new User() { Name = "Miodrag", Adress = "Aerodrom" };

            Console.WriteLine(phonebook.SearchContactNumber(user));
            Console.WriteLine("-----------------------------------");

            phonebook.PrintContacts();

            Console.ReadLine();

        }
    }
}
