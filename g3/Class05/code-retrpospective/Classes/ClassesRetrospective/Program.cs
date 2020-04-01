using System;
using ClassesRetrospective.Models;

//namespace System
//{
//    class Console
//    {
//        void WriteLine()
//        {

//        }
//        void ReadLine()
//        {

//        }
//    }
//}

namespace ClassesRetrospective
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassesRetrospective.Models.Human dejan = new Human();
            Human vukashin = new Human("Vukashin", "Obradovikj", 27, 36382937);
            Human dragan = new Human
            {
                Name = "Dragan",
                //LastName = "",
                Age = 25
            };

            Vehicle audi = new Vehicle("", "", 231, "kola");
            audi.Start();
            audi.Drive();
            //audi.ValidateState();

            dejan.Name = "Dejan";
            dejan.LastName = "Blazheski";


            Console.Read();
        }
    }
}
