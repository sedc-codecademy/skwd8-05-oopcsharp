using System;
using System.Collections.Generic;
using System.Text;

namespace Class6.Domain
{
	public class Dog
	{
		public string Name { get; set; }
		public string Breed { get; set; }
		public int Age { get; set; }
		public bool HasOwner { get; set; }
		public Person Owner { get; set; }
		// Dog sparky = new Dog();
		public Dog()
		{
			// Add logic to the constructor
			Name = "No name";
			Breed = "Labrador";
			Age = 0;
			HasOwner = false;
			Console.WriteLine("Dog with no data was created!");
		}
		// Second constructor
		public Dog(string name, string breed, int age)
		{
			Name = name;
			Breed = breed;
			Age = age;
			HasOwner = false;
			Console.WriteLine("Dog with no owner was created!");
		}
		// Third constructor
		public Dog(string name, string breed, int age, Person owner)
		{
			Name = name;
			Breed = breed;
			Age = age;
			HasOwner = true;
			Owner = owner;
			Console.WriteLine("Dog with owner was created!");
		}
		public string PrintInfo()
		{
			return $"{Name}({Breed}) - {Age}";
		}
	}
}
