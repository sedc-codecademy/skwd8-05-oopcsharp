﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Class07.Inheritance.Entities
{
	public class Animal
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public AnimalType Type { get; set; } // Unknow, Dog, Cat or Other
		// virtual - keyword that will make the child classes that inherit from animal to change this method if they want
		public virtual void Eat()
		{
			Console.WriteLine($"The {Type} animal named {Name} is eating!");
		}
		public virtual string PrintInfo()
		{
			return $"Id: {Id}, Animal: {Type}, Name: {Name}";
		}
		// Animal bob = new Animal(); -> Create an empty animal with the type Unknown
		// This constructor is also the default one
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
