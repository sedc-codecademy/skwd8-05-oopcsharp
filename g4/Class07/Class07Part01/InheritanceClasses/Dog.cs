using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceClasses
{
    public class Dog : Animal
    {
        // A property is unique to Dog class. It also has all Animal properties { Id, Type, Name }
        public string Race { get; set; }

        // This method is unique only to class Dog
        public void Bark()
        {
            Console.WriteLine("WOOF WOOF!");
        }

        public void IsDogHappy()
        {
            Console.WriteLine(IsHappy ? "I am a happy doggo!" : "I am sad!");
        }

        // Constructor of Dog that will be called on every instance
        // The Animal default constructor is first called, then this one
        public Dog()
        {
            IsHappy = true;
            Console.WriteLine("A new instance of Dog is created and also called the default Parent Constructor");
        }
    }
}
