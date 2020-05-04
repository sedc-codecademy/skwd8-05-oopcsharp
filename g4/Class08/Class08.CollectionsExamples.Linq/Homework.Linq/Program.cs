using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Homework.Linq
{
	public class Person
	{
		public Person(string firstName, string lastName, int age, char gender)
		{
			FirstName = firstName;
			LastName = lastName;
			Age = age;
			Gender = Gender;
		}

		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Age { get; set; }

		public char Gender { get; set; }

	}
	class Program
    {
        static void Main(string[] args)
        {

			List<Person> people = new List<Person>()
			{
			new Person("Bill", "Smith", 41, 'M'),
			new Person("Sarah", "Jones", 22, 'F'),
			new Person("Stacy","Baker", 21, 'F'),
			new Person("Vivianne","Dexter", 19, 'F' ),
			new Person("Bob","Smith", 49, 'M' ),
			new Person("Brett","Baker", 51, 'M' ),
			new Person("Mark","Parker", 19, 'M'),
			new Person("Alice","Thompson", 18, 'F'),
			new Person("Evelyn","Thompson", 58, 'F' ),
			new Person("Mort","Martin", 58, 'M'),
			new Person("Eugene","deLauter", 84, 'M' ),
			new Person("Gail","Dawson", 19, 'F' ),
			};

			// Task 01
			// all people aged 50 or more

			// Task 02
			// all people name starts with B

			// Task 03
			// first person whose surname starts with T

			// Task 04
			// find youngest and oldest person

			// Task 05
			// find all male people aged 45 or more

			// Task 06
			// find all females whose name starts with V

			// Task 07
			// find last female person older than 30 whose name starts with p

			// Task 08
			// find first male younger than 40


			Console.ReadLine();
        }
    }
}
