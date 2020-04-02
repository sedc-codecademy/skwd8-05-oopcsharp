using System;
using System.Collections.Generic;
using System.Text;

namespace Class5.classesOrganized.Domain
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
}
