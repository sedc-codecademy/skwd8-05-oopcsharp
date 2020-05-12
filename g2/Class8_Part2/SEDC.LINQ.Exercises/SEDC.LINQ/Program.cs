using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TeamSource.Enteties;
using TeamSource.Helpers;

namespace SEDC.LINQ
{
    class Program
    {
        static void Main(string[] args)
        {



            #region Exercises LINQ
            var teams = TeamsDataBase.GetAllTeams();

            // 1. Find all TEAMS with names starting with 'LA'
            List<Team> laTeams = teams.Where(team => team.Name.StartsWith("LA")).ToList();
            laTeams.ForEach(team => Console.WriteLine(team.Name));

            Console.WriteLine("==================================");
            // 2. Find all team NAMES which are playing in "Staples Center"
            List<string> staplesCenterTeams = teams
                                          .Where(team => team.Arena == "Staples Center")
                                          .Select(team => team.Name)
                                          .ToList();

            List<string> staplesCenterTeamsSecondWay = teams
                                                .Where(team => team.Arena.Equals("Staples Center"))
                                                .Select(team => team.Name)
                                                .ToList();

            staplesCenterTeams.ForEach(team => Console.WriteLine("Staples Center teams first way: " + team));
            Console.WriteLine("==================================");
            staplesCenterTeamsSecondWay.ForEach(team => Console.WriteLine("Staples Center teams second way: " + team));

            Console.WriteLine("==================================");
            // 3. Find all team coaches
            List<Coach> allTeamCoaches = teams.Select(team => team.Coach).ToList();
            allTeamCoaches.ForEach(coach => Console.WriteLine(coach.FullName));


            Console.WriteLine("==================================");
            // 4. Find the 3 oldest coaches NAMES
            List<string> oldestThreeCoaches = allTeamCoaches.OrderByDescending(coach => coach.Age)
                                                            .Take(3)
                                                            .Select(coach => coach.FullName)
                                                            .ToList();
            oldestThreeCoaches.ForEach(name => Console.WriteLine("Oldest coaches " + name));



            Console.WriteLine("==================================");
            // 4.Extended Display the oldest 3 coaches in the following format => Name: Gregg | Age: 50
            var oldestThreeCoachesNameAndAge = allTeamCoaches.OrderByDescending(coach => coach.Age)
                                                            .Take(3)
                                                            .Select(coach => new { FullName = coach.FullName, Age = coach.Age })
                                                            .ToList();
            oldestThreeCoachesNameAndAge.ForEach(coach => Console.WriteLine($"Name: {coach.FullName} | Age: {coach.Age}"));




            Console.WriteLine("==================================");
            // 5. Group all teams by their arenas
            var groupedTeamsByArenas = teams.GroupBy(x => x.Arena).ToList();

            foreach (var group in groupedTeamsByArenas)
            {
                Console.WriteLine("Arena: " + group.Key);
                Console.WriteLine("Teams: ");
                foreach (var team in group)
                {
                    Console.WriteLine(team.Name);
                }
            }


            Console.WriteLine("==================================");
            // 6. Find all players and extraxt them in one list
            List<Player> allPlayers = new List<Player>();

            // One way: more complex
            foreach (Team team in teams)
            {
                foreach (Player player in team.Players)
                {
                    allPlayers.Add(player);
                }
            }

            // Better way: in one line only
            teams.ForEach(team => allPlayers.AddRange(team.Players));

            allPlayers.ForEach(player => Console.WriteLine(player.FullName));


            Console.WriteLine("==================================");
            // 7. Group all players by team 
            // Team: LA Lakers
            // Players: Lebron James, Dwight Howard, Antony Davies

            var playerGroupedByTeam = teams.GroupBy(x => x.Players).ToList();

            foreach (var item in playerGroupedByTeam)
            {
                Console.WriteLine("Team: " + item.Last().Name);
                Console.WriteLine("Players: ");

                foreach (var player in item.Key)
                {
                    Console.WriteLine(player.FullName);
                }
            }


            Console.WriteLine("==================================");
            // 8. Find player with best avgPtsPerGame

            Player bestPlayer = allPlayers.OrderByDescending(player => player.PlayerStatistic["PtsPerGame"])
                                       .FirstOrDefault();

            // Using Max()
            float maxPtsPerGame = allPlayers.Max(x => x.PlayerStatistic["PtsPerGame"]);
            Player best = allPlayers
                        .Where(player => player.PlayerStatistic["PtsPerGame"] == maxPtsPerGame)
                        .FirstOrDefault();

            Console.WriteLine($"{bestPlayer.FullName} | PtsPerGame: {bestPlayer.PlayerStatistic["PtsPerGame"]}");




            Console.WriteLine("=================================================");            
            // 10. Find ALL players that have PtsPerGame > 20

            List<Player> aboveTwentyPoints = allPlayers
                                            .Where(x => x.PlayerStatistic["PtsPerGame"] > 20)
                                            .OrderBy(x => x.PlayerStatistic["PtsPerGame"])
                                            .ToList();
            aboveTwentyPoints.ForEach(player => Console.WriteLine(player.PlayerStatistic["PtsPerGame"]));                               

            #endregion


            #region Something new
            // ArrayList - Non generic collection in C#
            Console.WriteLine("=========================== Array list example ===================================");
            ArrayList array = new ArrayList() { "Martin Panovski", 1, false, true, 21.5f, };
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }



            Console.WriteLine("==================================");
            // Any() & All()
            // 9. Find if there is a player that has > 35 years

            bool olderThanThirtyFive = allPlayers.Any(player => player.Age >= 35);
            if (allPlayers.Any(player => player.Age >= 35))
            {
                Console.WriteLine($"There is a player that is older than 35 years.");
            }
            else
            {
                Console.WriteLine("No player older that 35 years found.");
            }

            Console.WriteLine(olderThanThirtyFive);




            if (allPlayers.All(x => x.Age >= 20 && x.Age <= 35))
            {
                Console.WriteLine("All players satisfied the condition!");
            }
            else
            {
                Console.WriteLine("Fail.");
            }

            #endregion














            Console.ReadLine();
        }
    }
}
