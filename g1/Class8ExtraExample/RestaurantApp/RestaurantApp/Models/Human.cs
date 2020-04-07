using RestaurantApp.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantApp.Models
{
    public class Human
    {
        public Human()
        {

        }

        public Human(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public string FirstName;
        public string LastName;
        public int Age;
        public Gender Gender;
    }
}
