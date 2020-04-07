using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public class Human
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public string GetAge()
        {
            return $"{Age} years";
        }
    }
}
