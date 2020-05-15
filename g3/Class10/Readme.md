# Class 10 - Error handling and Exceptions 😮

## Error handling
There are two main types of errors when working with C# and those are: 
* Build time errors - Errors that happen while the code is compiling and that is preventing the code from building and compiling ( Ex: Typo, Variable type mismatch etc. )
* Run time errors - Errors that happen while the application is already built and running ( Ex. A variable exceeded it's range, we called a method to a null variable etc. )

The errors in C# can be handled by writing a try/catch/finally block. This block tracks errors that will happen in the try block, add them in the catch block if something happens and then execute the finally block by default. 
```csharp
try
{
	int input = int.Parse(Console.ReadLine());
}
catch{Exception}
{
	Console.WriteLine("There was a problem!");
}
finally
{
	Console.WriteLine("Everything is done!");
}
```
## Exceptions
Exceptions are basically the embodiment of errors while working with C#. They are objects that hold errors neatly in one place. Every time an error happens, an exception is created and we can see this exception in detail while we are in Debug mode. Exceptions store a lot of data inside of them so the developer knows exactly what happened, where and how it happened. There are also different type of exceptions that represent a common error that can happen. We can write multiple catch blocks to handle different types of exceptions. The exceptions are caught by order, first checks the first block, then second and so on

### Catching an exception
```csharp
try
{
	int input = int.Parse(Console.ReadLine());
}
catch{Exception ex}
{
	Console.WriteLine($"ERROR: {ex.Message}");
}
finally
{
	Console.WriteLine("Everything is done!");
}
```
### Capture multiple exceptions
```csharp
try
{
	int input = int.Parse(Console.ReadLine());
}
catch{FormatException}
{
	Console.WriteLine("WRONG FORMAT! PLEASE ENTER THE RIGHT ONE!");
}
catch{Exception ex}
{
	Console.WriteLine($"ERROR: {ex.Message}");
}
finally
{
	Console.WriteLine("Everything is done!");
}
```


## Extra Materials 📘
* [Official Microsoft documentation for try/catch](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try-catch)
* [Handling exceptions best practices](https://stackify.com/csharp-exception-handling-best-practices/)
