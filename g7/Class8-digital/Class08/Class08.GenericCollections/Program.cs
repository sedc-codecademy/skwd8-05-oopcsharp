using System;
using System.Collections.Generic; // This makes Lists/Queues/Stacks/Dictionaries usable

namespace Class08.GenericCollections
{
	class User
	{
		public int Id { get; set; }
		public string Username { get; set; }
	}

	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			#region Array
			// Array
			string[] stringsInArray = new string[4];
			string[] stringsInArray2 = new string[] { "bob", "jill", "greg" };
			// Add another item in array we had to Resize
			// We must have fied number of items
			#endregion

			#region List
			// List
			// [ 1, 2, 3, 4, 5 ]
			// WE CAN GET ANY ITEM AT ANY TIME
			// WE CAN CHANGE ANY ITEM AT ANY TIME
			// WE CAN RE ORGANIZE ITEMS AT ANY TIME
			// WE CAN GET ANY ITEM BT INDEX
			List<string> listOfStrings = new List<string>(); // Empty list
			List<string> listOfStrings1 = new List<string>() { "bob", "jill", "greg" }; // List with predefined values
			listOfStrings.Add("first item"); // Add stuff
			listOfStrings1.Add("bill");
			Console.WriteLine(listOfStrings1[2]); // We can use indexes
			Console.WriteLine(listOfStrings1.Count); // gives the number of items ( like length )
			List<int> listOfInts = new List<int>() { 1, 2, 3, 4, 5 };
			listOfInts.Remove(2); // We remove an item ( 2 means the number, it finds the number 2 and removes it )
			foreach (int someInt in listOfInts)
			{
				Console.WriteLine(someInt);
			}
			Console.ReadLine();
			// KEEP IN MIND THAT:
			// IF WE WANT TO REMOVE AN OBJECT WE MUST REMOVE THE OBJECT BY ADDING THAT PARTICULAR OBJECT IN THE REMOVE METHOD
			// Even if you have 2 objects with ALL THE SAME values THEY ARE NOT THE SAME AND THE DELETE WILL NOT WORK
			// EX with objects:
			List<User> users = new List<User>()
			{
				// these are 2 users
				new User(){ Id = 1, Username = "Bob"},
				new User(){ Id = 2, Username = "Jill"}
			};
			// This bobtwin is the same as bob but it is allocated in a different memory spot
			// That means that even tho they are the same, they are DIFFERENT OBJECTS for C# language
			// Each time you write new -> You allocate a new memory spot for a new object
			// If two objects live on different addresses in memory, they are COMPLETLY DIFFERENT FOR C#
			User bobtwin = new User() { Id = 1, Username = "Bob" };  // Different object from users[0]
			users.Remove(bobtwin); // This will not remove bob
			users.Remove(users[0]); // This will remove bob since we gave the Remove function the correct bob
			Console.WriteLine("Bob comparer app:");
			Console.WriteLine(users[0] == bobtwin);  // Proves that they are different for C#
			Console.WriteLine(users[0] == users[0]); // Proves that they are the same for C#
			
			// Real world scenario:
			// You find the id of the user you want to delete
			// You make a request to the database to give you that user 
			// Then you tak that user and put it in the remove function
			// If you just put a user with the same ID in remove it will not remove it because it is not the same user
			foreach (User user in users)
			{
				Console.WriteLine(user.Username);
			}
			Console.ReadLine();
			#endregion

			#region Dictionary
			// Dictionary
			// WE MUST ADD 2 TYPES
			// The first is KEY and the second is VALUE
			// They both make a KEY VALUE PAIR
			Dictionary<int, string> dictionaryPhonebook = new Dictionary<int, string>(); // empty dictionary
			dictionaryPhonebook.Add(70444333, "Bob Bobsky"); // Add stuff
			dictionaryPhonebook.Add(77123123, "Jill Wayne");
			Dictionary<string, int> dictionaryPhonebookReverted = // initial values 
				new Dictionary<string, int>()
				{
					{"Bob", 70444333},
					{"Jill", 77123123}
				};
			// Because there is no key that is 0, it broke and it threw an Exception
			// Console.WriteLine(dictionaryPhonebook[0]); // 0 is not INDEX, it is KEY
			Console.WriteLine(dictionaryPhonebook[70444333]);
			Console.WriteLine(dictionaryPhonebookReverted["Bob"]);
			foreach (var item in dictionaryPhonebook)
			{
				Console.WriteLine($"KEY IS: {item.Key}"); // Takes the key out of one item
				Console.WriteLine($"VALUE IS: {item.Value}");  // Takes the value out of one item
			}

			Console.ReadLine();
			#endregion

			
			// Queue ( First In First Out  - FIFO )
			// [ 1, 2, 3, 4, 5 ]
			// Actions: Get item, Add item, See what item is next
			// WE CAN'T GET ANY ITEM AT ANY TIME
			// WE MUST GET THE ITEM THAT WAS ADDED FIRST EVERY TIME 
			// IN OUR CASE : 1
			// When we get 1 we are left with [ 2, 3, 4, 5 ]
			// Now if we want to get an item it must be 2
			// WE CAN'T ADD OR CHANGE ITEMS WHEREVER WE WANT
			// WE MUST ADD ITEM AT THE END OF THE QUEUE
			// In our case if we want to add the number 7 WE MUST DO IT LIKE THIS:
			// [ 1, 2, 3, 4, 5, 7 ] - This is the only way
			Queue<int> intQueue = new Queue<int>(); // Empty queue
			intQueue.Enqueue(1); // Only method for adding items in queue
			intQueue.Enqueue(2);
			intQueue.Enqueue(3);
			// intQueue[0]; // Can't get index items
			// Dequeue removes the item that is next to go and returns it
			int number = intQueue.Dequeue(); // number will get 1 but the queue will be [2, 3]
			Console.WriteLine(number);
			Console.WriteLine(intQueue.Peek()); // Just looks at the next item in line. DOES NOT TAKE IT OUT OF THE QUEUE
			intQueue.Enqueue(4);
			Console.WriteLine(intQueue.Peek());
			// After peek the queue will still be the same [2, 3]
			// We can peek as many times as we want as long as there is at least 1 item in the queue
			// We can't dequeue as many times because at some point we will empty the queue completely
			Console.ReadLine();
			intQueue.Dequeue();
			intQueue.Dequeue();
			// intQueue.Dequeue(); This will break the queue because we can't dequeue an empty queue


			// Stack ( Last In First Out  - LIFO )
			// [ 1, 2, 3, 4, 5 ]
			// Actions: Get item, Add item, See what item is next
			// WE CAN'T GET ANY ITEM AT ANY TIME
			// WE MUST GET THE ITEM THAT WAS ADDED LAST EVERY TIME
			// IN OUR CASE : 5
			// When we get 5 we are left with [ 1, 2, 3, 4 ]
			// Now if we want to get an item it must be 4
			// WE CAN'T ADD OR CHANGE ITEMS WHEREVER WE WANT
			// WE MUST ADD ITEM AT THE END OF THE STACK
			// In our case if we want to add the number 7 WE MUST DO IT LIKE THIS:
			// [ 1, 2, 3, 4, 5, 7 ] - This is the only way
			Stack<string> stringsStack = new Stack<string>(); 
			stringsStack.Push("Bob"); // We add stuff in the Stack
			stringsStack.Push("Jill");
			stringsStack.Push("Greg"); // ["Bob","Jill","Greg"]
			// stringsStack[0]; // This is broken since we can't use indexing
			string name = stringsStack.Pop(); // Remove the Last thing that was added and add it to the name variable
			// After the Pop: ["Bob","Jill"]
			Console.WriteLine(name);
			Console.WriteLine(stringsStack.Peek()); // Peek works exactly like queue just it looks for the last added
			stringsStack.Push("Meti");
			Console.WriteLine(stringsStack.Peek());
			// If we use Pop multiple times and empty the stack we will get an error that the stack is empty
			Console.ReadLine();
		}
	}
}
