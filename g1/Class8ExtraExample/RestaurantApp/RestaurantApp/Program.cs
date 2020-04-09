using RestaurantApp.Enums;
using RestaurantApp.Models;
using RestaurantProject.Models;
using System;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Waiter waiter = new Waiter()
            {
                FirstName = "Bob",
                LastName = "Bobsky",
                Age = 22,
                Gender = Gender.Male,
                Orders = new Order[] { }
            };

            Costumer costumer = new Costumer("John", "Doe");
            costumer.Gender = Gender.Male;
            costumer.Age = 44;
            costumer.Waiter = waiter;

            Costumer secondCostumer = new Costumer("Angelina", "Jolie");
            secondCostumer.Gender = Gender.Female;
            secondCostumer.Age = 55;
            secondCostumer.Waiter = waiter;

            costumer.MakeOrder(new Order() { Products = new string[] { "Pizza", "Coca Cola" }, OrderPrize = 100.00 });

            Console.WriteLine("-------------------------------------------------------------------------------------");

            var secondCostumerOrder = new Order()
            {
                Products = new string[] { "Beafsteak", "Skopsko", "Chocolate cake" },
                OrderPrize = 545.00
            };
            secondCostumer.MakeOrder(secondCostumerOrder);

            Console.WriteLine("--------------------------------------------------------------------------------------");

            costumer.AskForBill();

            Console.WriteLine("--------------------------------------------------------------------------------------");

            secondCostumer.AskForBill();

            Console.WriteLine("--------------------------------------------------------------------------------------");

            Console.WriteLine($"Waiter daily earnings: {waiter.GetDailyEarning()} $");

            Console.ReadLine();
        }
    }
}