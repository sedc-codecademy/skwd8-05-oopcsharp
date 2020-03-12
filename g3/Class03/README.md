# Class 03 - Loops and Arrays 😉
## Loops
Repeating code multiple times is nothing new in programming and almost every programming language implements this feature in a pretty similar way. In C# there are also looping structures and they are very similar to some standard looping structures in programming. Those are: 
#### For
```c#
Console.WriteLine("Counting to 10...");
for(int i = 1; i <= 10; i++){
	Console.WriteLine("Counter is now:" + i);
}
Console.WriteLine("Done counting!");
Console.ReadLine();
```
#### While
```c#
Console.WriteLine("Counting to 10...");
int j = 1;
while(j <= 10){
	Console.WriteLine("Counter is now:" + j);
	j++;
}
Console.WriteLine("Done counting!");
Console.ReadLine();
```
## Arrays
The need for storing multiple values in one place is usually solved in programming languages with Arrays. These structures are present in C# and we are going to use them in the following classes. C# also has other collection types, but we will learn about them later in the subject. Arrays in C# are strict as everything else and we must always tell the array with what type it will be filled. We can't have an array with different values with different data types. Also the length of the array is fixed and it stays the same while we are working with it. The only way to change it is to change the max number of items the array can hold. Here is how we can create, use and change arrays in C#:
#### Creating an array
```c#
// Creating a new array with 2 items 
int[] intArray1 = new int[2];
intArray[0] = 2;
intArray[1] = -20;
```
```c#
int[] intArray2 = new int[] {2, -20};
```
```c#
int[] intArray2 = {2, -20};
```
#### Using Arrays
```c#
double[] doubleArray  =  new  double[] { 2.4, 11, 12, 634, 0.99 };
// Reversing array
Array.Reverse(doubleArray);

// Finding something in an array
int indexFound = Array.IndexOf(doubleArray, 12);
Console.WriteLine(indexFound);
int indexNotFound = Array.IndexOf(doubleArray, 5.5);
Console.WriteLine(indexNotFound);

// Change an array number of items
Array.Resize(ref doubleArray, 6);
doubleArray[5] = 105.6;
Console.WriteLine(doubleArray[5]);
Console.ReadLine();
```
#### Looping arrays
```c#
string[] names = new string[] {"Bob", "Jill", "Greg"};
Console.WriteLine("Writing names...");
for(int i = 0; i < names.Length; i++){
	Console.WriteLine(names[i]);
}
Console.ReadLine();
```

#### Looping arrays with foreach
```c#
string[] names = new string[] {"Bob", "Jill", "Greg"};
Console.WriteLine("Writing names...");
foreach(string name in names){
	Console.WriteLine(name);
}
Console.ReadLine();
```

## Extra Materials 📘
* [Official Microsoft documentation for arrays](https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/arrays)
* [.NET Pearls - Arrays](https://www.dotnetperls.com/array)
