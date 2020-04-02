using System;
using System.Collections.Generic;
using System.Text;

namespace Class5.classesOrganized.Domain
{
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
}
