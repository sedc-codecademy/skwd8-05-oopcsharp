using Class6.Domain.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Class6.Domain
{
	public class Dog
	{
		public string Name { get; set; }
		public DogBreed Breed { get; set; }
		public int Age { get; set; }
		public bool HasOwner { get; set; }
		public Person Owner { get; set; }
		// Dog sparky = new Dog();
		public Dog()
		{
			// Add logic to the constructor
			Name = "No name";
			Breed = DogBreed.Unknown;
			Age = 0;
			HasOwner = false;
			Console.WriteLine("Dog with no data was created!");
		}
		// Second constructor
		// Dog benny = new Dog("benny", DogBreed.GolderRetriever, 2);
		public Dog(string name, DogBreed breed, int age)
		{
			Name = name;
			Breed = breed;
			Age = age;
			HasOwner = false;
			Console.WriteLine("Dog with no owner was created!");
		}
		// Third constructor
		// Dog Zoe = new Dog("Zoe", DogBreed.Husky, 1, bob);
		public Dog(string name, DogBreed breed, int age, Person owner)
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
