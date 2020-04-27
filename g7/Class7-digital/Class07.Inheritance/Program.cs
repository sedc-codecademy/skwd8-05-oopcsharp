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
			Console.ReadLine();
		}
	}
}
