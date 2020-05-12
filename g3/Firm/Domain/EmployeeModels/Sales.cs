using System;
using System.Collections.Generic;
using System.Text;
using Domain.CustomerModels;
using Domain.Enums;

namespace Domain.EmployeeModels
{
    public class Sales : Employee
    {
        // Constructors
        public Sales() { }
        public Sales(int id, string firstName, string lastName, Role role, int hours, double salary, double successSaleRevenue) :
            base(id, firstName, lastName, role, hours, salary)
        {
            SuccessSaleRevenue = successSaleRevenue;
            FoundCustomers = new Customer[0];
        }

        // Properties
        public double SuccessSaleRevenue { get; set; }

        public Customer[] FoundCustomers;

        // Methods
        public void AddCustomer(Customer customer)
        {
            Array.Resize(ref FoundCustomers, FoundCustomers.Length + 1);
            FoundCustomers[FoundCustomers.Length - 1] = customer;
        }
        public override double GetMonthlySalary()
        {
            return Salary * Hours * SuccessSaleRevenue;
        }
    }
}
