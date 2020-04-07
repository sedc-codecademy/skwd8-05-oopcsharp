using System;
using Models;

namespace ClassesRetrospective
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog mirche = new Dog("Mirche", "French Bulldog", Models.Action.Tail);
            mirche.Eat();
            mirche.Bark();

            Console.WriteLine(mirche.CurrentState);

            Console.Read();
        }
    }
}
