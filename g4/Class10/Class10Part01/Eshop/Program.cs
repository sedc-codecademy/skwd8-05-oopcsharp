using System;
using System.Collections.Generic;
using System.Linq;

namespace Eshop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = ProductsService.GetAllProducts();

            Dictionary<string, int> order = new Dictionary<string, int>();

            Console.WriteLine("Welcome to our shop");
            Console.WriteLine("Our products are:");
            Console.WriteLine(" -------------------------- ");
            Console.WriteLine("ID - Name - Price");

            products.ForEach(prod => Console.WriteLine($" {prod.Id} - {prod.Name} - {prod.Price} MKD"));


            while (true)
            {

                if (order.Count > 0)
                {
                    Console.WriteLine(" =================================== ");
                    Console.WriteLine("Items in shopping cart:");
                    Console.WriteLine("Name - Quantity");
                    foreach (var item in order)
                    {
                        Console.WriteLine($"{item.Key} - {item.Value}");
                    }
                    Console.WriteLine(" =================================== ");
                }

                Console.WriteLine("Would you like to continue to buy anything? Y/N");
                string userInputExit = Console.ReadLine().ToLower();
                if (userInputExit == "n" || userInputExit != "y")
                {
                    break;
                }

                while (true)
                {
                    Console.WriteLine("Enter product id:");
                    int productId = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter quantity:");
                    int productQuantity = int.Parse(Console.ReadLine());

                    var wantedProd = products.SingleOrDefault(x => x.Id == productId);
                    Console.WriteLine(wantedProd != null ? $"Product: {wantedProd.Name}, Quantity: {productQuantity} added to cart!" : "No such product");
                    if (wantedProd != null) {
                        order.Add(wantedProd.Name, productQuantity);
                    }
                    Console.WriteLine("Would you like another order? Y/N");
                    string userInputExitOrder = Console.ReadLine().ToLower();
                    if (userInputExitOrder == "n" || userInputExitOrder != "y")
                    {

                        break;
                    }
                }
            };
            
            


            //Console.ReadLine();
        }
    }
}
