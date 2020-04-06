using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Class07.App.Class
{
    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public Animal()
        {
        }

        public Animal(int id, string name, string type)
        {
            Id = id;
            Name = name;
            Type = type;
        }

        protected void Eat(string snack)
        {
            Console.WriteLine($"Id: {Id} Name: {Name}, Snack: {snack}");
        }

        public void PrintInfo()
        {

        }
    }
}
