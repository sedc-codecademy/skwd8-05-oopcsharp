using System;
using System.Collections.Generic;

namespace CollectionExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> numbers = new Queue<int>();

            numbers.Enqueue(1);
            numbers.Enqueue(2);
            numbers.Enqueue(3);
            numbers.Enqueue(4);

            int number1 = numbers.Dequeue();
            int number2 = numbers.Dequeue();
            int number3 = numbers.Dequeue();
            int number4 = numbers.Dequeue();

            //int temp = numbers.Peek();
            bool thereIsAnElement = numbers.TryPeek(out int temp);

            List<string> names = new List<string>() {"Risto", "Damjan"};
            //names.Add("Risto");
            //names.Add("Damjan");

            int numberOfElements = names.Count;

            string secondElement = names[1];
            names.Remove("Risto");

            Dictionary<int, string> users = new Dictionary<int, string>();
            users.Add(1001, "Risto");
            users.Add(1002, "Damjan");
            //users.Add(2, "Darko"); //keys are unique
            string firstElement = users[1001];
        }
    }
}
