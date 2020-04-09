using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Academy
    {
        public Academy(string name, string desc, Subject[] subjects)
        {
            Subjects = subjects;
            IsStared = false;
        }

        public Subject[] Subjects { get; set; }
        public bool IsStared { get; set; }
    }
}
