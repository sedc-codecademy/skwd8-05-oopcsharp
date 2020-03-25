using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Class05.Classes.Classes
{
    public class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int SSN { get; set; }
        private string FullName { get; set; }
    }
}
