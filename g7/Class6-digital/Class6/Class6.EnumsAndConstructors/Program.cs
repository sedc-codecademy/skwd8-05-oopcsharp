using Class6.Domain;
using Class6.Domain.Enumerations;
using System;

namespace Class6.EnumsAndConstructors
{
	// Connect project to another project
	// 1. Have multiple projects
	// 2. Go to the project where you want to use something from another project
	// 3. Go to dependencies/references right click
	// 4. Click Add reference
	// 5. Check the checkbox to the desired project that you want to use
	// 6. Add the using to the class that you want to use
	// Notes:
	// YOU CAN'T CONNECT TWO PROJECTS TO EACH OTHER DIRECTLY
	// YOU CAN'T CONNECT TWO PROJECTS TO EACH OTHER INDIRECTLY
	// THESE SCENARIOS WILL CAUSE A CIRCULAR REFERENCE ( CIRCULAR DEPENDENCY )
	// REFERENCES MUST HAVE A BEGINNING AND AN END

	// ENUM
	// Enums can only keep words
	// Enums can't keep numbers
	// Using enum: NameOfEnum.NameOfValue
	// Every enum can be used as value
	// We cant't use enum without any value
	// We can keep enum in a variable
	// Enums have number identifiers next to each value
	// If we don't put any numbers the default are 0, 1, 2, 3 ...
	public enum Orientation
	{
		South = 1,
		West = 2,
		North = 3,
		East = 4
	}

	class Program
	{
		static void Main(string[] args)
		{
			#region Constructors
			Person bob = new Person()
			{
				FirstName = "Bob",
				LastName = "Bobsky",
				Age = 34
			};
			Dog sparky = new Dog();
			Dog benny = new Dog("benny", DogBreed.GolderRetriever, 2);
			Dog Zoe = new Dog("Zoe", DogBreed.Husky, 1, bob);
			Console.WriteLine(benny.Breed);
			//Dog butch = new Dog("Butch"); // Will not work because we don't have this type of constructor
			#endregion
			#region Enums
			// Using enum
			Console.WriteLine($"We are going {Orientation.South}!");
			// Put enum in variable
			Orientation east = Orientation.East;
			Console.WriteLine($"It is wild {east} of here!");
			if(east == Orientation.East)
			{
				Console.WriteLine("Yes, it really is east!");
			}
			// Get enum from a number
			Orientation west = (Orientation)2;
			Console.WriteLine($"{west} is the way we are traveling!");
			// Get number from an enum
			int NorthNumber = (int)Orientation.North;
			Console.WriteLine($"North id is {NorthNumber}");
			#endregion
			Console.ReadLine();
		}
	}
}
