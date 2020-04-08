using SEDC.eStore.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.eStore.Data.Database
{
    public class ProductRepository : Database
    {
        public ProductRepository()
            : base()
        {
        }

        public Product[] GetProducts()
        {
            return Products;
        }

        public Product GetProductById(int productId)
        {
            foreach (Product product in Products)
            {
                if(product.Id == productId)
                {
                    return product;
                }
            }
            return null;
        }
    }
}
