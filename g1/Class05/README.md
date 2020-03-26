# Class 05 - Classes and Objects

## Classes
Classes are the backbone of every object-oriented language. As we mentioned before classes are a building block of all object-oriented application. Classes are independent and inside them they hold methods values properties that are unique to them. When an application starts all of these classes work together to create a whole application. A class is actually not a normal entity. You can’t print a class or write a class. Classes are just templates that are used to build objects with the same functionalities that we are going to give the class to have. So if a class has property name every object that is created from that class will have a property name as well. With these classes we can create a network of entities and concepts that build our business logic and with that, use object oriented programming. 
#### Creating a class
```c#
public class Person
{
	public string Name;
	public string Age;
	private long AccountNumber;
	
	public void Introduce(){
		Console.WriteLine($"Hi my name is {Name} and I am {Age} years old !");
	}
}
```
## Objects
Objects in C# are the physical representation of the data that is created by the template ( the class ). These objects almost always come from some class and are used as a business logic entity for the mos part. Some times when we have service classes, they are used as the service object it self created from the service class. Objects can be created on their own or created with properties already ahead. These are some few ways of creating objects from a class:
```c#
Person bob = new Person();
bob.Name = "Bob";
bob.Age = 31;
bob.Introduce();
```

## Extra Materials 📘
* [Official Microsoft documentation for classes](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/classes)
* [Object Oriented C# in depth](https://www.c-sharpcorner.com/UploadFile/mkagrahari/introduction-to-object-oriented-programming-concepts-in-C-Sharp/)
