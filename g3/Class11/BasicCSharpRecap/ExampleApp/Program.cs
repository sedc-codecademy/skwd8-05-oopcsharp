using Domains;
using Services;
using System;
using System.Collections.Generic;

namespace ExampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Laptop> myLaptops = new List<Laptop>
            {
                new Laptop { Id = 1, Brand = "Asus", Model = "1234b", Price = 300 },
                new Laptop { Id = 2, Brand = "Asus", Model = "1234b", Price = 300 },
                new Laptop { Id = 3, Brand = "Asus", Model = "1234b", Price = 300 },
                new Laptop { Id = 4, Brand = "Asus", Model = "1234b", Price = 300 },
                new Laptop { Id = 5, Brand = "Asus", Model = "1234b", Price = 300 },
                new Laptop { Id = 6, Brand = "Asus", Model = "1234b", Price = 300 },
                new Laptop { Id = 7, Brand = "Asus", Model = "1234b", Price = 300 },
                new Laptop { Id = 8, Brand = "Asus", Model = "1234b", Price = 300 },
                new Laptop { Id = 9, Brand = "Asus", Model = "1234b", Price = 300 },
                new Laptop { Id = 10, Brand = "Asus", Model = "1234b", Price = 300 },
                new Laptop { Id = 11, Brand = "Asus", Model = "1234b", Price = 300 },
                new Laptop { Id = 12, Brand = "Asus", Model = "1234b", Price = 300 },
                new Laptop { Id = 13, Brand = "Asus", Model = "1234b", Price = 300 },
                new Laptop { Id = 14, Brand = "Asus", Model = "1234b", Price = 300 },
                new Laptop { Id = 15, Brand = "Asus", Model = "1234b", Price = 300 },
                new Laptop { Id = 16, Brand = "Asus", Model = "1234b", Price = 300 },
                new Laptop { Id = 17, Brand = "Asus", Model = "1234b", Price = 300 },
                new Laptop { Id = 18, Brand = "Asus", Model = "1234b", Price = 300 },
                new Laptop { Id = 19, Brand = "Asus", Model = "1234b", Price = 300 },
                new Laptop { Id = 20, Brand = "Asus", Model = "1234b", Price = 300 },
                new Laptop { Id = 21, Brand = "Asus", Model = "1234b", Price = 300 },
                new Laptop { Id = 22, Brand = "Asus", Model = "1234b", Price = 300 },
                new Laptop { Id = 23, Brand = "Asus", Model = "1234b", Price = 300 },
                new Laptop { Id = 24, Brand = "Asus", Model = "1234b", Price = 300 },
                new Laptop { Id = 25, Brand = "Asus", Model = "1234b", Price = 300 },
                new Laptop { Id = 26, Brand = "Asus", Model = "1234b", Price = 300 },
                new Laptop { Id = 27, Brand = "Asus", Model = "1234b", Price = 300 },
                new Laptop { Id = 28, Brand = "Asus", Model = "1234b", Price = 300 },
                new Laptop { Id = 29, Brand = "Asus", Model = "1234b", Price = 300 },
                new Laptop { Id = 30, Brand = "Asus", Model = "1234b", Price = 300 },
                new Laptop { Id = 31, Brand = "Asus", Model = "1234b", Price = 300 },
                new Laptop { Id = 32, Brand = "Asus", Model = "1234b", Price = 300 },
                new Laptop { Id = 33, Brand = "Asus", Model = "1234b", Price = 300 },
                new Laptop { Id = 34, Brand = "Asus", Model = "1234b", Price = 300 },
                new Laptop { Id = 35, Brand = "Asus", Model = "1234b", Price = 300 },
            };

            LaptopService laptopService = new LaptopService();
            LaptopService laptopService2 = new LaptopService();
            //laptopService // Instance(physical object of LaptopServer)
            //LaptopService // LaptopService is still a physical object(static class) which is instantiated automatically, we are just using it

            List<Laptop> pageLaptops = laptopService.GetLaptopsPage(myLaptops, 2, 15); // Play with the arguments to see different results
            laptopService.PrintLaptops(pageLaptops);


            LaptopService.laptops.Add(new Laptop { Id = 36, Brand = "DELL" }); // We are using the static class(object) to add a new laptop to the static property "laptops"
            //laptopService.laptops.Add(new Laptop { Id = 36, Brand = "DELL" }); // This is how i would look if "laptops" wasn't static property

            laptopService.PrintLaptops();
            Console.WriteLine("=====================================================");
            laptopService2.PrintLaptops();
            // This comment is for the previous 3 lines:
            // Both PrintLaptops are methods from different instances(objects), and still they are printing the newly added laptop (this is because "laptops" is a static property)
            // Remove the static keywork from "laptops" in LaptopService class and you will see that both laptopService and laptopService2 are having their own "laptops" property, it's no loager shared like it was when it was static

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
