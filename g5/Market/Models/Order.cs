using System;
using System.Collections.Generic;
using System.Globalization;

namespace Models
{
    public class Order
    {
        public string Number { get; set; }
        public DateTime OrderDate { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public DeliveryType DeliveryType { get; set; }

        public Order()
        {
            Random rnd = new Random();
            Number = $"#{rnd.Next(100000, 999999).ToString()}";
            OrderDate = DateTime.Now;
            OrderItems = new List<OrderItem>();
        }

        public void AddOrderItem(OrderItem item)
        {
            foreach (var orderItem in OrderItems)
            {
                if (orderItem.Article.Name == item.Article.Name)
                {
                    orderItem.Quantity += item.Quantity;
                    return;
                }
            }

            OrderItems.Add(item);
        }

        public int CalculatePrice()
        {
            int price = 0;
            foreach (var orderItem in OrderItems)
            {
                price += orderItem.CalculatePrice();
            }

            if (DeliveryType == DeliveryType.DeliveryToDoor)
            {
                price += 100;
            }

            return price;
        }

        public string Pay()
        {
            return "Payment in progress";
        }

        public string GetOrderDetails()
        {
            string info = $"Your order {Number} made on {OrderDate.ToString()} with delivery type {DeliveryType}:\n";
            foreach (var orderItem in OrderItems)
            {
                info += orderItem.GetOrderItemInfo() + "\n";
            }

            if (DeliveryType == DeliveryType.DeliveryToDoor)
            {
                info += $"Dostava do doma = {100}\n";
            }

            info += $"Total: {CalculatePrice()}";

            return info;
        }

        public void SetDeliveryType(DeliveryType type)
        {
            DeliveryType = type;
        }
    }
}
