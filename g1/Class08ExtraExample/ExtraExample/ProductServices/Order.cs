using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantProject.Models
{
    public class Order
    {
        static int orderNumber = 0;
        public Order()
        {
            orderNumber += 1;
            OrderNumber = orderNumber;
        }
        public int OrderNumber;
        public string[] Products;
        public double OrderPrize;
        
    }
}
