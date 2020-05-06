using System;
using System.Collections.Generic;

namespace GenericCollections
{
    public class Car
    {
        public string Model { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //  List
            // List ( Has designated type and does not have constraint on number of elements )
            var sedcGroups = new List<string>() { "G1", "G2", "G3", "G4", "G5", "G6", "G7", "G8" };

            // Add multiple elements in list
            sedcGroups.AddRange(new List<string>() { "G9", "G10" });

            // Add single element in list
            sedcGroups.Add("G11");

            //Going through every element in the list
            foreach (var item in sedcGroups)
            {
                Console.WriteLine(item);
            }

            // Count - Get number of elements in the collection
            Console.WriteLine($"The number of elements is: {sedcGroups.Count}");

            // List<T> T=Generic, it can be int, string, bool,class .....
            var autmobileShop = new List<Car>();

            var car1 = new Car();
            car1.Model = "BMW";

            // Add new element (CAR)
            autmobileShop.Add(car1);


            //  Dictionary<Key, Value>
            // Dictionary ( Works on Key/Value pair system. This system gives us the option to get values from collection by some key )

            // Students and exam points <-> one array for names, one array for points 
            // Creating and initializing dictionary
            var examPoints = new Dictionary<string, int>() { { "John", 50 }, { "Bob", 100}  };

            // Add new element
            examPoints.Add("Miodrag", 50);
            examPoints.Add("Goce", 100);

            //Remove element by key
            examPoints.Remove("Miodrag");

            foreach (var item in examPoints)
            {
                Console.WriteLine($"The first student is {item.Key}, points: {item.Value}");
            }

            var cars = new Dictionary<string, Car>();
            cars.Add("SK1111AA", car1);

            var points = new int[] { 50, 100 };
            var students = new string[] { "Miodrag", "Goce" };

            examPoints.Add("Nov Student", 200);

            //Console.WriteLine($"First student is {students[0]}, points: {points[0]}");


            //  Queue - FIFO (Firt In First Out - Market)
            var bankQueue = new Queue<string>();
            // Adding new elements in queue
            bankQueue.Enqueue("Buco");
            bankQueue.Enqueue("Ilija");
            bankQueue.Enqueue("Marija");

            // get removed element from queue (FIRST)
            var served = bankQueue.Dequeue();

            // This returns what element is on top of the queue ( Who's turn it is )
            var next = bankQueue.Peek();

            Console.ForegroundColor = ConsoleColor.Red;

            foreach (var item in bankQueue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Served is: " + served);

            //  Stack - LIFO (Last In First Out - SportBag)
            Console.ForegroundColor = ConsoleColor.Yellow;

            var sportBag = new Stack<string>();
            // Add new element in stack
            sportBag.Push("Trainers");
            sportBag.Push("T-shirt");
            sportBag.Push("Towel");

            var equipment = sportBag.Peek();
            Console.WriteLine("Next part is: " + equipment);

            //Remove last element from the stack
            sportBag.Pop();

            foreach (var item in sportBag)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
