using System;
using System.Collections.Generic;
using System.Text;
using Domain.Enums;

namespace Domain.EmployeeModels
{
    public class Employee
    {
        //Constructors
        public Employee() { }
        public Employee(int id, string firstName, string lastName, Role role, int hours, double salary)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Role = role;
            Hours = hours;
            Salary = salary;
            OnHoliday = false;
        }

        //Properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; }
        public int Hours { get; set; } // per Month
        public double Salary { get; set; } //per Hour
        public bool OnHoliday { get; set; }

        //Methods
        public virtual string GetInfo()
        {
            string isOnHoliday = OnHoliday ? "" : "not ";
            return $"{FirstName} {LastName}: Salary: {GetMonthlySalary()}. Is {isOnHoliday}on holiday.";
        }

        public virtual double GetMonthlySalary()
        {
            return Salary * Hours;
        }

        public void GoOnHoliday()
        {
            OnHoliday = true;
            Console.WriteLine($"{FirstName} {LastName} went on holiday.");
        }

        public void ReturnFromHoliday()
        {
            OnHoliday = false;
            Console.WriteLine($"{FirstName} {LastName} returned from holiday.");
        }
    }
}
