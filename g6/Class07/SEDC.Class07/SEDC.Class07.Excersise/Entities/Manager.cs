using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Class07.Excersise.Entities
{
    public class Manager : Empoyee
    {
        public Manager(string firstName, string lastName, double baseSalary)
            : base(firstName, lastName, baseSalary)
        { 
        }

        public double GetSalary()
        {
            return Salary;
        }

        // Hard coded not good

        //public Manager()
        //    :base("Trajan", "Stevkovski", 1000)
        //{

        //}

        // Not valid case

        //public Manager()
        //    : base(firstName, lastName, baseSalary)
        //{

        //}


    }
}
