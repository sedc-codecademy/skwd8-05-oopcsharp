using System;
using System.Collections.Generic;
using System.Text;
using TeamSource.Enteties;

namespace TeamSource.Helpers
{
    public class TeamsDataBase
    {
        public static List<Team> GetAllTeams()
        {
            return new List<Team>()
            {
                new Team()
                {
                    Name = "LA Lakers",
                    Arena = "Staples Center",
                    Coach = new Coach()
                    {
                        FullName = "Frank Vogel",
                        Age = 46
                    },
                    Players = new List<Player>()
                    {
                        new Player()
                        {
                            FullName = "Lebron James",
                            Age = 35,
                            PlayerStatistic = new Dictionary<string, float>()
                            {
                                { "PtsPerGame", 27.4f },
                                { "RebPerGame", 9.5f }
                            }
                        },
                        new Player()
                         {
                            FullName = "Dwight Howard",
                            Age = 34,
                            PlayerStatistic = new Dictionary<string, float>()
                            {
                                { "PtsPerGame", 6.7f },
                                { "RebPerGame", 7.5f }
                            }
                         },
                        new Player()
                          {
                            FullName = "Antony Davies",
                            Age = 27,
                            PlayerStatistic = new Dictionary<string, float>()
                            {
                                { "PtsPerGame", 28.9f },
                                { "RebPerGame", 10.7f }
                            }
                          }
                    }
                },
                new Team()
                {
                    Name = "LA Clippers",
                    Arena = "Staples Center",
                    Coach = new Coach()
                    {
                        FullName = "Doc Rivers",
                        Age = 58
                    },
                    Players = new List<Player>()
                    {
                        new Player()
                        {
                            FullName = "Lou Williams",
                            Age = 33,
                            PlayerStatistic = new Dictionary<string, float>()
                            {
                                { "PtsPerGame", 15.4f },
                                { "RebPerGame", 3.2f }
                            }
                        },
                         new Player()
                         {
                            FullName = "Kawai Leonard",
                            Age = 28,
                            PlayerStatistic = new Dictionary<string, float>()
                            {
                                { "PtsPerGame", 26.7f },
                                { "RebPerGame", 8.2f }
                            }
                         },
                          new Player()
                          {
                            FullName = "Paul George",
                            Age = 30,
                            PlayerStatistic = new Dictionary<string, float>()
                            {
                                { "PtsPerGame", 23.9f },
                                { "RebPerGame", 4.7f }
                            }
                          }
                    }
                },
                new Team()
                {
                    Name = "Boston Celtics",
                    Arena = "TD Garden",
                    Coach = new Coach()
                    {
                        FullName = "Brad Stevens",
                        Age = 42
                    },
                    Players = new List<Player>()
                    {
                        new Player()
                        {
                            FullName = "Jayson Tatum",
                            Age = 22,
                            PlayerStatistic = new Dictionary<string, float>()
                            {
                                { "PtsPerGame", 21.6f },
                                { "RebPerGame", 5.9f }
                            }
                        },
                         new Player()
                         {
                            FullName = "Jaylen Brown",
                            Age = 23,
                            PlayerStatistic = new Dictionary<string, float>()
                            {
                                { "PtsPerGame", 17.7f },
                                { "RebPerGame", 3.9f }
                            }
                         },
                          new Player()
                          {
                            FullName = "Marcus Smart",
                            Age = 26,
                            PlayerStatistic = new Dictionary<string, float>()
                            {
                                { "PtsPerGame", 7.1f },
                                { "RebPerGame", 5.2f }
                            }
                          }
                    }
                },
                new Team()
                {
                    Name = "Dallas Mavericks",
                    Arena = "American Airlines Center",
                    Coach = new Coach()
                    {
                        FullName = "Rick Carlisle",
                        Age = 60
                    },
                    Players = new List<Player>()
                    {
                        new Player()
                        {
                            FullName = "Luka Doncic",
                            Age = 21,
                            PlayerStatistic = new Dictionary<string, float>()
                            {
                                { "PtsPerGame", 31.6f },
                                { "RebPerGame", 9.7f }
                            }
                        },
                         new Player()
                         {
                            FullName = "Kristaps Porzingis",
                            Age = 24,
                            PlayerStatistic = new Dictionary<string, float>()
                            {
                                { "PtsPerGame", 17.7f },
                                { "RebPerGame", 5.9f }
                            }
                         },
                          new Player()
                          {
                            FullName = "Dwight Powell",
                            Age = 28,
                            PlayerStatistic = new Dictionary<string, float>()
                            {
                                { "PtsPerGame", 7.9f },
                                { "RebPerGame", 6.2f }
                            }
                          }
                    }
                },
                new Team()
                {
                    Name = "San Antonio Spurs",
                    Arena = "AT&T Center",
                    Coach = new Coach()
                    {
                        FullName = "Gregg Popovich",
                        Age = 71
                    },
                    Players = new List<Player>()
                    {
                        new Player()
                        {
                            FullName = "Lamarcus Aldridge",
                            Age = 34,
                            PlayerStatistic = new Dictionary<string, float>()
                            {
                                { "PtsPerGame", 21.6f },
                                { "RebPerGame", 8.7f }
                            }
                        },
                         new Player()
                         {
                            FullName = "DeMar DeRozan",
                            Age = 30,
                            PlayerStatistic = new Dictionary<string, float>()
                            {
                                { "PtsPerGame", 24.7f },
                                { "RebPerGame", 6.9f }
                            }
                         },
                          new Player()
                          {
                            FullName = "Patty Mills",
                            Age = 31,
                            PlayerStatistic = new Dictionary<string, float>()
                            {
                                { "PtsPerGame", 14.2f },
                                { "RebPerGame", 3.2f }
                            }
                          }
                    }
                },
                new Team()
                {
                    Name = "Golden State Warriors",
                    Arena = "Chase Arena",
                    Coach = new Coach()
                    {
                        FullName = "Steve Kerr",
                        Age = 54
                    },
                    Players = new List<Player>()
                    {
                        new Player()
                        {
                            FullName = "Steph Curry",
                            Age = 32,
                            PlayerStatistic = new Dictionary<string, float>()
                            {
                                { "PtsPerGame", 30.6f },
                                { "RebPerGame", 5.7f }
                            }
                        },
                         new Player()
                         {
                            FullName = "Klay Thompson",
                            Age = 30,
                            PlayerStatistic = new Dictionary<string, float>()
                            {
                                { "PtsPerGame", 24.7f },
                                { "RebPerGame", 6.9f }
                            }
                         },
                          new Player()
                          {
                            FullName = "Draymond Green",
                            Age = 30,
                            PlayerStatistic = new Dictionary<string, float>()
                            {
                                { "PtsPerGame", 11.2f },
                                { "RebPerGame", 8.9f }
                            }
                          }
                    }
                }
            };
        }
    }
}
