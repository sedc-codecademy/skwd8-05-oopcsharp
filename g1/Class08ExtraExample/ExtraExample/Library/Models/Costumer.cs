using Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantProject.Models
{
    public class Costumer : Human
    {
        public Costumer()
        {

        }
        public Costumer(string firstName, string lastName) : base(firstName, lastName)
        {

        }

        public Waiter Waiter;
        public Order Order;

        public void MakeOrder(Order order)
        {
            Console.WriteLine($"{FirstName} {LastName}: I will have: ");
            foreach (var item in order.Products)
            {
                Console.WriteLine($"  - {item}");
            }
            Order = order;
            Waiter.RecieveOrder(order);
        }

        public void AskForBill()
        {
            Console.WriteLine($"{FirstName} {LastName}: I will have my check please");
            Waiter.CompleteOrder(Order);
        }
    }
}
