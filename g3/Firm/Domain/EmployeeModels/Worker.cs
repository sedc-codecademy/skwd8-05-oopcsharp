using System;
using System.Collections.Generic;
using System.Text;
using Domain.Enums;
using Domain.ProductModels;

namespace Domain.EmployeeModels
{
    public class Worker : Employee
    {
        // Constructors
        public Worker() { }
        public Worker(int id, string firstName, string lastName, Role role, int hours, double salary, Manager manager) :
            base(id, firstName, lastName, role, hours, salary)
        {
            Manager = manager;
            Tasks = new Task[0];

            manager.AddWorker(this);
        }

        // Properties
        public Manager Manager { get; set; }

        public Task[] Tasks;

        // Methods
        public void AddTask(Task task)
        {
            Array.Resize(ref Tasks, Tasks.Length + 1);
            Tasks[Tasks.Length - 1] = task;
        }

        public void DoTasks()
        {
            foreach (Task task in Tasks)
            {
                if (!task.IsDone)
                {
                    Console.WriteLine($"Doing task: {task.Description}");

                    for (int i = 0; i < task.ProductCount; i++)
                    {
                        task.Customer.ReceiveProduct(task.Product);
                    }
                    
                    task.IsDone = true;
                }
            }
        }

        public override string GetInfo()
        {
            string isOnHoliday = OnHoliday ? "" : "not ";
            return $"{FirstName} {LastName}: Salary: {GetMonthlySalary()}. Manager: {Manager.FirstName} {Manager.LastName}. Is {isOnHoliday}on holiday.";
        }
    }
}
