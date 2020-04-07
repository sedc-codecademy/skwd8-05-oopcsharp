using System;
using System.Threading;
using Models;

namespace Exe1
{
    class Program
    {
        static void Main(string[] args)
        {
            Order myOrder = new Order("Risto", "0000000", "Kapricioza", 360, "Gjorce");
            Console.WriteLine(myOrder.GetOrderInfo());

            Thread.Sleep(10000);
            myOrder.Delivery();
            Console.WriteLine(myOrder.GetOrderInfo());

            Thread.Sleep(20000);
            myOrder.Paid();
            Console.WriteLine(myOrder.GetOrderInfo());
        }
    }
}
