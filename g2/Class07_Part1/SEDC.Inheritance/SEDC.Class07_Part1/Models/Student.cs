using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Class07_Part1.Models
{
    public class Student : Participant
    {
        //Specific only for student classs
        public int Group { get; set; }

        public Student()
        {

        }

        public Student(string firstName, string lastName)
            :base(firstName, lastName)
        {
        }

        public void FavouriteSubject(Subject subject)
        {
            switch (subject.Title)
            {
                case "C#Basic":
                    Console.WriteLine("COVID-19 break exercises.");
                    break;
                case "AJS":
                    Console.WriteLine("Star Wars app homework");
                    break;
                default:
                    break;
            }
        }
    }
}
