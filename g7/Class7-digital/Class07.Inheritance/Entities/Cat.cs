using System;
using System.Collections.Generic;
using System.Text;

namespace Class07.Inheritance.Entities
{
	// Cat inherits from Animal ( all properties and methods )
	public class Cat : Animal
	{
		public int LazinessLevel { get; set; }
		public void Meow()
		{
			Console.WriteLine("MEOW MEOW!");
		}
		// override - keyword that tells the parent class method Eat that it will be overriden
		// In this example we overide ALL the logic
		public override void Eat()
		{
			Console.WriteLine("You don't tell a cat when to eat. It eats when it wants!");
		}
		// In this example we execute the parent method and then add some extra stuff
		public override string PrintInfo()
		{
			// base.PrintInfo() -> Animal.PrintInfo() returns the result string from the parent and then we attach our own string to that one
			return base.PrintInfo() + $" Also it's level of lazyness is {LazinessLevel}!";
		}
		// This inherits from the empty constructor from Animal base() -> Animal()
		// This is the default one
		public Cat() : base()
		{
			//ChipNumber = 141414214; // We can't access this since it is private
			OwnerId = 1; // We can access this since it is protected and we are a child class of Animal
			Console.WriteLine("Cat was created!");
		}
		// Constructor v.1
		//public Cat(int id, string name, int lazinessLevel)
		//{
		//	Id = id;
		//	Name = name;
		//	LazinessLevel = lazinessLevel;
		//}

		// We call the parent constrcutor right when this constuctor is called ( base(id, name, type ) -> Animal(id, name, type) )
		public Cat(int id, string name, int lazinessLevel) : base(id, name, AnimalType.Cat)
		{
			LazinessLevel = lazinessLevel;
			Console.WriteLine("Cat was created but with data and with the help of the parent constructor!");
		}
	}
}
