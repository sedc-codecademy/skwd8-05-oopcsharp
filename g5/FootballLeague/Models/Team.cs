namespace Models
{
    public class Team
    {
        public string Name { get; set; }
        private int Points { get; set; }
        public Player[] Players { get; set; }
        private int NumOfPlayers { get; set; }

        public Team(string name)
        {
            Name = name;
            Points = 0;
            Players = new Player[22];
            NumOfPlayers = 0;
        }

        public void AddPoints(Result result)
        {
            Points += (int) result;
        }

        public void AddPlayer(Player player)
        {
            if(NumOfPlayers == 22) return;

            Players[NumOfPlayers] = player;
            NumOfPlayers++;
        }

        public string GetBasicDetails()
        {
            return $"{Name} - {Points}";
        }

        public string GetDetails()
        {
            string details = GetBasicDetails();
            details += "\nPlayers: \n";

            for (int i = 0; i < NumOfPlayers; i++)
            {
                details += Players[i].GetPlayerInfo() + "\n";
            }

            return details;
        }
    }
}
