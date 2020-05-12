using Domain.Enums;
using Domain.ProductModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.CustomerModels
{
    public class Customer
    {
        // Constructors
        public Customer() { }
        public Customer(int id, string name, bool isLoyal)
        {
            Id = id;
            Name = name;
            IsLoyal = isLoyal;
            Products = new Product[0];
        }

        // Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsLoyal { get; set; }

        public Product[] Products;

        // Methods
        public void ReceiveProduct(Product product)
        {
            Array.Resize(ref Products, Products.Length + 1);
            Products[Products.Length - 1] = product;
        }

        public Task RequestProducts(Product product, int productCount, string description)
        {
            Console.WriteLine($"{Name} requested for {productCount} {product.Name}");
            return new Task(this, product, productCount, description);
        }
    }
}
