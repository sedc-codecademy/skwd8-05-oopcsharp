using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;

namespace LinqExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 10, 2, 7, 30, 48, 55, 78, 100, 99, 87, 34, 23, 101, 87 };

            List<int> numbersAbove30 = numbers.Where(number => number > 30).ToList();

            //IEnumerable<int> numbersAbove30 = from number in numbers 
            //                                    where number > 30 
            //                                    select number;

            PrintNumbers(numbersAbove30);
            List<int> numbersAbove100 = numbers.Where(number => number > 100).ToList();
            PrintNumbers(numbersAbove100);
            List<int> numbersBetween20And80 = numbers.Where(number => number > 20 && number < 80).ToList();
            PrintNumbers(numbersBetween20And80);
            List<int> numbersBetween20And100 = numbers.Where(number => { return number > 20 && number < 80; }).ToList();
            PrintNumbers(numbersBetween20And100);

            int firstNumber = numbers.First();
            int lastNumber = numbers.Last();
            Console.WriteLine($"First Number: {firstNumber}, Last Number: {lastNumber}");

            List<int> tempNumbers = new List<int>();
            //int tempFirstNumber = tempNumbers.First();
            //int tempLastNumber = tempNumbers.Last();

            int tempFirstNumber = tempNumbers.FirstOrDefault();
            int tempLastNumber = tempNumbers.LastOrDefault();
            Console.WriteLine($"Last Number: {tempLastNumber}");

            //int firstNumber87 = numbers.Where(number => number == 87).FirstOrDefault();
            int firstNumber87 = numbers.FirstOrDefault(number => number == 87); //87, 87

            int singleNumber48 = numbers.Single(number => number == 48); //exact one element
            int singleOrDefaultNumber105 = numbers.SingleOrDefault(number => number == 105); // none or exact element

            int min = numbers.Min();
            int max = numbers.Max();
            int maxForNumbersUnder80 = numbers.Where(number => number < 80).Max();
            double average = numbers.Average();
            double averageForNumbersOver55 = numbers.Where(number => number > 55).Average();
            int sum = numbers.Sum();

            List<int> orderByAsc = numbers.OrderBy(number => number).ToList();
            PrintNumbers(orderByAsc);
            List<int> orderByDesc = numbers.OrderByDescending(number => number).ToList();
            PrintNumbers(orderByDesc);

            List<int> take3Elements = numbers.Take(3).ToList();
            PrintNumbers(take3Elements);

            List<int> takeLast5Elements = numbers.TakeLast(5).ToList();
            PrintNumbers(takeLast5Elements);

            List<int> skip3Take7Elements = numbers.Skip(3).Take(7).ToList();
            PrintNumbers(skip3Take7Elements);

            List<int> take50Elements = numbers.Take(50).ToList();

            List<string> names = new List<string>() { "Risto", "Martin", "Sashka", "Vlatko", "Darko", "Antonio", "Risto", "Vlatko" };
            //List<string> namesThatContainAandO =
            //    names.Where(name => (name.Contains("a") || name.Contains("A")) && (name.Contains("o") || name.Contains("O"))).ToList();

            List<string> namesThatContainAandO =
                names.Where(name => name.ToLower().Contains("a")  && name.ToLower().Contains("o")).ToList();

            Console.WriteLine("-------------------------------------");
            namesThatContainAandO.ForEach(Console.WriteLine);

            List<string> distinctNames = names.Distinct().ToList();

            Dictionary<long, string> osigurenici = new Dictionary<long, string>()
            {
                {1111990452000, "Risto" },
                {2202991431000, "Darko" },
                {1303999452001, "Vlatko" }
            };

            KeyValuePair<long, string> osigurenik =
                osigurenici.FirstOrDefault(osigurenik => osigurenik.Key == 1111990452000);

            List<KeyValuePair<long, string>> osigureniciOdSk =
                osigurenici.Where(os => os.Key.ToString().Substring(7, 2) == "45").ToList();
        }

        public static void PrintNumbers(List<int> list)
        {
            Console.WriteLine("-------------------------------------");
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //list.ForEach(item => Console.WriteLine(item));
            list.ForEach(Console.WriteLine);
        }
    }
}
