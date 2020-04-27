using Class07.Inheritance.Entities;
using System;

namespace Class07.Inheritance
{
	class Program
	{
		static void Main(string[] args)
		{
			Animal bob = new Animal();
			bob.Id = 12;
			bob.Name = "Bob";
			bob.Type = AnimalType.Dog;
			bob.Eat();
			Console.WriteLine(bob.PrintInfo());
			Console.ReadLine();
		}
	}
}
