using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    // Example for Domain Model
    public class Human
    {
        public string Name { get; set; }
        public UserModel user { get; set; }
        public int Age { get; set; }

        // Methods like this should be kept to a minimum, or not be a part of a domain model
        public string GetAge()
        {
            return $"{Age} years";
        }
    }
}
