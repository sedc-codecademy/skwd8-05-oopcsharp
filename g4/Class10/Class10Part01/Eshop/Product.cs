using System;
using System.Collections.Generic;
using System.Text;

namespace Eshop
{
    public class Product
    {
        private static int _idGenerator = 0;
        public int Id { get; set; }
        public string Name { get; set; }

        public double Price { get; set; }

        public Product(string name, double price)
        {
            _idGenerator++;
            Id = _idGenerator;
            Name = name;
            Price = price;
        }
    }
}
