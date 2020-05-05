using Domain;
using Domain.CustomerModels;
using Domain.EmployeeModels;
using Domain.Enums;
using Domain.ProductModels;
using Services;
using System;

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

            Console.ReadLine();
        }
    }
}
