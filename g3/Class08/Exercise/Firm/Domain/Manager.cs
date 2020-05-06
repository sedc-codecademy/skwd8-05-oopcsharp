using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Manager : Employee
    {
        //Properties
        public Worker[] Workers { get; set; }
        //Constructors
        public Manager() : base()
        {

        }
        public Manager(int id, string firstName, string lastName, Role role, int hours, double salary, Worker[] workers) : base(id, firstName, lastName, role, hours, salary)
        {
            Workers = workers;
        }
        //Methods
        public string GiveTask(Worker worker)
        {
            string task = $"{FirstName} {LastName} is giving a task to {worker.FirstName} {worker.LastName}";

            return task;
        }
        public override string PrintInfo()
        {

            return $"Manager {FirstName} {LastName} is on {Salary} salary and is responsible for many workers."; //tobe overriden with collection of workers
        }
    }
}
