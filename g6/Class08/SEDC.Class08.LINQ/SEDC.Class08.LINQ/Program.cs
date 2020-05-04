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

            var listOfProducts = productRepository.GetProductsByCategory(Category.PC);
            var listOfProductsMethodSyntax = productRepository.GetProductsByCategoryMethodSyntax(Category.PC);
            var listOfProductsQuerySyntax = productRepository.GetProductsByCategoryQuerySyntax(Category.PC);

            Console.WriteLine("Old Way ---------------------------");
            PrintList(listOfProducts);
            Console.WriteLine("Method Syntax ---------------------------");
            PrintList(listOfProductsMethodSyntax);
            Console.WriteLine("Query Syntax ---------------------------");
            PrintList(listOfProductsQuerySyntax);

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
