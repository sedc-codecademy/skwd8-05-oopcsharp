using SEDC.Class08.LINQ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.Class08.LINQ.Database
{
    public class ProductRepository : Database
    {
        public List<Product> GetProductsByCategory(Category category)
        {
            var productList = new List<Product>();
            
            foreach (var product in Products)
            {
                if(product.Category == category)
                {
                    productList.Add(product);
                }
            }

            return productList;
        }

        public List<Product> GetProductsByCategoryMethodSyntax(Category category)
        {
           // //not executed query
           //var products = Products
           //    .Where(product => product.Category == category);

           // //executed query
           // var productsToList = Products
           //     .Where(product => product.Category == category)
           //     .ToList();

            return Products
                .Where(product => product.Category == category)
                .ToList();
        }

        public List<Product> GetProductsByCategoryQuerySyntax(Category category)
        {
            var products = from product in Products
                           where product.Category == category
                           select product;
            
            return products.ToList();
        }
    }
}
