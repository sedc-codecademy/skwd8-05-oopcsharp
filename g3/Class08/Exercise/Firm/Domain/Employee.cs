using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Employee
    {
        //Properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; }
        public int Hours { get; set; }
        public double Salary { get; set; } //per Hour
        public bool OnHoliday { get; set; }
        //Constructors
        public Employee()
        {

        }
        public Employee(int id, string firstName, string lastName, Role role, int hours, double salary) //, bool onHoliday
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Role = role;
            Hours = hours;
            Salary = salary;
            OnHoliday = false;
        }
        //Methods
        public virtual string PrintInfo()
        {
            return $"Employee {FirstName} {LastName} is on {Salary} salary";
        }

        public double GetMonthlySalary()
        {
            return Salary * Hours;
        }
        public void SetSalary(double salary)
        {
            Salary = salary;
            Console.WriteLine($"The new salary of the employee {FirstName} {LastName} is {salary}");
        }
        public void GoOnHoliday()
        {
            OnHoliday = true;
            Console.WriteLine($"Employee {FirstName}{LastName} is going on a holiday.");
        }
    }
}
