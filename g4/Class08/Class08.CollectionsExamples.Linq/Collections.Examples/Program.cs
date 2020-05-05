using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections.Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            // Non-generic collection
            // ArrayList

            Console.WriteLine("---------------- ArrayList ----------------");
            ArrayList arrList = new ArrayList()
            {
                1,
                "eden",
                true
            };
            foreach (var item in arrList)
            {
                Console.WriteLine(item);
            }

            arrList.Add(new int[] { 1, 3, 5 });
            Console.WriteLine($"Count if arrList after add: {arrList.Count}");


            // Generic Collections

            // List
            // indexed
            Console.WriteLine("---------------- List ----------------");

            List<int> numbers = new List<int>()
            {
                1, 2, 3
            };
            Console.WriteLine($"Count of list initial: {numbers.Count}");
            numbers.Add(4);
            numbers.Add(5);
            List<int> numsToAdd = new List<int>() { 6, 7, 8, 9, 10 };
            numbers.AddRange(numsToAdd);
            Console.WriteLine($"Count of list after add: {numbers.Count}");

            numbers.Remove(10);
            Console.WriteLine($"Count of list after remove: {numbers.Count}");

            numbers.Remove(33);
            Console.WriteLine($"Count of list after remove non-existing: {numbers.Count}");
            // even if try to remove non-existing element nothing happens

            // Dictionary 
            // non-indexed
            Console.WriteLine("---------------- Dictionary ----------------");
            Dictionary<int, string> memberDictionary = new Dictionary<int, string>()
            {
                {1, "Dejan"},
                {2, "Kristina" }
            };

            // check value of a given key
            Console.WriteLine("Member with key 1 is: {0}", memberDictionary[1]);
            // [1] is NOT the index, it is the key

            // Console.WriteLine("Member with key 5 is: {0}", memberDictionary[5]);
            // this will throw an exception - key is not found

            // safe way to  do this
            bool memberExists = memberDictionary.TryGetValue(5, out string value5);
            Console.WriteLine(memberExists ? value5 : "No such key in the dictionary!");

            // we can NOT add duplicate keys
            //memberDictionary.Add(2, "Bob");
            // this will throw exception

            memberDictionary.Add(3, "Bob");

            memberDictionary[2] = "Bob";
            foreach (var item in memberDictionary)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

            memberDictionary.Remove(3);
            Console.WriteLine($"Dictionary after remove");

            foreach (var item in memberDictionary)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

            memberDictionary.Remove(65);
            Console.WriteLine($"Dictionary after remove non-existing");

            foreach (var item in memberDictionary)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

            // if we try to remove non-existing, nothing happens

            // Queue
            // non-indexed
            Console.WriteLine("---------------- Queue ----------------");
            Queue<string> bankQueue = new Queue<string>();
            bankQueue.Enqueue("Ace");
            bankQueue.Enqueue("Bojana");
            foreach (var item in bankQueue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("First served will be: {0}", bankQueue.Peek());
            bankQueue.Dequeue();
            bankQueue.Dequeue();

            // now the queue is empty
            //Console.WriteLine("First served will be: {0}", bankQueue.Peek());
            // this will throw an exception

            // safe way
            bool queueNotEmpty = bankQueue.TryPeek(out string personNext);
            Console.WriteLine(queueNotEmpty ? personNext : "Queue is empty!");

            //bankQueue.Dequeue();
            // this will throw an exception 

            bool queueNotEmptyAgain = bankQueue.TryDequeue(out string person);
            Console.WriteLine(queueNotEmptyAgain ? person : "Queue is empty!");

            // Stack
            // non-indexed
            Console.WriteLine("---------------- Stack ----------------");

            Stack<string> pancakes = new Stack<string>();
            pancakes.Push("pancake 1");
            pancakes.Push("pancake 2");
            pancakes.Push("pancake 3");
            foreach (var item in pancakes)
            {
                Console.WriteLine(item);
            }

            pancakes.Pop();
            pancakes.Pop();
            pancakes.Pop();

            // stack is empty
            //pancakes.Peek();
            // this will throw an exception

            // safe way - TryPeek()
            bool leftPancakes = pancakes.TryPeek(out string pancakeLeft);
            Console.WriteLine(leftPancakes ? pancakeLeft : "Kristina ate all the pancakes!");

            // safe way - TryPop()
            bool leftPancakesAgain = pancakes.TryPop(out string anotherPancakeLeft);
            Console.WriteLine(leftPancakesAgain ? anotherPancakeLeft : "No more pancakes for Deki :) !");
            

            Console.ReadLine();
        }
    }
}
