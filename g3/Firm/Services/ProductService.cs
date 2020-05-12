using System;
using System.Collections.Generic;
using System.Text;
using Domain.Enums;
using Domain.ProductModels;

namespace Services
{
    public class ProductService
    {
        public ProductService()
        {
            helper = new HelperService();
        }

        private HelperService helper { get; set; }

        public Product CreateProduct(string name, string brand, ProductType productType, double price)
        {
            return new Product(helper.GenerateId(), name, brand, productType, price);
        }
    }
}
