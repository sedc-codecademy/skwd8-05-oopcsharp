using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void goThroughCollection(IEnumerable collection, string name)
        {
            Console.WriteLine("Collection {0} items:", name);
            foreach (var item in collection)
            {
                Console.Write("{0}  ", item);
            }
            Console.WriteLine("");
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //Array (you know everything about them already... fixed, rigid, hard to use)
            string[] stringsInArray1 = new string[4];
            string[] stringsInArray2 = new string[] { "Hello", "World", "!" };
            goThroughCollection(stringsInArray2, "Array"); //go through the collection with the fuction created above
            Console.WriteLine("Length: " + stringsInArray2.Length);

            //ArrayList (Accept all types and doesn't have constraint on number of elements) - a "list of arrays"
            ArrayList arrayList = new ArrayList() { "Hello", 5, 7.5 };
            arrayList.Add('h'); // adding an element to the ArrayList
            arrayList.Add(stringsInArray1);
            arrayList.RemoveAt(2); //removing an element from the ArrayList
            Console.WriteLine(arrayList[2]); //prints the third element od the ArrayList
            goThroughCollection(arrayList, "ArrayList"); //go through the collection with the fuction created above
            Console.WriteLine("Length: " + arrayList.Count);
            Console.WriteLine(arrayList);

            //List (Has designated type and does not have constraint on number of elements)
            List<int> listOfInt = new List<int> { 2, 44, 654, 24 };
            listOfInt.Add(7); //adding an element to the List
            listOfInt.Remove(654); //removing an element from the List
            Console.WriteLine(listOfInt[2]);
            goThroughCollection(listOfInt, "List"); //go through the collection with the fuction created above
            Console.WriteLine("Length: " + listOfInt.Count);

            //Dictionary (Works on Key/Value pair system. This system gives us the option to get values from collection by some key)
            Dictionary<string, string> dictionaryOne = new Dictionary<string, string>();
            dictionaryOne.Add("alek", "kocevski"); //adding an element to the Dictionary
            dictionaryOne.Add("deki", "blazheski");
            Dictionary<int, string> dictionaryTwo = new Dictionary<int, string> { { 1,"Hello"}, { 5,"World"}, { 10, "!"} };
            Console.WriteLine(dictionaryOne["alek"]);
            Console.WriteLine(dictionaryTwo[5]);
            goThroughCollection(dictionaryTwo, "Dictionary"); //go through the collection with the fuction created above
            Console.WriteLine("Length: " + dictionaryTwo.Count);

            //Queue (FIFO - First In First Out) not indexed, always the first element in the collection is the only availabe for use
            Queue<int> aQueue = new Queue<int>();
            aQueue.Enqueue(25);
            aQueue.Enqueue(45); // enqueue/adding an element to the queue
            aQueue.Enqueue(125);
            aQueue.Enqueue(225);
            goThroughCollection(aQueue, "Queue");
            Console.WriteLine(aQueue.Dequeue());
            aQueue.Dequeue(); // dequeue/removing an element of the queue
            if (aQueue.Peek() == 45) // peeking at the first/next element of the queue
            Console.WriteLine(aQueue.Dequeue());
            goThroughCollection(aQueue, "Queue"); //go through the collection with the fuction created above
            Console.WriteLine("Length: " + aQueue.Count);

            // Stack (LIFO - Last In First Out) not indexed, always the last element in the collection is the only availabe for use
            Stack<string> aStack = new Stack<string>();
            aStack.Push("Hello"); // pushing/adding an element to the stack
            aStack.Push("Hi"); 
            aStack.Push("hey");
            aStack.Push("zdravo");
            goThroughCollection(aStack, "Stack"); //go through the collection with the fuction created above
            Console.WriteLine(aStack.Pop()); // popping/removing an element from the stack
            Console.WriteLine(aStack.Peek()); // peeking at the last/next element of the stack
            goThroughCollection(aStack, "Stack"); //go through the collection with the fuction created above
            Console.WriteLine("Length: " + aStack.Count);

            Console.Read();
        }
    }
}
