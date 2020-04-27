using System;
using System.Threading;
using Models;

namespace Market
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Market
            OnlineMarket market = new OnlineMarket("Kam");
            Article article1 = new Article("Coca Cola", 50, 70);
            Article article2 = new Article("Skopsko pivo 0.5", 30, 40);
            Article article3 = new Article("Cips", 100, 90);
            Article article4 = new Article("Resani", 40, 20);
            Article article5 = new Article("Pukanki", 70, 10);
            Article article6 = new Article("Smoki", 100, 12);
            Article article7 = new Article("Leb", 30, 30);
            Article article8 = new Article("Melko", 50, 50);
            Article article9 = new Article("Sirenje 1kg", 60, 300);
            Article article10 = new Article("Sapun", 150, 50);

            market.AddArticle(article1);
            market.AddArticle(article2);
            market.AddArticle(article3);
            market.AddArticle(article4);
            market.AddArticle(article5);
            market.AddArticle(article6);
            market.AddArticle(article7);
            market.AddArticle(article8);
            market.AddArticle(article9);
            market.AddArticle(article10);

            Console.WriteLine($"Dobredojdovte vo {market.Name}!");
            Console.WriteLine("Ova e nasata ponuda:");

            #endregion

            #region Shopping
            Order order = new Order();

            while (true)
            {
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
                Console.WriteLine(market.GetAvailableArticles());
                Console.WriteLine("Vnesete broj na produkt sto sakate da go kupite ili, vnesete E dokolku sakate da ja kompletirate narackata.");
                
                string input = Console.ReadLine();

                if (input == "E" || input == "e")
                {
                    break;
                }

                if(!int.TryParse(input, out int inputNumber))
                {
                    Console.WriteLine("Vnesovte pogresen input, ve molime probajte pak.");
                    continue;
                }

                //if(!(inputNumber > 0 && inputNumber <= market.Articles.Count))
                if (inputNumber < 0 || inputNumber > market.Articles.Count)
                {
                    Console.WriteLine("Vnesovte pogresen input, ve molime probajte pak.");
                    continue;
                }

                Article article = market.Articles[inputNumber - 1];
                Console.Write($"Izbravte {article.Name}, kolku kolicina sakate od istiot: ");
                string quantityInput = Console.ReadLine();

                if (!int.TryParse(quantityInput, out int quantityNumber))
                {
                    Console.WriteLine("Ne vnesovte broj.");
                    continue;
                }

                if (quantityNumber > article.Stock)
                {
                    Console.WriteLine($"Izvinete nemame vo momentov {quantityNumber} {article.Name}.");
                    continue;
                }

                article.Stock -= quantityNumber;

                OrderItem item = new OrderItem(article, quantityNumber);
                order.AddOrderItem(item);
            }

            Console.WriteLine("=================================================================");
            Console.WriteLine("Izberete tip na dostava: ");
            Console.WriteLine($"{(int) DeliveryType.DeliveryToDoor}. {DeliveryType.DeliveryToDoor}");
            Console.WriteLine($"{(int) DeliveryType.PickupFromMarket}. {DeliveryType.PickupFromMarket}");

            string deliveryInput = Console.ReadLine();
            if (!int.TryParse(deliveryInput, out int deliveryNumber))
            {
                Console.WriteLine("Izberavte nepravilen nacin za dostava!");
                return;
            }

            if (deliveryNumber != (int) DeliveryType.DeliveryToDoor &&
                deliveryNumber != (int) DeliveryType.PickupFromMarket)
            {
                Console.WriteLine("Izberavte nepravilen nacin za dostava!");
                return;
            }

            order.SetDeliveryType((DeliveryType) deliveryNumber);
            Console.WriteLine("=================================================================");
            Console.WriteLine(order.GetOrderDetails());

            Thread.Sleep(2000);
            Console.Write(order.Pay());
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(2000);
                Console.Write(".");
            }

            #endregion
        }
    }
}
