using System;

namespace Class5.classes
{
	class Person
	{
		// Properties
		// Access modifier + Data Type + PascalCase Name + {get;set;}
		// Shortcut for property is -> prop + tab + tab
		// public -> Someone can access it with -> person.FirstName from the outside
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Age { get; set; }
		// private -> Can only be accessed from the class it self
		private long SSN { get; set; }

		// Method
		// Access modifier + Return Type + PascalCase Name + Parameters
		public string GetFullName()
		{
			return $"{FirstName} {LastName}";
		}
		public void ShowSSN()
		{
			long ssnhidden = SSN / 1000;
			Console.WriteLine($"SSN: {ssnhidden}xxx");
		}
		private void GenerateSSN()
		{
			// Fancy algorithm for generating SSN
			SSN = 503123454345;
			Console.WriteLine("SSN Generated");
		}
		// Constructor
		// It uses the same name as the class
		// It is written as a method but without return type
		// Shortcut for constructor is -> ctor + tab + tab
		public Person()
		{
			Console.WriteLine("Creating a new person...");
			GenerateSSN(); // We can use this here but not outside because here it is inside of the Person class
			// Private means that only the class can use that property or method
		}
	}

	class Dog
	{
		public string Name { get; set; }
		public int Age { get; set; }
		public Person Owner { get; set; }
		// Constructor with properties setting
		public Dog(string name, int age)
		{
			Name = name;
			Age = age;
			// Console.WriteLine(Owner.SSN); // You can't access this because it's private
			// Private only works for inside the class, in this case inside Person only
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
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
