using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiers.Classes
{
    public class PublicClass : PrivateClass
    {
        public void PrintAge ()
        {
            Console.WriteLine(Age);
            //Console.WriteLine(Name);
        }
    }
}
