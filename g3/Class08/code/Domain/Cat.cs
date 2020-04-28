using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Cat : Animal
    {
        public string Tail { get; set; }
        public string Fur { get; set; }

        public void Meow()
        {
            Console.WriteLine("moew moew");
        }
    }
}
