# Class 08 - Collection Types 😏

## Different types of collections
Using collections is not always one fits all scenario. In C# this is very well addressed and there are multiple types of collections that we can use to fit our needs. Most of them are generic collections, meaning that we need to provide the type in special brackets like these < >. These generic methods also use different methods for manipulation from the arrays. Some of those are:
* List - A collection that is flexible, accepts as many items and is indexed
* Queue - A collection that is not indexed, accepts as many items, but has a special order of how the items are added or taken out of the collection ( First in is the first one out )
* Stack - A collection that is not indexed, accepts as many items, but has a special order of how the items are added or taken out of the collection ( Last in is the first one out )
* Dictionary - A collection that is flexible, accepts as many items and only keeps data in key - value pairs

### List
```csharp
// Create an empty list of strings
List<string> names = new List<string>();
// Add stuff to the list
names.Add("Bob");
names.Add("Midge");
names.Add("Red");
// Remove stuff from the list
names.Remove("Red");
// Find stuff from the list
names.Find("Midge");
// Number of elements
names.Count;
// Create and initialize a list of numbers
List<int> numbers = new List<int>(){ 2,89,4,8,6 };
```
## Dictionary
```csharp
// Create an empty dictionary
Dictionary<int, string> people = new Dictionary<int,string>();
// Add stuff to the dictionary
people.Add(1,"Bob");
people.Add(2,"Midge");
people.Add(3,"Red");
// Remove items by key value
people.Remove(3); // removes Red
// Find if a key exists
people.ContainsKey(2);
// Find if a value exists
people.ContainsValue("Midge");
// Number of elements
people .Count;
// Get value by key from a dictionary
people[1]; // this will return "Bob"
// Create and initialize a dictionary
Dictionary<string, bool> CheckList = new Dictionary<string, bool>(){ 
{"Potatoes", false},
{"Butter", true},
{"Salt", false},
{"Pepper", false}
};
// Getting first checklist item key and value
CheckList.First().Key // Returns "Potatoes"
CheckList.First().Value // Returns false

```
## Stack/Queue
```csharp
// Creating an empty Queue
Queue<string> people1 = new Queue<string>();
// Add stuff to the queue
people1.Enqueue("Bob");
people1.Enqueue("Midge");
people1.Enqueue("Red");
// Remove the item that is next in the queue
people1.Dequeue(); // removes Bob
// See which item is next in the queue
people1.Peek(); // returns Midge ( since we removed Bob )

// Creating an empty Stack
Stack<string> people2 = new Stack<string>();
// Add stuff to the Stack
people2.Push("Bob");
people2.Push("Midge");
people2.Push("Red");
// Remove the item that is next in the Stack
people2.Pop(); // removes Red
// See which item is next in the Stack
people2.Peek(); // returns Midge ( since we removed Red )
```

## Extra Materials 📘
* [Official Microsoft documentation for Collections](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/collections)
