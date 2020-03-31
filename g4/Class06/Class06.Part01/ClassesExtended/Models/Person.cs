using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExtended.Models
{
    public class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName{ get; set; }

        private int Age { get; set; }

        // default constructor
        public Person() { }

        // second constructor
        public Person(string firstName, string lastName)
        {
            // FullName = firstName + " " + lastName;
            FirstName = firstName;
            LastName = lastName;
            //FullName = $"{firstName} {lastName}";
        }

        // third constructor
        public Person(string fullName, int age)
        {
            FullName = fullName;
            Age = age;
        }

        public void CalculateAge (DateTime dateOfBirth) // 29.03
        {
            DateTime currentDate = DateTime.Now; // 30.03
            int age = 0;
            if (dateOfBirth.Month <= currentDate.Month)
            {
                if (dateOfBirth.Month == currentDate.Month)
                {
                    if (dateOfBirth.Day > currentDate.Day)
                    {
                        age = (currentDate.Year - dateOfBirth.Year) - 1;
                    } else
                    {
                        age = currentDate.Year - dateOfBirth.Year;
                    }
                }
                 
            } else
            {
                age = currentDate.Year - dateOfBirth.Year;
            }
            Age = age;
        }

        public string PrintInfo()
        {
            return $"The person is {FirstName} {LastName}";
        }

        public void PrintFullInfo()
        {
            Console.WriteLine($"The person {FullName} has {Age} years !");
        }
    }
}
