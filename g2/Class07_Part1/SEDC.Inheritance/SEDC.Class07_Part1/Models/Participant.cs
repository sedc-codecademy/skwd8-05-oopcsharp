using SEDC.Class07_Part1.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Class07_Part1.Models
{
    public class Participant
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Role Role { get; set; }
        public Subject[] Subjects { get; set; }

        // 'Protected' property, accesible in child classes and not outside in the Main() method
        protected int AccountBalance { get; set; }

        //Example of types of array
        //public string[] Subjects { get; set; }
        //public int[] Subjects { get; set; }

        public Participant()
        {
            Console.WriteLine("Constructor from Participant");
        }

        public Participant(string firstName, string lastName)
        {
            Console.WriteLine("Constructor with parameters from Participant");
            FirstName = firstName;
            LastName = lastName;
        }

        public Participant(string firstName, string lastName, int age)
        {
            Console.WriteLine("Constructor with parameters from Participant");
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public void PrintParticipantInfo()
        {
            if (Role == Role.Assistant)
            {
                Console.WriteLine($"{FirstName} {LastName} is an {Role}");
            }
            else
            {
                Console.WriteLine($"{FirstName} {LastName} is a {Role}");
            }
        }
    }
}
