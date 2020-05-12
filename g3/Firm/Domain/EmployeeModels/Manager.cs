using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using Domain.CustomerModels;
using Domain.Enums;

namespace Domain.EmployeeModels
{
    public class Manager : Employee
    {
        // Constructors
        public Manager() { }
        public Manager(int id, string firstName, string lastName, Role role, int hours, double salary) :
            base(id, firstName, lastName, role, hours, salary)
        {
            Workers = new Worker[0];
            Customers = new Customer[0];
        }

        // Properties
        public string Department { get; set; }
        public Worker[] Workers;
        public Customer[] Customers;

        // Methods
        public void AddWorker(Worker worker)
        {
            Array.Resize(ref Workers, Workers.Length + 1);
            Workers[Workers.Length - 1] = worker;
        }

        public void AddCustomer(Customer customer)
        {
            Array.Resize(ref Customers, Customers.Length + 1);
            Customers[Customers.Length - 1] = customer;
        }

        public void AssignTask(Worker worker, Task task)
        {
            worker.AddTask(task);
        }

        public void PromoteWorker(Worker worker, double amount)
        {
            worker.Salary += amount;
            Console.WriteLine($"Congratulations! {worker.FirstName} {worker.LastName} got a promotion");
        }
    }
}
