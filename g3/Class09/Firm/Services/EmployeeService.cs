using System;
using System.Collections.Generic;
using System.Text;
using Domain.CustomerModels;
using Domain.EmployeeModels;
using Domain.Enums;

namespace Services
{
    public class EmployeeService
    {
        public EmployeeService()
        {
            helper = new HelperService();
        }

        private HelperService helper { get; set; }

        #region Manager methods
        public Manager CreateManager(string firstName, string lastName, double salary)
        {
            return new Manager(helper.GenerateId(), firstName, lastName, Role.Manager, 160, salary);
        }
        #endregion

        #region Sales methods
        public Sales CreateSalesPerson(string firstName, string lastName, int hours, double salary, double bonus)
        {
            return new Sales(helper.GenerateId(), firstName, lastName, Role.Sales, hours, salary, bonus);
        }

        public Customer FindCustomer(Sales sales, Manager manager)
        {
            Customer newCustomer = new Customer(helper.GenerateId(), helper.RandomBusinessName(), helper.RandomBool());

            sales.AddCustomer(newCustomer);
            manager.AddCustomer(newCustomer);

            return newCustomer;
        }
        #endregion

        #region Worker methods
        public Worker CreateWorker(string firstName, string lastName, double salary, Manager manager)
        {
            return new Worker(helper.GenerateId(), firstName, lastName, Role.Worker, 160, salary, manager);
        }
        #endregion

    }
}
