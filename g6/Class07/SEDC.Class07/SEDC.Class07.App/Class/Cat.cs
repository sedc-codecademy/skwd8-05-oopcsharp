using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Class07.App.Class
{
    public class Cat : Animal
    {
        public string Lazyness { get; set; }

        public Cat()
            :base()
        {
        }

        public Cat(int id, string name, string type)
            : base (id, name, type)
        {
        }

        public Cat(int id, string name, string type, string lazyness)
            : base(id, name, type)
        {
            Lazyness = lazyness;
        }

        public void Feed(string snack)
        {
            Eat(snack);
        }

        public void Meow()
        {

        }
    }
}
