using SEDC.Class06.Excersise.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Execersise.Entities
{
    public class Student
    {
        public string Name { get; set; }
        public Academy Academy { get; set; }
        public Group Group { get; set; }

        public Student(string name, Academy academy, Group group)
        {
            Name = name;
            Academy = academy;
            Group = group;
        }

        public string GetInfo()
        {
            return $"Name: {Name} Academy: {Academy}";
        }
    }
}
