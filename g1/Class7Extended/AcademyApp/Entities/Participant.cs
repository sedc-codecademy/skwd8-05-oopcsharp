using AcademyApp.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademyApp.Entities
{
    public class Participant
    {
        public Participant()
        {

        }

        public Participant(string firstName)
        {
            FirstName = firstName;
        }

        public Participant(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        private int Age;

        public string FirstName;
        public string LastName;
        public DateTime DateOfBirth;

        public Subject[] Subjects;

        public AcademyRole Role;

        public void Greetings()
        {
            Console.WriteLine($"Hello, I`m {FirstName} {LastName}");

            HowOld(DateTime.Today);
            Console.WriteLine($"Also, I`m {Age} years old. :)");
        }

        private void HowOld(DateTime today)
        {
            if (today.Month < DateOfBirth.Month)
                Age = today.Year - DateOfBirth.Year - 1;
        }

        public void PrintFullName()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }
    }
}
