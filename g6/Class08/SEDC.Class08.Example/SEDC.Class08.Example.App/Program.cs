using SEDC.Class08.Example.Data;
using SEDC.Class08.Example.Models;
using System;
using System.Net.Http.Headers;

namespace SEDC.Class08.Example.App
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Product.GetIdGenerator());

            //var p1 = new Product("Ball", 10);
            //var p2 = new Product("Kayak", 150);
            //var p3 = new Product("Flag", 5.5);

            //Console.WriteLine(p1.Info());
            //Console.WriteLine(p2.Info());
            //Console.WriteLine(p3.Info());

            //Console.WriteLine(Product.GetIdGenerator());

            var repository = new MemoryRepository();

            //foreach (var product in repository.GetAllProducts())
            //{
            //    Console.WriteLine(product.Info());
            //}

            Product kayak = repository["Kayak"];

            Console.WriteLine(kayak.Info());

            var racket = new Product("Tennis", 80);

            repository.AddProduct(racket);

            Console.WriteLine(repository.GetProduct("Tennis").Info());

            var repo2 = new MemoryRepository();


            //Console.WriteLine(repo2["Tennis"]);
            repository.DeleteProduct(racket);

            foreach (var product in repository.GetAllProducts())
            {
                Console.WriteLine(product.Info());
            }

            Console.ReadLine();
        }
    }
}
