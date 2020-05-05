using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Class07_Part1.Models
{
    public class Assistant : Participant
    {
        //Specific only for assistant
        public string[] Homeworks { get; set; }

        public Assistant()
        {

        }

        public Assistant(string firstName, string lastName, int age)
            : base (firstName, lastName, age)
        {
            Homeworks = new string[] { "H1", "H2" };
        }
    }
}
