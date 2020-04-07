using AcademyApp.Enums;
using System;

namespace AcademyApp.Entities
{
    public class Participant
    {
        public Participant()
        {
            Console.WriteLine("Constructor from Participant");
        }

        public Participant(string firstName)
        {
            FirstName = firstName;
        }

        public Participant(string firstName, string lastName)
        {
            Console.WriteLine("Constructor with parameters from Participant");
            FirstName = firstName;
            LastName = lastName;
        }

        //FIELD -> PROPERTY
        //protected int Age;
        protected int Age { get; set; }

        //FIELDS
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Subject[] Subjects { get; set; }
        public AcademyRole Role { get; set; }

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