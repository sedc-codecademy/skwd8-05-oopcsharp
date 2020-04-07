using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceClasses
{
    public class Cat : Animal
    {
        // this is unique property to Cat. Cat has all the properties of Animal 
        public string Laziness { get; set; }

        public void Meow()
        {
            Console.WriteLine("MEOW MEOW");
        }

        // method Eat() from parent class is changed and now it prints something different
        public override void Eat()
        {
            Console.WriteLine("You don't tell a cat when to eat!!!");
        }

        // this constructor calls the Animal constructor that required Type
        public Cat() : base("cat")
        {
            Console.WriteLine("A new instance of cat is created by the parent constructor that requires a string");
        }
    }
}
