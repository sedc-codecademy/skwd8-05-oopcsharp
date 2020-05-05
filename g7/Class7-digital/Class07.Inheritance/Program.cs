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
			Console.WriteLine("-----------------------------------");
			Cat izzy = new Cat();
			izzy.Id = 3;
			izzy.Name = "Izzy";
			izzy.Type = AnimalType.Cat;
			izzy.LazinessLevel = 100;
			izzy.Eat();
			Console.WriteLine(izzy.PrintInfo());
			izzy.Meow();
			Console.WriteLine("-------------------------------------");
			Cat meouw = new Cat(5, "Meouw", 9000);
			Console.WriteLine(meouw.PrintInfo());

			// meouw.ChipNumber; // We can't use private properties from the outside
			// meouw.OwnerId; // We can't use protected properties from the outside
			
			Console.WriteLine("---------------------------------------");
			Dog sparky = new Dog(6, "Sparky", "Labrador");
			sparky.Eat();
			Console.WriteLine(sparky.PrintInfo());

			Console.WriteLine("Is sparky chip Okay?");
			Console.WriteLine(sparky.ValidateChipNumber()); // Method returns a value and if we want to show it we must put it in a Console.WriteLine
			// sparky.ChipNumber; // This is private and it is not allowed
			sparky.ShowChipNumber(); // Method does not return anything since it executes Console.WriteLine it self, so id is called by it self without Console.WriteLine
			Console.WriteLine("---------------------------------------");
			ServiceDog rex = new ServiceDog(4, "Rex", "Poodle", 4, false);
			Console.WriteLine(rex.PrintInfo());
			rex.ShowChipNumber();
			Console.ReadLine();
		}
	}
}
