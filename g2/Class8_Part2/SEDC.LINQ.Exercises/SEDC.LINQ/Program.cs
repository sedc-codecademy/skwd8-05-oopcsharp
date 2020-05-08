using System;
using System.Collections.Generic;
using TeamSource.Helpers;

namespace SEDC.LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var teams = TeamsDataBase.GetAllTeams();

            Console.ReadLine();
        }
    }
}
