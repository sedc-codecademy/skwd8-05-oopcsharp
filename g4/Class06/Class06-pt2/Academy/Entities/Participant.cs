using Academy.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Academy
{
    public class Participant
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age{ get; set; }

        public AcademyRole Role{ get; set; }

        public Subject[] Subjects { get; set; }

        public Participant() { }

        public Participant(string firstName, string lastName, int age, AcademyRole role) 
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Role = role;
        }

        public void PrintParticipant()
        {
            Console.WriteLine($"This is Participant {FirstName} {LastName}, {Age} years old !");
        }
    }
}
