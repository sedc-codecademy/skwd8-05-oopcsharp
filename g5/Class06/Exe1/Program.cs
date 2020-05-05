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

            //Thread.Sleep(10000);
            myOrder.Delivery();
            Console.WriteLine(myOrder.GetOrderInfo());

            //Thread.Sleep(20000);
            myOrder.Paid();
            Console.WriteLine(myOrder.GetOrderInfo());

            //User user = new User
            //{
            //    Username = "risto",
            //    Password = "test123"
            //};

            User user = new User();
            user.Username = "risto";
            user.Password = "test123";

            User user1 = new User("user1", "test12");
            
            Animal animal = new Animal();
            animal.MyFunction();
        }

        public static void PrintSomething()
        {
            Console.WriteLine("Print...");
        }
    }
}
