using System;
using System.Collections.Generic;
using System.Text;

namespace Class07.Inheritance.Entities
{
	public class ServiceDog : Dog
	{
		public int Experience { get; set; }
		public bool IsTaken { get; set; }
		public ServiceDog()
		{
			Console.WriteLine("A service dog joined the force!");
		}
		public ServiceDog(int id, string name, string race, int exp, bool isTaken) 
			: base(id, name, race)
		{
			Experience = exp;
			IsTaken = isTaken;
			Console.WriteLine("A service dog with data was created!");
		}
	}
}
