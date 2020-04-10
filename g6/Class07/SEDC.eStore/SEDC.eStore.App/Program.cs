using SEDC.eStore.Business.ApplicationMenu;
using SEDC.eStore.Business.Services;
using SEDC.eStore.Data.Database;
using SEDC.eStore.Entities.Models;
using System;

namespace SEDC.eStore.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var productRepository = new ProductRepository();
            var userRepository = new UserRepository();

            Menu.WelcomeScreen();

            User user = Authentication.Login(userRepository, new ValidationService());

            Menu.PrintProducts(productRepository.GetProducts());

            Console.WriteLine("Enter product id");
            int productId = 0;
            bool isValid = int.TryParse(Console.ReadLine(), out productId);
            Product product = productRepository.GetProductById(productId);
            if (product == null)
            {
                Console.WriteLine("Not valid product id");
            }
            else
            {
                user.Cart.AddProduct(product);
            }

            Console.WriteLine("Enter product id");
            bool isValid1 = int.TryParse(Console.ReadLine(), out productId);
            Product product1 = productRepository.GetProductById(productId);
            if (product1 == null)
            {
                Console.WriteLine("Not valid product id");
            }
            else
            {
                user.Cart.AddProduct(product1);
            }

            Console.WriteLine("---------------------Cart------------------------");
            Menu.PrintProducts(user.Cart.GetProducts());
            Console.WriteLine($"Total price: {user.Cart.TotalPrice} MKD");

            Console.ReadLine();
        }
    }
}
