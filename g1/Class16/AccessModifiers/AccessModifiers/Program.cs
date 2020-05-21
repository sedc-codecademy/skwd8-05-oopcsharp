using AccessModifiers.Classes;
using System;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            var publicClass = new PublicClass();
            var internalClass = new InternalClass();
            var privateClass = new PrivateClass();
            publicClass.PrintAge();
            
            Console.ReadLine();
        }
    }
}
