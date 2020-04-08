using SEDC.eStore.Entities.BaseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.eStore.Entities.Models
{
    public class Cart : BaseEntity
    {
        private Product[] _products;

        public int TotalPrice { get; set; }

        public Cart()
            : base()
        {
            _products = new Product[1];
            TotalPrice = 0;
        }

        public Product[] GetProducts()
        {
            return _products;
        }

        public void AddProduct(Product product)
        {
            if(_products.Length == 1 && _products[0] == null)
            {
                _products[0] = product;
            }
            else
            {
                Array.Resize(ref _products, _products.Length + 1);
                _products[_products.Length - 1] = product;
            }
            TotalPrice += product.Price;
        }
    }
}
