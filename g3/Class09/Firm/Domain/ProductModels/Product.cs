using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ProductModels
{
    public class Product
    {
        // Constructors
        public Product() { }
        public Product(int id, string name, string brand, ProductType productType, double price)
        {
            Id = id;
            Name = name;
            Brand = brand;
            ProductType = productType;
            Price = price;
            OnPromotion = false;
        }

        // Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public ProductType ProductType { get; set; }
        public double Price { get; set; }
        public bool OnPromotion { get; set; }

        // Methods
        public void SetOnPromotion()
        {
            OnPromotion = true;
        }

        public void SetOffPromotion()
        {
            OnPromotion = false;
        }
    }
}
