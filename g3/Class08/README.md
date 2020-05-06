# Class 08 - Inheritance in C# 😅

## Class based Inheritance
Inheritance is one of the main concepts of object oriented programming. It is used to connect and link entities that have some hierarchical relation to one another. It can be used to link business logic as well as reuse and organize code. Class based inheritance means that the inheriting is abstract and that it is done on a class level. Classes inherit from other classes and when an object is created, it has the properties and methods of all the classes in the chain. C# Classes can inherit only from 1 class at a time.  
```c#
public class Human
{
    public string Name { get; set; }
    public int Age { get; set; }
    public void PrintInfo()
    {
        Console.WriteLine($"This is {Name} and it's of the age of {Age}.");
    }
}
```
Programmer inherits from Human along with all properties and Method PrintInfo
```c#
public class Programmer : Human
{
    public string[] ProgrammingLanugages { get; set; }
    public void DevelopApp()
    {
        Console.WriteLine($"The programmer {Name} is developing an app...");
    }
}
```
## Overriding methods
C# classes that inherit from other classes have a pretty cool features. They can override the methods that are on their parents. As long as their parent classes have a method that is open for overriding, they can override it and change the implementation.
## Overriding methods
```csharp
public class Human
{
    public string Name { get; set; }
    public int Age { get; set; }
    public virtual void PrintInfo()
    {
        Console.WriteLine($"This is {Name} and it's of the age of {Age}.");
    }
}
```
We override the method PrintInfo() from Human to do something else
```csharp
public class Programmer : Human
{
    public string[] ProgrammingLanugages { get; set; }
    public void DevelopApp()
    {
        Console.WriteLine($"The programmer {Name} is developing an app...");
    }
    public override void PrintInfo()
    {
        Console.WriteLine($"This is {Name} and these are the programming lanugages they know:");
        foreach (string language in ProgrammingLanugages)
        {
            Console.WriteLine(language);
        }
    }
}
```
## Extra Materials 📘
* [Official Microsoft documentation for inheritance](https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/inheritance)
* [.NET Pearls on Overriding](https://www.dotnetperls.com/override)
