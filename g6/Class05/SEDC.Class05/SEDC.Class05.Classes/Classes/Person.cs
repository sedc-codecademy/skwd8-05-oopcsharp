using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Class05.Classes.Classes
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public int GetAge()
        {
            return new DateTime().Year - DateOfBirth.Year;
        }

        public string GetPersonInfo()
        {
            return $"Name: {FirstName}, Last name: {LastName}, age: {GetAge()}";
        }

        public string SayHelloTo(string name)
        {
            return $"Hi, {name}. My name is {GetFullName()}";
        }
    }
}
