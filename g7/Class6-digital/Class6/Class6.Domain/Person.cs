using System;
using System.Collections.Generic;
using System.Text;

namespace Class6.Domain
{
	public class Person
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Age { get; set; }
		public Person()
		{
			Console.WriteLine("Empty person object was created!");
		}
		// Explanation for constructors and how we can use them
		// You can create 2 constructors with 1 parameter as long as it is different type
		public Person(string name)
		{

		}
		public Person(int age)
		{

		}
		// You can create 2 constructors with 2 paramters and the same types but in different order
		public Person(int age, string name)
		{

		}
		public Person(string lastName, int age)
		{

		}
		// Example of methods that use 2 paramters but different types
		// Polymorphism ( Trivia )
		public int Sum(int num1, int num2)
		{
			return num1 + num2;
		}
		public int Sum(string num1, string num2)
		{
			return int.Parse(num1) + int.Parse(num2);
		}
		public string PrintInfo()
		{
			return $"{FirstName} {LastName} - {Age}";
		}
	}
}
