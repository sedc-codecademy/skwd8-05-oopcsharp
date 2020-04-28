using System;

namespace Class07
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        private string Embg { get; set; }

        public Person(string firstName, string lastName, DateTime birthDate, string embg)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Embg = embg;
        }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Person() { }

        public string GetInfo()
        {
            return $"{FirstName} {LastName}";
        }

        private string PrintEmbg()
        {
            return $"EMBG: {Embg}";
        }
    }
}
