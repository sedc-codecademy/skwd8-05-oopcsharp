using System;

namespace EnumsApp
{
    // C# Enumeration (ENUMS)
    public enum Days
    {
        Monday = 1,
        Tueday = 3,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    class Program
    {
        static void Main(string[] args)
        {
            #region CodeEnum

            //var daysCompact = new int[] { 1, 2, 3, 4 };

            //var monday = 1;
            //var tuesday = 2;
            //var wednesday = 3;

            //if (tuesday == daysCompact[1])
            //{
            //    //Logic for count the students
            //}

            #endregion

            Console.WriteLine((int)Days.Monday);

            Console.ReadLine();

        }
    }
}
