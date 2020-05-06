using System;
using System.Collections.Generic;
using System.Text;

namespace Class07.Inheritance.Entities
{
	public class Dog : Animal
	{
		public string Race { get; set; }
		public void Bark()
		{
			Console.WriteLine("BARK BARK!");
		}
		public Dog()
		{
			Type = AnimalType.Dog;
			Console.WriteLine("A dog was created!");
		}

		// No implementation for Eat or PrintInfo

		public Dog(int id, string name, string race) : base(id, name, AnimalType.Dog)
		{
			Race = race;
			Console.WriteLine("A dog was created with data and the help of the parent constructor!");
		}
	}
}
