using System;
using System.Security.Cryptography.X509Certificates;
using Models;

namespace FootballLeague
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Liverpool
            Team liverpool = new Team("Liverpool");
            Player playerLiv1 = new Player("Anderson", "Anderson", 1, Position.Gk);
            Player playerLiv2 = new Player("Virgil", "Van Dyke", 4, Position.Def);
            Player playerLiv3 = new Player("Henderson", "Henderson", 8, Position.Mid, true);
            Player playerLiv4 = new Player("Mo", "Salah", 11, Position.Att);
            liverpool.AddPlayer(playerLiv1);
            liverpool.AddPlayer(playerLiv2);
            liverpool.AddPlayer(playerLiv3);
            liverpool.AddPlayer(playerLiv4);

            for (int i = 0; i < 10; i++)
            {
                liverpool.AddPoints(GetRandomResult());
            }
            #endregion

            #region Man Utd
            Team man = new Team("Man Utd");
            Player playerMan1 = new Player("David", "De Gea", 1, Position.Gk, true);
            Player playerMan2 = new Player("Phil", "Jones", 2, Position.Def);
            Player playerMan3 = new Player("Juan", "Mata", 8, Position.Mid);
            Player playerMan4 = new Player("Marcus", "Rashford", 10, Position.Att);
            man.AddPlayer(playerMan1);
            man.AddPlayer(playerMan2);
            man.AddPlayer(playerMan3);
            man.AddPlayer(playerMan4);

            for (int i = 0; i < 10; i++)
            {
                man.AddPoints(GetRandomResult());
            }
            #endregion

            #region Man City
            Team city = new Team("Man City");
            Player playerCity1 = new Player("Ederson", "Ederson", 1, Position.Gk);
            Player playerCity2 = new Player("Vincent", "Kompany", 2, Position.Def, true);
            Player playerCity3 = new Player("Frank", "De Bruyne", 5, Position.Mid);
            Player playerCity4 = new Player("Kun", "Aguero", 11, Position.Att);
            city.AddPlayer(playerCity1);
            city.AddPlayer(playerCity2);
            city.AddPlayer(playerCity3);
            city.AddPlayer(playerCity4);

            for (int i = 0; i < 10; i++)
            {
                city.AddPoints(GetRandomResult());
            }
            #endregion

            #region Chelsea
            Team chelsea = new Team("Chelsea");
            Player playerChelsea1 = new Player("Kepa", "Arizabalaga", 1, Position.Gk);
            Player playerChelsea2 = new Player("Kurt", "Zouma", 3, Position.Def);
            Player playerChelsea3 = new Player("N'golo", "Kante", 8, Position.Mid, true);
            Player playerChelsea4 = new Player("Tammy", "Abhram", 19, Position.Att);
            chelsea.AddPlayer(playerChelsea1);
            chelsea.AddPlayer(playerChelsea2);
            chelsea.AddPlayer(playerChelsea3);
            chelsea.AddPlayer(playerChelsea4);

            for (int i = 0; i < 10; i++)
            {
                chelsea.AddPoints(GetRandomResult());
            }
            #endregion

            #region League

            League premierLeague = new League("Premier League");
            premierLeague.AddTeam(liverpool);
            premierLeague.AddTeam(man);
            premierLeague.AddTeam(city);
            premierLeague.AddTeam(chelsea);

            #endregion

            #region Printing

            Console.WriteLine(premierLeague.GetTable());
            Console.WriteLine(liverpool.GetDetails());
            Console.WriteLine(man.GetDetails());
            Console.WriteLine(city.GetDetails());
            Console.WriteLine(chelsea.GetDetails());

            #endregion

        }

        public static Result GetRandomResult()
        {
            Result[] results = new Result[] {Result.Lost, Result.Draw, Result.Win};

            Random rnd = new Random();
            int rndIndex = rnd.Next(0, 3);

            return results[rndIndex];
        }
    }
}
