using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Tiger : Cat
    {
        public override void MakeSound()
        {
            Console.WriteLine("rawr rawr");
        }
        public virtual void MakeATigerSound()
        {
            Console.WriteLine("rawr rawr");
        }
    }
}
