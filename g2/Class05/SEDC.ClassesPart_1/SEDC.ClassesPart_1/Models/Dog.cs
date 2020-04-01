using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.ClassesPart_1.Models
{
    public class Dog
    {
        public string Name;
        public string Sort;
        public string Color;

        public void Bark()
        {
            Console.WriteLine("Woof woof!!!");
        }
    }
}
