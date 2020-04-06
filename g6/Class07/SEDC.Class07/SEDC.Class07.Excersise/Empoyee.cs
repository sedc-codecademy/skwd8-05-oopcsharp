using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Class07.Excersise
{
    public class Empoyee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        protected double Salary { get; set; }

        public Empoyee(string fname, string lname, double salary)
        {
            FirstName = fname;
            LastName = lname;
            Salary = salary;
        }

        public void PrintInfo()
        {
            // prints info
        }
    }
}
