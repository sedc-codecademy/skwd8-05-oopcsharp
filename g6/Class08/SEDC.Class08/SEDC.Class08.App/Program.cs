using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.Class08.App
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] intArray = new int[10];
            //int[] intArray1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            ////Console.WriteLine(intArray1[3]);

            //List<int> listOfIntegers = new List<int>();
            //List<int> listOfIntegers1 = new List<int>() { 1, 2, 3, 4, 5 };

            //Dictionary<int, string> dictionaryOfIntString = new Dictionary<int, string>();
            //Dictionary<int, string> dictionaryOfIntString1 = new Dictionary<int, string>() 
            //{
            //    { 1, "Trajan" },
            //    { 2, "Tosho" }
            //};


            //dictionaryOfIntString1[1] = "Trajan12";
            //dictionaryOfIntString1[7] = "Tosho";
            //dictionaryOfIntString1[18] = "Bob";
            //dictionaryOfIntString1[22] = "Bobski";
            //dictionaryOfIntString1[22] = "Bobski Bobski";

            //Console.WriteLine(dictionaryOfIntString1[22]);

            //dictionaryOfIntString1.Add(23, "Nesto drugo");
            //dictionaryOfIntString1.Remove(50);

            //Dictionary<double, Person> listOfPersons = new Dictionary<double, Person>()
            //{
            //    { 2.0, new Person() { Name = "Trajan" } },
            //    { 3.0, new Person() { Name = "Tosho" } }
            //};

            //foreach (var item in listOfPersons)
            //{
            //    Console.WriteLine(item.Key);
            //    Console.WriteLine(item.Value.Name);
            //    Console.WriteLine(listOfPersons[item.Key].Name);
            //}


            //foreach (var item in dictionaryOfIntString1)
            //{
            //    Console.WriteLine("Value: " + dictionaryOfIntString1[item.Key]);

            //    Console.WriteLine("----------- using .Value");

            //    //Console.WriteLine("Key: " + item.Key);
            //    Console.WriteLine("Value using .Value: " + item.Value);
            //}

            //Console.WriteLine(listOfIntegers1[2]);


            //Console.WriteLine(intArray1.Length);
            //Console.WriteLine(listOfIntegers1.Count);
            //Console.WriteLine(intArray.Length);
            //Console.WriteLine(listOfIntegers.Count);

            //Array.Resize(ref intArray1, 11);
            //intArray1[11] = 8;

            //listOfIntegers.Add(1);
            //listOfIntegers.Add(2);
            //listOfIntegers.Add(3);
            //listOfIntegers.Add(1);
            //listOfIntegers.Add(5);
            //listOfIntegers.Remove(1);

            //Console.WriteLine("--------------------------------------------");

            //foreach (var item in listOfIntegers)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("--------------------------------------------");

            //for (int i = 0; i < listOfIntegers1.Count; i++)
            //{
            //    Console.WriteLine(listOfIntegers1[i]);
            //}

            List<string> list = new List<string>() { "Kristina"};

            Console.WriteLine(list[0]);
            list.Add("Tosho");
            list[0] = "Kiki";

            list[0] = null;

            Dictionary<string, double> dictionary = new Dictionary<string, double>() 
            {
                ["Pi"] = 3.14,
                ["two"] = 2
            };

            Console.WriteLine("Value of pi is " + dictionary["Pi"]);

            dictionary.Remove("two");

            //This will throw exception
            //Console.WriteLine(dictionary["two"]);

            if (dictionary.TryGetValue("two", out double two))
            {
                Console.WriteLine(two);
            }
            else
            {
                Console.WriteLine("There is no such key");
            }

            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Darko");
            queue.Enqueue("Vasil");
            queue.Enqueue("Elena");
            queue.Enqueue("Darko");
            queue.Enqueue("Vladimir");

            //foreach (string item in queue)
            //{
            //    Console.WriteLine(item);
            //}

            var firstElementInQueue = queue.Peek();

            //Console.WriteLine(firstElementInQueue);

            var darko = queue.Dequeue();

            foreach (string item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(darko);

            var queue2 = new Queue<int>();

            //This will throw exception Queue empty
            //queue2.Dequeue();

            if (queue2.TryDequeue(out int num))
            {
                Console.WriteLine(num);
            }
            else
            {
                Console.WriteLine("Queue is empty");
            }

            Stack<Product> products = new Stack<Product>();

            products.Push(new Product("Ball", 10));
            products.Push(new Product("Kayak", 180));
            products.Push(new Product("Flag", 5.5));

            foreach (var item in products)
            {
                Console.WriteLine(item.Info());
            }

            products.Pop();

            Console.WriteLine("After Pop()");
            foreach (var item in products)
            {
                Console.WriteLine(item.Info());
            }

            Console.WriteLine(products.Peek().Info());


            Console.WriteLine("ArrayLists==========");
            ArrayList arrayList = new ArrayList() { 1 };
            arrayList.Add("two");
            arrayList.Add(true);
            arrayList.Add(null);

            arrayList.Insert(2, 5.6D);

            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }

            Console.WriteLine(arrayList.Count);


            //Stack stack = new Stack();
            
            Console.ReadLine();
        }
    }
}