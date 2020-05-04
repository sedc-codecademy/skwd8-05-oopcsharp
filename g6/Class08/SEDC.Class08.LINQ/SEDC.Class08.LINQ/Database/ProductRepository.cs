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

        public List<Product> FilterProductsByPriceRangeMethodSyntax(int min, int max)
        {
            return Products
                .Where(product => product.Price >= min && product.Price <= max)
                .ToList();
        }

        public List<Product> FilterProductsByPriceRangeQuerySyntax(int min, int max)
        {
            var products = from product in Products
                           where product.Price >= min && product.Price <= max
                           select product;

            return products.ToList();
        }

        public List<int> GetProductIdsMethodSyntax()
        {
            //var listOfIds = new List<int>();

            //foreach (var product in Products)
            //{
            //    listOfIds.Add(product.Id);
            //}

            //return listOfIds;

            return Products
                .Select(product => product.Id)
                .ToList();
        }

        public List<int> GetProductIdsQuerySyntax()
        {
            var productIds = from product in Products
                             select product.Id;

            return productIds.ToList();
        }

        public List<int> FindPricesByNameMethodSyntax(string namePart)
        {
            var c = new List<int> { 1 };
            var productPrices = Products
                .Where(product => product
                        .Name
                        .ToLower()
                        .Contains(namePart
                                .ToLower()))
                .Select(product => product.Price)
                .ToList();

            return productPrices;
        }

        public List<int> FindPricesByNameQuerySyntax(string namePart)
        {
            var productPrices = from product in Products
                                where product.Name.ToLower().Contains(namePart.ToLower())
                                select product.Price;

            return productPrices.ToList();
        }

        public Product GetCheapestProductMehodSyntax()
        {
            //Product cheapestProduct = null;

            //int minPrice = int.MaxValue;
            //foreach (var product in Products)
            //{
            //    if(minPrice > product.Price)
            //    {
            //        cheapestProduct = product;
            //    }
            //}

            //return cheapestProduct;

            // firstOrDefault will return the default value id there is no elements in the collection
            var product = Products.OrderBy(product => product.Price).FirstOrDefault();

            // first will throw exception if there is no elements in the collection
            //var product1 = Products.OrderBy(product => product.Price).First();

            return product;
        }

        public Product GetCheapestProductQuerySyntax()
        {
            var products = from product in Products
                          orderby product.Price
                          select product;

            return products.FirstOrDefault();
        }

        public Product GetMostExpensiveProductMethodSyntax()
        {
            // Order by descending example
            // Products.OrderByDescending(product => product.Price).FirstOrDefault();
            return Products.OrderBy(product => product.Price).LastOrDefault();
        }

        public Product GetMostExpensiveProductQuerySyntax()
        {
            var products = from product in Products
                           orderby product.Price
                           select product;

            return products.LastOrDefault();
        }

        public int GetProductPriceByIdMehodSyntax(int id)
        {
            var product = Products.FirstOrDefault(product => product.Id == id);

            if(product != null)
            {
                return product.Price;
            }
            return 0;
        }

        public int GetProductPriceByIdQuerySyntax(int id)
        {
            var product1 = (from product in Products
                           where product.Id == id
                           select product)
                           .FirstOrDefault();

            if (product1 != null)
            {
                return product1.Price;
            }
            return 0;
        }
    }
}
