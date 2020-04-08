using SEDC.Class06_Part1.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Class06_Part1.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        //public string Role { get; set; }

        //use enum instead of string Role (Good practice)
        public Roles Role { get; set; }
        public string[] Hobbies { get; set; }

        public Person()
        {
            Hobbies = new string[2] { "Book reading", "Movie watch" };
        }

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Hobbies = new string[2] { "Book reading", "Movie watch"};
        }

        public Person(string firstName, string lastName, string city)
        {
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }

        public Person(string firstName, string lastName, int age, string city, string country, Roles role)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            City = city;
            Country = country;
            Role = role;
        }
    }
}
