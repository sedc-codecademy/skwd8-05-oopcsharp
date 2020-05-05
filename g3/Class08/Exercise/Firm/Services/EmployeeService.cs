using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class EmployeeService
    {
        //A method for creating an object Employee specified with its properties as parametars
        public Employee CreateEmployee(int id, string firstName, string lastName, Role role, int hours, double salary)
        {
            Employee newEmployee = new Employee(id, firstName, lastName, role, hours, salary);
            return newEmployee;
        }
        //An Array of Employees and a Role to be filtered by
        public Employee[] GetEmployeesByRole(Employee[] employees, Role role)
        {
            Employee[] roleEmployees = new Employee[0];

            foreach (var employee in employees)
            {
                if(employee.Role == role)
                {
                    Array.Resize(ref roleEmployees, roleEmployees.Length + 1);
                    roleEmployees[roleEmployees.Length - 1] = employee;
                }
            }
            return roleEmployees;
        }
        //Promote an Employee. An Employee and a role to be promoted to as parameters.
        public void PromoteAnEmployee (Employee employee, Role role)
        {
            employee.Role = role;
            Console.WriteLine($"{employee.FirstName} {employee.LastName} has been promoted to a {role}.");
        }
        //Let an Employee on vacation. An Employee which OnHoliday propertie is set to true.
        public void GoesOnGoliday(Employee employee)
        {
            employee.OnHoliday = true;
            Console.WriteLine($"{employee.FirstName} {employee.LastName} has gone on holiday.");
        }
        //Filters an Array of Employees by their Salary
        public Employee[] GetByGreaterSalary(Employee[] employees, double minSalary)
        {
            Employee[] salaryEmployees = new Employee[0];

            foreach (var employee in employees)
            {
                if (employee.Salary >= minSalary)
                {
                    Array.Resize(ref salaryEmployees, salaryEmployees.Length + 1);
                    salaryEmployees[salaryEmployees.Length - 1] = employee;
                }
            }
            return salaryEmployees;
        }
        //Adds an employee to the array provided in the Array
        public void AddEmployeeToAnArray(Employee[] employees, Employee emp)
        {
            Array.Resize(ref employees, employees.Length + 1);
            employees[employees.Length - 1] = emp;

            Console.WriteLine("The new employee has been added to the array. Now the array contains these employees:");
            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}");
            }
        }
    }
}
