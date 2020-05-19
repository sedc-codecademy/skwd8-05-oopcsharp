using System;

namespace Market
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = new Product();

            product.Price = 100;
            Console.WriteLine($"The price of the product is {product.Price}");
            Console.WriteLine($"The discount of the product is {product.Discount}");

            product.Price = 150;

            //if (product.Price > 100)
            //    product.Discount = 0.1f;

            Console.WriteLine($"The price of the product is {product.Price}");
            Console.WriteLine($"The discount of the product is {product.Discount}");

            Console.ReadLine();
        }
    }
}