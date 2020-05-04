using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Class08.LINQ.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public int Price { get; set; }

        public Product(int id, string name, int price, Category category)
        {
            Id = id;
            Name = name;
            Price = price;
            Category = category;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}, Category: {Category}, Price: {Price}");
        }
    }
}
