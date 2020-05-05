using System;
using System.Collections.Generic;

namespace SEDC.GenericCollections
{

    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }

        public User(int id, string fullName)
        {
            this.Id = id;
            this.FullName = fullName;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            #region Generic collection: List<T>

            //List of strings
            List<string> animals = new List<string>();
            animals.Add("Dog");
            animals.Add("Cat");
            animals.Add("Elephant");
            animals.Add("Bird");

            foreach (string animal in animals)
            {
                Console.WriteLine($"This is {animal}");
            }

            //List of integers and add elements using Add()
            List<int> numbers = new List<int>();
            numbers.Add(4);
            numbers.Add(40);
            numbers.Add(10);
            numbers.Add(18);
            foreach (int num in numbers)
            {
                Console.WriteLine($"First list num: {num}");
            }


            List<int> numbers1 = new List<int> { 1, 2, 65, 7, 100 };
            foreach (int num in numbers1)
            {
                Console.WriteLine($"Second list num: {num}");
            }

            //Add elements using AddRange()
            List<int> mergedNums = new List<int>();
            mergedNums.AddRange(numbers);
            mergedNums.AddRange(numbers1);

            foreach (int num in mergedNums)
            {
                Console.WriteLine($"Merged numbers: {num}");
            }

            Console.WriteLine($"The merged list of nums has {mergedNums.Count} items.");
            Console.WriteLine("Element found at:" + mergedNums.IndexOf(100));


            //List of objects
            List<User> users = new List<User>()
            {
                new User(1, "Martin Panovski"),
                new User(2, "Ivo Kostovski"),
                new User(3, "Dejan Jovanov")

            };

            //User dejan = new User(3, "Dejan Jovanov");
            //users.Add(dejan);

            foreach (User user in users)
            {
                Console.WriteLine($"Before delete {user.Id} {user.FullName}");
            }

            //Remove element using Remove()
            //users.Remove(dejan);

            //Remove from index number of elements
            users.RemoveRange(0, 1);

            foreach (User user in users)
            {
                Console.WriteLine($"After delete: {user.Id} {user.FullName}");
            }

            #endregion


            #region Generic Collection: Dictionary<TKey, TValue>

            //Dictionary declaration
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            phoneBook.Add("Martin", "070222333");
            phoneBook.Add("Ivo", "078228899");
            phoneBook.Add("Nate", "075334443");

            //Remove element from the dictionary
            phoneBook.Remove("Nate");
            foreach (var record in phoneBook)
            {
                Console.WriteLine($"Name: {record.Key} | Phone: {record.Value}");
            }
            Console.WriteLine($"Name: {phoneBook["Martin"]}");



            //This is also posible
            Dictionary<List<string>, List<int>> hibridDictionary = new Dictionary<List<string>, List<int>>();

            //Dictionary of int and int
            Dictionary<int, int> numberDictionary = new Dictionary<int, int>();
            numberDictionary.Add(1, 1);
            numberDictionary.Add(2, 1);
            numberDictionary.Add(3, 2);

            foreach (var nums in numberDictionary)
            {
                Console.WriteLine($"{nums.Key} | {nums.Value}");
            }

            //Dictionary from int and User
            Dictionary<int, User> usersDictionary = new Dictionary<int, User>();

            User martin = new User(1, "Martin Panovski");

            usersDictionary.Add(1, martin);
            usersDictionary.Add(2, new User(1, "Ivo Kostovski"));
            foreach (var record in usersDictionary)
            {
                Console.WriteLine($"{record.Key} | {record.Value.FullName}");
            }
            #endregion


            #region Generic Collection: Queue
            Console.WriteLine("=========================================================");
            Queue<string> names = new Queue<string>();
            names.Enqueue("Bob");
            names.Enqueue("Jack");
            names.Enqueue("Jane");
            names.Enqueue("Mary");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            names.Dequeue();
            Console.WriteLine("After removing one element");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            string name1 = names.Peek();
            Console.WriteLine(name1);
            #endregion


            #region Generic Collection: Stack
            Console.WriteLine("==============================================");
            Stack<int> integerNumbers = new Stack<int>();
            integerNumbers.Push(1);
            integerNumbers.Push(2);
            integerNumbers.Push(3);
            integerNumbers.Push(4);
            integerNumbers.Push(5);

            foreach (int number in integerNumbers)
            {
                Console.WriteLine("Before editing the stack:" + number);
            }

            integerNumbers.Pop();
            integerNumbers.Pop();

            foreach (int number in integerNumbers)
            {
                Console.WriteLine("After editing the stack:" + number);
            }
            Console.WriteLine("This element is taken using Peek()" + integerNumbers.Peek());

            #endregion

            Console.ReadLine();
        }
    }
}
