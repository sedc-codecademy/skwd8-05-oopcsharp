using Domain;
using Domain.CustomerModels;
using Domain.EmployeeModels;
using Domain.Enums;
using Domain.ProductModels;
using Services;
using System;
using System.Collections.Generic;

namespace FirmApp
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeService employeeService = new EmployeeService();
            ProductService productService = new ProductService();

            Product[] productsCatalogue = new Product[] {
                productService.CreateProduct("Laptop", "Asus", ProductType.Electronics, 300),
                productService.CreateProduct("PC", "Acer", ProductType.Electronics, 350),
                productService.CreateProduct("Chocolate Cakes", "Oreo", ProductType.Food, 3),
                productService.CreateProduct("Chocolate", "Milka", ProductType.Food, 5),
                productService.CreateProduct("Office", "Microsoft", ProductType.Virtual, 120),
                productService.CreateProduct("Webex", "Cisco", ProductType.Virtual, 20),
                productService.CreateProduct("Skype", "Microsoft", ProductType.Virtual, 0)
            };

            Manager dejan = employeeService.CreateManager("Dejan", "Blazheski", 100);
            Manager alek = employeeService.CreateManager("Aleksandar", "Kocevski", 100);

            Sales ariah = employeeService.CreateSalesPerson("Ariah", "Redman", 8, 20, 10);
            Sales franco = employeeService.CreateSalesPerson("Franco", "Davenport", 8, 20, 15);
            Sales tiago = employeeService.CreateSalesPerson("Tiago", "Garrett", 7, 30, 13);

            Worker dexter = employeeService.CreateWorker("Dexter", "Fraser", 10, dejan);
            Worker leah = employeeService.CreateWorker("Leah", "Sweet", 12, dejan);
            Worker erik = employeeService.CreateWorker("Erik", "Joseph", 13, dejan);
            Worker joe = employeeService.CreateWorker("Joe", "Glover", 11, alek);
            Worker ashleigh = employeeService.CreateWorker("Ashleigh", "Bate", 10, alek);

            Customer customer1 = employeeService.FindCustomer(ariah, dejan);
            Customer customer2 = employeeService.FindCustomer(franco, dejan);
            Customer customer3 = employeeService.FindCustomer(tiago, alek);

            Task customerRequest1 = customer1.RequestProducts(productsCatalogue[2], 3, "Need 3 oreos fast. We are very hungry");
            Task customerRequest2 = customer2.RequestProducts(productsCatalogue[0], 5, "We need 5 personal laptops");
            Task customerRequest3 = customer3.RequestProducts(productsCatalogue[6], 1, "We need a communication app.");

            dejan.AssignTask(dexter, customerRequest1);
            dejan.AssignTask(dexter, customerRequest2);
            alek.AssignTask(joe, customerRequest3);

            foreach (Worker worker in dejan.Workers)
            {
                worker.DoTasks();
            }

            foreach (Product product in customer1.Products)
            {
                Console.WriteLine($"{product.Name}, {product.Brand}, {product.Price}$");
            }

            foreach (Product product in customer2.Products)
            {
                Console.WriteLine($"{product.Name}, {product.Brand}, {product.Price}$");
            }

            #region QueryingCollections
            Manager petko = employeeService.CreateManager("Petko", "Petkovski", 200);
            Manager stanka = employeeService.CreateManager("Stanka", "Stankovska", 300);
            List<Manager> managers = new List<Manager> {alek, dejan, petko, stanka};

            List<Sales> salesPeople = new List<Sales> { ariah, franco, tiago };

            List<Worker> workers = new List<Worker> { dexter, leah, erik, joe, ashleigh };

            Console.WriteLine($"Due to the COVID-19 situation unfortunately we will have to let go Manager: {alek.FirstName} {alek.LastName}");
            Console.WriteLine($"Now the managers list is as following:");
            List<Manager> managersToDel = employeeService.DeleteManagerFromList(managers, alek);
            foreach (var manager in managersToDel)
                Console.WriteLine($"{manager.FirstName} {manager.LastName}");

            Console.WriteLine($"Due to the COVID-19 situation unfortunately we will have to let go SalesPerson: {ariah.FirstName} {ariah.LastName}");
            Console.WriteLine($"Now the SalesPeople list is as following:");
            foreach (var salesPerson in employeeService.DeleteSalesPersonFromList(salesPeople, ariah))
                Console.WriteLine($"{salesPerson.FirstName} {salesPerson.LastName}");

            
            Worker workerLetGo = employeeService.DeleteWorkerFromList(workers, leah);
            if (workerLetGo != null)
            {
                Console.Write($"Due to the COVID-19 situation unfortunately we will have to let go Worker:  ");
                Console.WriteLine($"{workerLetGo.FirstName} {workerLetGo.LastName}");
            }

            Console.WriteLine($"Now the Workers list is as following:");
            foreach (var worker in workers)
                Console.WriteLine($"{worker.FirstName} {worker.LastName}");

            Console.WriteLine($"Please type the maximum allowed salary for a worker in this Firm!");
            double salary = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Due to the COVID-19 situation, unfortunately we will have to let go every worker with a salary greater than:  {salary}");
            employeeService.DeleteWorkersWithSalaryGreaterThan(workers, salary);
            Console.WriteLine($"Now the Workers list is as following:");
            foreach (var worker in workers)
                Console.WriteLine($"{worker.FirstName} {worker.LastName}");

            #endregion

            Console.ReadLine();
        }
    }
}
