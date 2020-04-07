using System;
using Microsoft; // This namespace should be faded, because it's not used anywhere
//using Recap.Classes; // Uncommend this namespace and you will see the "I can't decide which class to use" error in line 13
using ExternalProject;

namespace Recap
{
    class Program
    {
        static void Main(string[] args)
        {
            // tip: use mouse hover on the classes to see from which namespace they are
            Recap.Classes.SEDC web = new Recap.Classes.SEDC();
            ExternalProject.SEDC qa = new ExternalProject.SEDC();
            SEDC design = new SEDC();

            ExternalProject.SEDC2 network = new ExternalProject.SEDC2();
            SEDC2 sedc2 = new SEDC2();

            Console.Read();
        }
    }
}
