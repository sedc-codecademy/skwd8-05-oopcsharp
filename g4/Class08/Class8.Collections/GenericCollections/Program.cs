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

            #region List
            // Creating a List
            List<string> sedcGroups = new List<string>() { "G1", "G2", "G3", "G4", "G5", "G6", "G7" };

            // Adding one element in the List
            sedcGroups.Add("G8");

            // Adding multiple elements in the List
            sedcGroups.AddRange(new List<string>() { "G9", "G10" });

            // Looping through the elements in the collection to see what's inside
            foreach (var item in sedcGroups)
            {
                Console.WriteLine(item);
            }

            // Checking the length of the List
            Console.WriteLine(sedcGroups.Count);

            // Because the List is generic (List<T>) it can store all the different types
            // int, string, bool, class ... etc
            List<Car> cars = new List<Car>();

            Car myCar = new Car() { Model = "Citroen" };

            cars.Add(myCar);

            #endregion

            #region Dictionary
            // Creating a Dictionary
            Dictionary<string, int> examPoints = new Dictionary<string, int>()
            {
                { "John", 70 },
                { "Bob", 45 },
                { "Jack", 100 }
            };

            // Adding elements in the Dictionary
            // => KEY MUST BE A UNIQUE VALUE !!
            examPoints.Add("Dejan", 81);
            examPoints.Add("Kristina", 92);

            examPoints.Remove("John");

            foreach (var item in examPoints)
            {
                Console.WriteLine($"The Student {item.Key} has {item.Value} points on the exam !");
            }

            Dictionary<string, Car> carsWithPlates = new Dictionary<string, Car>();

            Car newCar = new Car() { Model = "Mercedes" };
            Car newCar2 = new Car() { Model = "Toyota" };
            carsWithPlates.Add("SK1234WD", myCar);
            carsWithPlates.Add("SK4321AS", newCar);
            carsWithPlates.Add("SK1111AA", newCar2);

            // Dictionary method that tell us wheather it contains element with the 
            // key provided as parameter => it returns bool (true/false)
            Console.WriteLine(carsWithPlates.ContainsKey("SK1234WD"));

            // Another Dictionary method that tell us wheather it contains element with the 
            // value provided as parameter => it returns bool (true/false)
            Console.WriteLine(carsWithPlates.ContainsValue(new Car()));

            // we can access the element if we provide the correct key
            Car result = carsWithPlates["SK4321AS"];

            Console.WriteLine("Before remove {0}", carsWithPlates.Count);

            carsWithPlates.Remove("SK1111AA");

            Console.WriteLine("After remove {0}", carsWithPlates.Count);

            Console.WriteLine(result.Model);




            #endregion

            #region Queue and Stack
            // Creating an empty Queue
            Queue<string> students = new Queue<string>();

            // adding elements
            students.Enqueue("Marko");
            students.Enqueue("Ivan");
            students.Enqueue("Radmila");

            // removing elements
            students.Dequeue();

            // checking what is the next element in the Queue
            Console.WriteLine(students.Peek());

            Console.WriteLine(students.Dequeue());

            // Creating an empty Stack
            Stack<Car> carStack = new Stack<Car>();

            // Adding elements in the Stack
            carStack.Push(myCar);
            carStack.Push(newCar);
            carStack.Push(newCar2);

            // Removing the elements from the Stack
            // The Pop() method returns the poped elements, so we can access its properties
            Console.WriteLine(carStack.Pop().Model);

            #endregion

            Console.ReadLine();
        }
    }
}
