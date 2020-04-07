using AcademyApp.Enums;
using System;

namespace AcademyApp.Entities
{
    // C# - Inheritance -> One of the MAIN Pillars of OOP
    public class Trainer : Participant
    {
        // Specific just for the Trainer entity
        public Expertise Expertise { get; set; }

        private bool EnglishLanguage { get; set; }

        public Trainer()
        {
            Console.WriteLine("Constructor from TRAINER");
        }

        public Trainer(string firstName, string lastName)
            : base(firstName, lastName)
        {
            Console.WriteLine("Constructor with parameters from TRAINER");
            EnglishLanguage = true;
        }
    }
}
