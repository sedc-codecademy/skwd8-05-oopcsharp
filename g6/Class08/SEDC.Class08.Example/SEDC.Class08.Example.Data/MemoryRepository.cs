using SEDC.Class08.Example.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.Class08.Example.Data
{
    public class MemoryRepository
    {
        private Dictionary<string, Product> _products;

        public MemoryRepository()
        {
            _products = new Dictionary<string, Product>();
            var products = new List<Product>
            {
                new Product("Ball", 10),
                new Product("Kayak", 220),
                new Product("Flag", 5.5)
            };

            foreach (var product in products)
            {
                AddProduct(product);
            }
        }

        public void AddProduct(Product product)
        {
            _products[product.Name] = product;
        }

        public void DeleteProduct(Product product)
        {
            _products.Remove(product.Name);
        }

        public List<Product> GetAllProducts()
        {
            List<Product> list = new List<Product>();
            foreach (Product p in _products.Values)
            {
                list.Add(p);
            }
            return list;
        }

        // This is similar to GetAllProducts and its not necessary
        public List<Product> Products => _products.Values.ToList();
        
        public Product GetProduct(string name)
        {
            return _products[name];
        }

        // This is similar to GetProduct and its not necessary
        // keyword this represents the instance of the object(object that we are working with)
        public Product this[string name] => _products[name];
    }
}
