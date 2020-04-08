using Class6.Domain;
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
	class Program
	{
		static void Main(string[] args)
		{
			Person bob = new Person()
			{
				FirstName = "Bob",
				LastName = "Bobsky",
				Age = 34
			};
			Dog sparky = new Dog();
			Dog benny = new Dog("benny", "labrador", 2);
			Dog Zoe = new Dog("Zoe", "husky", 1, bob);
			//Dog butch = new Dog("Butch"); // Will not work because we don't have this type of constructor

			Console.ReadLine();
		}
	}
}
