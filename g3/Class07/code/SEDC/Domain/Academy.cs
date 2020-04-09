using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Academy
    {
        public Academy(string name, string description, Subject[] subjects)
        {
            Name = name;
            Description = description;
            Subjects = subjects;
            IsStarted = false;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public Subject[] Subjects { get; set; }
        public bool IsStarted { get; set; }
    }
}
