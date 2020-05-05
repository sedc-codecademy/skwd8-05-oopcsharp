using SEDC.Class08.LINQ.Database;
using SEDC.Class08.LINQ.Models;
using System;
using System.Collections.Generic;

namespace SEDC.Class08.LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var productRepository = new ProductRepository();

            //var listOfProducts = productRepository.GetProductsByCategory(Category.PC);
            //var listOfProductsMethodSyntax = productRepository.GetProductsByCategoryMethodSyntax(Category.PC);
            //var listOfProductsQuerySyntax = productRepository.GetProductsByCategoryQuerySyntax(Category.PC);

            //Console.WriteLine("Old Way ---------------------------");
            //PrintList(listOfProducts);
            //Console.WriteLine("Method Syntax ---------------------------");
            //PrintList(listOfProductsMethodSyntax);
            //Console.WriteLine("Query Syntax ---------------------------");
            //PrintList(listOfProductsQuerySyntax);

            //var productByPriceRangeMethodSyntax = productRepository.FilterProductsByPriceRangeMethodSyntax(10000, 20000);
            //var productByPriceRangeQuerySyntax = productRepository.FilterProductsByPriceRangeQuerySyntax(10000, 20000);

            //Console.WriteLine("Method Syntax ---------------------------");
            //PrintList(productByPriceRangeMethodSyntax);
            //Console.WriteLine("Query Syntax ---------------------------");
            //PrintList(productByPriceRangeQuerySyntax);

            //var productIdsMethodSyntax = productRepository.GetProductIdsMethodSyntax();
            //var productIdsQuerySyntax = productRepository.GetProductIdsQuerySyntax();

            //Console.WriteLine("Method Syntax ---------------------------");
            //foreach (var id in productIdsMethodSyntax)
            //{
            //    Console.WriteLine(id);
            //}
            //Console.WriteLine("Query Syntax ---------------------------");
            //foreach (var id in productIdsQuerySyntax)
            //{
            //    Console.WriteLine(id);
            //}


            var productPricesByNameMethodSyntax = productRepository.FindPricesByNameMethodSyntax("LG LG420MQ8");
            //var productPricesByNameQuerySyntax = productRepository.FindPricesByNameQuerySyntax("Gaming");

            Console.WriteLine("Method Syntax ---------------------------");
            foreach (var price in productPricesByNameMethodSyntax)
            {
                Console.WriteLine(price);
            }
            //Console.WriteLine("Query Syntax ---------------------------");
            //foreach (var price in productPricesByNameQuerySyntax)
            //{
            //    Console.WriteLine(price);
            //}

            //var cheapestProductMethodSyntax = productRepository.GetCheapestProductMehodSyntax();
            //var cheapestProductQuerySyntax = productRepository.GetCheapestProductQuerySyntax();

            //Console.WriteLine("Method Syntax ---------------------------");
            //cheapestProductMethodSyntax.PrintInfo();
            //Console.WriteLine("Query Syntax ---------------------------");
            //cheapestProductQuerySyntax.PrintInfo();

            var mostExpensiveProductMethodSyntax = productRepository.GetMostExpensiveProductMethodSyntax();
            var mostExpensiveProductQuerySyntax = productRepository.GetMostExpensiveProductQuerySyntax();

            Console.WriteLine("Method Syntax ---------------------------");
            mostExpensiveProductMethodSyntax.PrintInfo();
            Console.WriteLine("Query Syntax ---------------------------");
            mostExpensiveProductQuerySyntax.PrintInfo();

            var productPriceByIdMethodSyntax = productRepository.GetProductPriceByIdMehodSyntax(16);
            var productPriceByIdQuerySyntax = productRepository.GetProductPriceByIdQuerySyntax(16);
            
            Console.WriteLine("Method Syntax ---------------------------");
            Console.WriteLine(productPriceByIdMethodSyntax);
            Console.WriteLine("Query Syntax ---------------------------");
            Console.WriteLine(productPriceByIdQuerySyntax);


            Console.ReadLine();
        }

        public static void PrintList(List<Product> list)
        {
            foreach (var product in list)
            {
                product.PrintInfo();
            }
        }
    }
}
