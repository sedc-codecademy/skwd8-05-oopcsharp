using System;
using Class5.classesOrganized.Domain; // refference to the namespace to use Dog and Person

namespace Class5.classesOrganized
{
	class Program
	{
		static void Main(string[] args)
		{
			// Namespace explanations
			// 1. Go to the class 
			// 2. See the namespace name and copy it
			// 3. Go back to the place you want to use that class
			// 4. At the top of the document write using and paste the name of the namespace of the class
			// # You can use multiple domains ( namespaces ) in one place
			// # You can have 2 diferent classes in 2 different files but with the same namespace ( Ex: Dog and Person )
			
			// Objects of classes can only change the properties that are set in the class
			// You can't set a property that does not exist in the class it self ( like JS )
			// You can't access a property that does not exist in the class it self ( like JS )
			// Instance of the class Person ( empty )
			Person bob = new Person(); // Constructor is called
			bob.FirstName = "Bob"; // Set property
			bob.LastName = "Bobski";
			bob.Age = 26;
			//bob.pet = "Rex"; // We can't access this because it does not exist
			//bob.SSN = 2345323253252; // We can't access this because it's private
			//Console.WriteLine(bob.SSN); // We can't access this because it's private
			Console.WriteLine(bob.FirstName); // Access property
			Console.WriteLine(bob.GetFullName()); // Access method
			bob.ShowSSN();
			//bob.GenerateSSN(); // We can't access this because it's private

			// Another way of instance of class
			Person jill = new Person() // Constructor is called
			{
				FirstName = "Jill",
				LastName = "Wayne",
				Age = 33
			};
			// Call a constructor with properties setting
			Dog rex = new Dog("Rex", 2);
			//rex.color = "brown"; // There is no color property in Dog class
			Console.ReadLine();
		}
	}
}
