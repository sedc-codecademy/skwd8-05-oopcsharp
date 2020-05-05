using CompanyLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyLibrary.Models
{
    public class Manager : Employee
    {
        private double Bonus { get; set; }

        public Manager()
        {
        }

        public Manager(string first, string last)
        {
            FirstName = first;
            LastName = last;
            Salary = 1000;
            Role = RoleType.Manager;
        }

        public void AddBonus(double bonus)
        {
            Bonus = bonus;
        }

        public override double GetSalary()
        {
            return Salary += Bonus;
        }
    }
}
