using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Worker : Employee
    {
        //Properties
        public Manager Manager { get; set; }
        //Constructors
        public Worker() : base()
        {

        }
        public Worker(int id, string firstName, string lastName, Role role, int hours, double salary, Manager manager) : base(id,firstName,lastName,role,hours,salary)
        {
            Manager = manager;
        }
        //Methods
        public string DoTask()
        {
            //string task = $"{FirstName} {LastName} is giving a task to {Id}";

            return "task done";
        }
        public override string PrintInfo()
        {
            return $"Worker {FirstName} {LastName} is on {Salary} salary and has a manager {Manager}";
        }
    }
}
