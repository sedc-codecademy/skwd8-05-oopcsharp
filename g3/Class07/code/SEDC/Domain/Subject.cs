using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Subject
    {
        public Subject(string name, int classes, Student[] students)
        {
            Name = name;
            Classes = classes;
            Students = students;
            IsStarted = false;
        }

        public Subject(string name, int classes)
        {
            Name = name;
            Classes = classes;
            Students = new Student[] { };
            IsStarted = false;
        }

        public string Name { get; set; }
        public int Classes { get; set; }
        public Student[] Students { get; set; }
        public bool IsStarted { get; set; }
    }
}
