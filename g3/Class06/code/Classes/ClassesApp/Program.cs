using Models;
using System;

namespace ClassesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog johnny = new Dog("DJohhny", "Pudlica", Models.Action.Eat);
            johnny.Eat();
            johnny.Tail();

            Console.WriteLine(johnny.CurrentState);

            Console.Read();
        }
    }
}
