using SEDC.GettersAndSetters.Models;
using System;

namespace SEDC.GettersAndSetters
{
    class Program
    {
        static void Main(string[] args)
        {


            Product p = new Product();
            //p.SetPrice(20);
            //int price = p.GetPrice();

            //Console.WriteLine(price);


            //Set value to Price property
            //p.Price = 10;

            //Get value from Price property
            //Console.WriteLine(p.Price);


            p.Price = 300;
            Console.WriteLine($"The price is: {p.Price}$");

            //p.Discount = 0.5;


            //Console.WriteLine($"The discount is: {p.Discount}");











            Console.ReadLine();
        }
    }
}
