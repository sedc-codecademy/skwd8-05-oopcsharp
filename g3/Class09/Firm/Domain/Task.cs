using Domain.ProductModels;
using System;
using System.Collections.Generic;
using System.Text;
using Domain.CustomerModels;
using Domain.Enums;

namespace Domain
{
    public class Task
    {
        // Constructors
        public Task() { }
        public Task(Customer customer, Product product, int productCount, string description)
        {
            Customer = customer;
            Product = product;
            ProductCount = productCount;
            Description = description;
            IsDone = false;
        }

        // Properties
        public Customer Customer { get; set; }
        public Product Product { get; set; }
        public int ProductCount { get; set; }
        public string Description { get; set; }
        public bool IsDone { get; set; }
    }
}
