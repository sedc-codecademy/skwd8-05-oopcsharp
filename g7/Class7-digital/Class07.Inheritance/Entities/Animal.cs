using System;
using System.Collections.Generic;
using System.Text;

namespace Class07.Inheritance.Entities
{
	// Public properties/methods - You can use them anywhere
	// ( USE THEM IN ANIMAL, CAT, DOG, OUTSIDE, IN ANOTHER CLASS )

	// Private properties/methods - You can only work with them in the class it self 
	// ( ONLY IN ANIMAL, NOT CAT, DOG OR OUTSIDE )

	// Protected properties/methods - You can only work with them in the class it self and the child classes that inherit from it
	// ( ONLY IN ANIMAL, CAT AND DOG BUT NOT OUTSIDE )
	// Protected only works for child classes that inherit from the parent which has the protected property
	// Parent class CAN'T use protected property of a child 
	// ( ANIMAL CAN'T USE PROTECTED PROPERTY OF DOG OR CAT )
	public class Animal
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public AnimalType Type { get; set; } // Unknow, Dog, Cat or Other
		// If you want something to be accessible ONLY for the Animal but not Cat or Dog or any child class
		// We use private
		private int ChipNumber { get; set; }
		// If you want to use some property or method in the child classes but not outside of them
		// We use protected
		protected int OwnerId { get; set; }
		// virtual - keyword that will make the child classes that inherit from animal to change this method if they want
		public virtual void Eat()
		{
			Console.WriteLine($"The {Type} animal named {Name} is eating!");
		}
		public virtual string PrintInfo()
		{
			return $"Id: {Id}, Animal: {Type}, Name: {Name}";
		}
		public bool ValidateChipNumber()
		{
			if (ChipNumber.ToString().Length != 9) return false;
			return true;
		}
		public void ShowChipNumber()
		{
			Console.WriteLine(ChipNumber);
		}
		// Animal bob = new Animal(); -> Create an empty animal with the type Unknown
		// This constructor is also the default one
		public Animal()
		{
			ChipNumber = 213432242; // Imagine that this was generated here
			Type = AnimalType.Unknown;
			Console.WriteLine("An animal is created!");
		}
		public Animal(int id, string name, AnimalType type)
		{
			ChipNumber = 213432242;  // Imagine that this was generated here
			Id = id;
			Name = name;
			Type = type;
			Console.WriteLine("An animal with data was created!");
		}
	}
}
