using System;

namespace SEDC.Class08.Example.Models
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

        public string Info()
        {
            return $"Product id: {Id}, name: {Name}, price: {Price}";
        }

        public static int GetIdGenerator()
        {
            return _idGenerator;
        }
    }
}
