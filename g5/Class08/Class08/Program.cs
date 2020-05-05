using System;
using System.Collections.Generic;

namespace Class08
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Dictionary
            Dictionary<string, string> osigurenici = new Dictionary<string, string>();
            osigurenici.Add("1112", "Osigurenik 1");
            osigurenici.Add("1113", "Osigurenik 2");
            osigurenici.Add("1114", "Osigurenik 3");

            string t = osigurenici["1113"];

            foreach (KeyValuePair<string, string> osigurenik in osigurenici)
            {
                Console.WriteLine($"EMBG: {osigurenik.Key} Name: {osigurenik.Value}");
            }

            var a1 = new BankAccount("KB", "Risto", 1000, "1111");
            var a2 = new BankAccount("NLB", "Martin", 3000, "2222");
            var a3 = new BankAccount("NLB", "Aleksandra", 4000, "3333");
            var a4 = new BankAccount("KB", "Aleksandar", 5000, "4444");

            //List<BankAccount> accounts = new List<BankAccount>() {a1, a2, a3, a4};

            //foreach (var account in accounts)
            //{
            //    if (account.Number == "3333")
            //    {
            //        Console.WriteLine($"Sopstvenik na smetkata e: {account.PersonName}");
            //    }
            //}

            Dictionary<string, BankAccount> accounts = new Dictionary<string, BankAccount>()
            {
                {a1.Number, a1},
                {a2.Number, a2},
                {a3.Number, a3},
                {a4.Number, a4}
            };

            //accounts.Add(a1.Number, a1);
            //accounts.Add(a2.Number, a2);
            //accounts.Add(a3.Number, a2);
            //accounts.Add(a4.Number, a4);

            accounts.Remove("4444");
            int numberElements = accounts.Count;
            //BankAccount nonExistingAccount = accounts["5555"]; //throws exception
            bool exists = accounts.TryGetValue("5555", out BankAccount nonExistingAccount);

            Console.WriteLine($"Sopstvenik na smetkata e: {accounts["3333"].PersonName}");
            #endregion

            #region List
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };
            var account1 = new BankAccount("KB", "Test", 1000, "123");
            List<BankAccount> bankAccounts = new List<BankAccount>() { new BankAccount("KB", "Test 1", 2000, "321") };

            bankAccounts.Add(account1);
            BankAccount a = bankAccounts[1];

            bankAccounts.Remove(account1);
            #endregion

            #region Queue

            Queue<string> redUBanka = new Queue<string>();
            Queue<BankAccount> smetki = new Queue<BankAccount>();
            redUBanka.Enqueue("Risto");
            redUBanka.Enqueue("Darko");
            redUBanka.Enqueue("Martin");

            string e = redUBanka.Peek();

            string element1 = redUBanka.Dequeue();
            string element2 = redUBanka.Dequeue();
            string element3 = redUBanka.Dequeue();
            //string element4 = redUBanka.Dequeue();

            bool thereIsSomeone = redUBanka.TryDequeue(out string element4);

            #endregion

            #region Stack

            Stack<int> lotoNumbers = new Stack<int>();
            lotoNumbers.Push(7);
            lotoNumbers.Push(17);
            lotoNumbers.Push(27);
            lotoNumbers.Push(37);
            lotoNumbers.Push(5);

            int peekNumber = lotoNumbers.Peek();
            int lastNumber = lotoNumbers.Pop();
            bool hasNumber = lotoNumbers.TryPop(out int nextNumber);
            bool hasNumber1 = lotoNumbers.TryPop(out int nextNumber1);
            bool hasNumber2 = lotoNumbers.TryPop(out int nextNumber2);
            bool hasNumber3 = lotoNumbers.TryPop(out int nextNumber3);
            bool hasNumber4 = lotoNumbers.TryPop(out int nextNumber4);

            #endregion
        }
    }
}
