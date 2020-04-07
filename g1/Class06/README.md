# Class 06 - Constructors, Enums and Class Libraries

## Constructors
A huge role in C# classes play the constructors. Constructor is a method that is executed when an object is created from a class. Constructors in C# classes are written as methods but they don't have any return value and their name is always the same as the class name. The only thing that we can manipulate in a constructor are the parameters. Constructors in C# classes can actually have multiple constructors, and depending on how we create a class, we get a different execution of a constructor. This always depends on the parameters.
```c#
public class Person
{
	public string Name {get;set;}
	public string Age {get;set;}
	private long AccountNumber {get;set;}
	// Parametarless constructor ( new Person() )
	public Person(){
		AccountNumber = 34235432452;
	}
	// Constructor with parameters ( new Person("Bob", 34) )
	public Person(string name, int age)
	{
		Name = name;
		Age = age;
		AccountNumber = 25325325221;
	}
	public void Talk(string text){
		Console.WriteLine($"Human {Name} is saying {text}");
	}
}
```
#### Constructing object from constructor with parameters
```c#
// Using the first constructor
Person George = new Person();
// Using the second constructor
Person bill = new Person("Bill", 25);
bill.Talk();
```

## Enumerations
Enumerations are sort of like a collection of values that is fixed. When it is created it is done so with the idea in mind that the values will never chang and while the application is running it is impossible to add or remove an enumeration value.That is why they are usually used for common things that don't change like, names of the days of the week, names of months, names of continents, statuses from servers etc.
```c#
public enum Days 
{
	Monday,
	Tuesday,
	Wednesday,
	Thursday,
	Friday,
	Saturday,
	Sunday
}
```
### Using enums
Enumaration values can be used with the same syntax as properties on a class. The main difference is that enumerations do not have an instanciation. We can use them right away.
```c#
// "today" is some variable of type Days enum that we get from somewhere
if( today == Days.Friday )
{
	Console.WriteLine("PARTY");
} 
```

## Class Library
Class library project is a special project that is made for storing and using classes. This project can't be the main running project since it is not made for running, but storing classes. When we want to use classes from class libraries in other projects we need to remember to:
* Add a refference to that class library project to the currnet project
  * You can't have two projects refferencing each other
* Add a using statement above in the document where you are writing your code to access the class from the class library  

## Extra Materials
* [Official Microsoft documentation for Constructors](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/constructors)
* [.net pearls on Enums](https://www.dotnetperls.com/enum)
