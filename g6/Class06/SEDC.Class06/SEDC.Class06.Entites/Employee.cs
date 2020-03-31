using SEDC.Class06.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Class06.Entites
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Salary { get; set; }
        public Role Role { get; set; }
        public DateTime CreateOn { get; set; }

        public Employee()
        {
            CreateOn = DateTime.Now;
        }

        public Employee(string firstName, string lastName, double salary, Role role)
        {
            CreateOn = DateTime.Now;
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            Role = role;
        }

        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            CreateOn = DateTime.Now;
        }

        public string PrintInfo()
        {
            return $"Fullname: {FirstName} {LastName} Role: {Role}";
        }
    }
}
