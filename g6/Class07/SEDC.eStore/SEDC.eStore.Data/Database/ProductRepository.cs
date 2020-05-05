using SEDC.eStore.Entities.Enums;
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

        // start

        public Product[] GetProductsByCategory(Category category)
        {
            // your code here
            return null;
        }

        public Product[] GetProductsByPriceRange(int min, int max)
        {
            // youe code here
            return null;
        }

        public Product[] GetProductsByName(string productNamePart)
        {
            // your code here
            return null;
        }

        public int[] GetProductsIds()
        {
            // your code here
            return null;
        }

        public int GetProductPrice(int productId)
        {
            // your code here
            return 0;
        }

        public Product GetCheapestProduct()
        {
            // your code here
            return null;
        }

        public Product GetMostExpensiveProduct()
        {
            // your code here
            return null;
        }

        public void AddProduct(Product product)
        {
            // your code here
        }

        public void RemoveProduct(int productId)
        {
            // your code here
        }

        // end
    }
}
