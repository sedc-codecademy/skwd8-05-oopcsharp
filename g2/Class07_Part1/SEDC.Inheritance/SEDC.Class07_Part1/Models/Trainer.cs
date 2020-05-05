using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Class07_Part1.Models
{
    public class Trainer : Participant
    {
        //Specific only for trainer class
        public string Expertise { get; set; }
        public bool SpeackEnlgishLanguage { get; set; }

        public Trainer()
        {
            Console.WriteLine("Constructor from TRAINER!");
        }

        public Trainer(string firstName, string lastName)
            : base (firstName, lastName)
        {
            Console.WriteLine("Constructor with parameters from TRAINER!");
            SpeackEnlgishLanguage = true;
        }

        public Trainer(string firstName, string lastName, int age)
            : base(firstName, lastName, age)
        {
            //Accesible from parent class because of the 'protected' modifier
            AccountBalance = 0;
        }

        //Constructor needed only for Trainer
        public Trainer(string expertise)
        {
            Expertise = expertise;
        }
    }
}
