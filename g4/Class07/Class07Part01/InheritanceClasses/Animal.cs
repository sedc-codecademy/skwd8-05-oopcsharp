using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceClasses
{
    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        protected bool IsHappy { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine($"Id: {Id}, Amimal type: {Type}, Name: {Name}");
        }

        // if you want to change the implementation of the method in the classes that inherit
        public virtual void Eat()
        {
            Console.WriteLine($"The {Type} named {Name} is eating!");
        }

        // // this is an example of an overload of a method
        //public virtual void Eat(string food)
        //{
        //    Console.WriteLine($"{Name} is eating {food}");
        //}

        public Animal()
        {
            Console.WriteLine("A new instance of an animal has been created. This is the default Animal Constructor!");
        }

        public Animal(string type)
        {
            Type = type;
            Console.WriteLine("This is the Type Constructor of Animal!");
        }
    }
}
