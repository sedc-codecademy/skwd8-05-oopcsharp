using SEDC.Class06_Part1.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Class06_Part1.Models
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        //bad practice
        //public string Academy { get; set; }

        //better solution
        public Academy Academy { get; set; }
        public string Subject { get; set; }
        public Roles Role { get; set; }
    }
}
