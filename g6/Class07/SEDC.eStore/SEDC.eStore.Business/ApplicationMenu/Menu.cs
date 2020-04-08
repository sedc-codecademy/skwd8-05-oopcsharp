using SEDC.eStore.Entities.Models;
using System;

namespace SEDC.eStore.Business.ApplicationMenu
{
    public static class Menu
    {
        public static void WelcomeScreen()
        {
            Console.WriteLine("Welcome to eStore console app");
            Console.WriteLine("Login to continue");
        }

        public static void PrintProducts(Product[] products)
        {
            foreach (Product product in products)
            {
                Console.WriteLine(product.Info());
            }
        }
    }
}
