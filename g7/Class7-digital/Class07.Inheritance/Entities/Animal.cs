using System;
using System.Collections.Generic;
using System.Text;

namespace Class07.Inheritance.Entities
{
	public class Animal
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public AnimalType Type { get; set; } // Unknow, Dog, Cat or Other
		public void Eat()
		{
			Console.WriteLine($"The {Type} animal named {Name} is eating!");
		}
		public string PrintInfo()
		{
			return $"Id: {Id}, Animal: {Type}, Name: {Name}";
		}
		// Animal bob = new Animal(); -> Create an empty animal with the type Unknown
		public Animal()
		{
			Type = AnimalType.Unknown;
			Console.WriteLine("An animal is created!");
		}
		public Animal(int id, string name, AnimalType type)
		{
			Id = id;
			Name = name;
			Type = type;
			Console.WriteLine("An animal with data was created!");
		}
	}
}
