using System;
using System.Collections.Generic;
using System.Text;

namespace Eshop
{
    public static class ProductsService
    {
        // A C# static class is a class that can't be instantiated. 
        // A static class can contain static members only. 
        // You can‘t create an object for the static class.
        // We do not use the NEW keyword.

        public static List<Product> GetAllProducts()
        {
            return new List<Product>()
            {
                new Product("Bread", 28),
                new Product("Milk", 50),
                new Product("Beer", 34.50),
                new Product("Nutella", 99.99),
                new Product("Yoghurt", 60),
                new Product("Flour", 25),
                new Product("Sugar", 12),
                new Product("Bacon", 76.32)
            };
        }
    }
}
