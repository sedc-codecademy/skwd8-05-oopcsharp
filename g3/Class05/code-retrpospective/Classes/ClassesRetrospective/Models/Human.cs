using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesRetrospective.Models
{
    class Human
    {
        public Human() { }
        public Human(string name, string lastName, int age, int accountNumber)
        {
            this.Name = name;
            LastName = lastName;
            Age = age;
            AccountNumber = accountNumber;
        }

        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        private int AccountNumber { get; set; }
    }
}
