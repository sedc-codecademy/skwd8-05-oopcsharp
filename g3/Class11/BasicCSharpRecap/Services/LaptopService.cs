using Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services
{
    public class LaptopService
    {
        public static List<Laptop> laptops { get; set; } = new List<Laptop>
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

        public List<Laptop> GetLaptopsPage(List<Laptop> laptops, int page, int itemCount)
        {
            // Use hover od Skip, Take, ToList to see the potential Exceptions that could be thrown by these methods
            try
            {
                int skip = (page - 1) * itemCount;
                int take = (laptops.Count - skip) < itemCount ? (laptops.Count - skip) : itemCount;

                return laptops.Skip(skip).Take(take).ToList();
            }
            catch (ArgumentException)
            {
                Console.WriteLine($"There was something wrong with the calclucation");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine($"Please send a valid list of laptops");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error happend. Message: {ex.Message} {ex.StackTrace}");
            }

            return new List<Laptop>();
        }

        // This methods prints all laptops, which are taken from a parameter
        public void PrintLaptops(List<Laptop> laptops)
        {
            foreach (Laptop laptop in laptops)
            {
                Console.WriteLine($"{laptop.Id} {laptop.Brand} {laptop.Model} {laptop.Price}");
            }
        }

        // This methods does exactly the same as previus, but laptops are taken from the shared static property
        public void PrintLaptops()
        {
            foreach (Laptop laptop in laptops)
            {
                Console.WriteLine($"{laptop.Id} {laptop.Brand} {laptop.Model} {laptop.Price}");
            }
        }
    }
}
