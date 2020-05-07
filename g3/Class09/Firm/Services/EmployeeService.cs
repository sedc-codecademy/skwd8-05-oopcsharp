using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
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

        public List<Manager> DeleteManagerFromList(List<Manager> managers, Manager managerToDelete)
        {
            managers.Remove(managerToDelete);
            return managers;
        }
        #endregion

        #region Sales methods
        public Sales CreateSalesPerson(string firstName, string lastName, int hours, double salary, double bonus)
        {
            return new Sales(helper.GenerateId(), firstName, lastName, Role.Sales, hours, salary, bonus);
        }
        public List<Sales> DeleteSalesPersonFromList(List<Sales> salesPeople, Sales salesPersonToDel)
        {
            for (int i = 0; i < salesPeople.Count; i++)
            {
                if (salesPeople[i].Id == salesPersonToDel.Id)
                    salesPeople.RemoveAt(i);
            }
            return salesPeople;
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
        public Worker DeleteWorkerFromList(List<Worker> workers, Worker workerToDel)
        {
            for (int i = 0; i < workers.Count; i++)
            {
                if (workers[i].Id == workerToDel.Id)
                {
                    workers.RemoveAt(i);
                    return workerToDel;
                }
                    
            }
            return null;
        }
        public List<Worker> DeleteWorkersWithSalaryGreaterThan(List<Worker> workers, double salary)
        {
            for (int i = 0; i < workers.Count; i++)
            {
                if (workers[i].Salary > salary)
                {
                    workers.RemoveAt(i);
                    i--;
                }
                    
            }
            return workers;
        }
        #endregion

    }
}
