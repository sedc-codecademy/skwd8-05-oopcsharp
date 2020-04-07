using Library.Enums;
using RestaurantProject.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Models
{
    public class Waiter : Human
    {
        public Waiter()
        {

        }
        public Waiter(string firstName, string lastName) : base(firstName, lastName)
        {

        }

        private double Cash;
        public Order[] Orders;

        public void RecieveOrder(Order order)
        {
            Array.Resize(ref Orders, Orders.Length + 1);
            Orders[Orders.Length - 1] = order;
            Console.WriteLine($"{FirstName} {LastName}: Order accepted.");

        }

        public void CompleteOrder(Order order)
        {
            Cash += order.OrderPrize;
            var ordersAfterComplete = Array.FindAll(Orders, (ord) => ord.OrderNumber != order.OrderNumber);
            Orders = ordersAfterComplete;
            Console.WriteLine($"{FirstName} {LastName}: Thank you for being our guest.");
        }

        public double GetDailyEarning()
        {
            return Cash;
        }
    }
}
