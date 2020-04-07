using System;

namespace AcademyApp.Entities
{
    // C# - Inheritance -> One of the MAIN Pillars of OOP
    public class Student : Participant
    {
        // Specific just for the Student entity
        public int Group { get; set; }

        public void FavouriteHomework(Subject subject)
        {
            switch (subject.Title)
            {
                case "C# Basic":
                    Console.WriteLine("Traffic light homework :))!");
                    break;
                default:
                    break;
            }
        }
    }
}
