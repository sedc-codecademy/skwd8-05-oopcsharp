using System;
using Domain;
using Services;

namespace Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            #region Employees
            // This is how we create/instantiate an object with the constructor from the particular class
            Employee alek = new Employee(1, "Aleksandar", " Kocevski", Role.Worker, 40, 500); //true

            Worker worker1 = new Worker(); //This is how to instantiate an empty object 
            Worker worker2 = new Worker(); //-------||---------
            Worker[] workers = new Worker[]{ worker1, worker2 }; //This is an Array of workers (Class Worker)

            Manager deki = new Manager(2, "Dejan", "Blazheski", Role.Manager, 40, 1500, workers); // deki is an object from the Manager class. It contains the workers his responsible for by inserting them as an Array in the constructor
            Worker pero = new Worker(3, "Petar", "Petkovski", Role.Worker, 40, 500, deki); // pero is a worker whose manager is deki

            alek.SetSalary(800.00); // A Method from the Class Employee. We use to set or update the Salary of the particular employee
            deki.GiveTask(pero); // This is how the Manager deki is giving a task to a worker. The parameter is used to specify to whom is the task given to

            pero.DoTask(); // The worker is sayin that the job is DONE

            alek.GoOnHoliday(); // This is how we set an employee to go on holiday. By default this Propertie is false

            EmployeeService empSer = new EmployeeService(); // Employee service instantiation.

            Employee[] employees = new Employee[] { // Creating and populating (at the same time) an Employee Array using the service method
            empSer.CreateEmployee(4, "Ime", "Prezime", Role.Worker, 40, 700),
            empSer.CreateEmployee(5, "Ime2", "Prezime2", Role.Manager, 40, 1000),
            empSer.CreateEmployee(6, "Ime3", "Prezime3", Role.Worker, 40, 500),
            empSer.CreateEmployee(7, "Ime4", "Prezime4", Role.Manager, 40, 800)
            };

            Role newRole = Role.Manager; //Worker
            Employee[] employeesByRole = empSer.GetEmployeesByRole(employees, newRole);

            foreach (var employee in employeesByRole)
            {
               Console.WriteLine(employee.PrintInfo());
            }
            //THIS IS NEW. WILL BE DISCUSSED ON THE NEXT CLASS
            empSer.PromoteAnEmployee(employees[0], Role.SalesWorker); //call for the service method doing the promotion

            empSer.GoesOnGoliday(employees[1]); // Let an Employee go on a holiday. Call for the particular service method

            double minSalary = 800.00;
            //call to the service method filtering the employees by their salary.
            //The variable is used so you can easily query the Array for any given salary just by changing the value of the minSalary variable
            Console.WriteLine($"The employees with a salary equal or greater than {minSalary} are the following:");
            foreach (var employee in empSer.GetByGreaterSalary(employees, minSalary))
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}");
            }

            //Creating a new Employee and adding it to the Array of employees
            Employee mitre = empSer.CreateEmployee(8, "Mitre", "Mitrev", Role.Worker, 36, 750);
            Console.WriteLine(mitre.PrintInfo());
            empSer.AddEmployeeToAnArray(employees, mitre);

            #endregion Employees

            #region Products
            #endregion

            Console.ReadLine();
        }
    }
}
