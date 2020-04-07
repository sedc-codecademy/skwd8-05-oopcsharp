namespace Models
{
    public class League
    {
        public string Name { get; set; }
        public Team[] Teams { get; set; }
        private int NumOfTeams { get; set; }

        public League(string name)
        {
            Name = name;
            Teams = new Team[20];
        }

        public void AddTeam(Team team)
        {
            if(NumOfTeams == 20) return;

            Teams[NumOfTeams] = team;
            NumOfTeams++;
        }

        public string GetTable()
        {
            string table = "Premier League Table \n";
            for (int i = 0; i < NumOfTeams; i++)
            {
                table += Teams[i].GetBasicDetails() + "\n";
            }

            return table;
        }
    }
}
