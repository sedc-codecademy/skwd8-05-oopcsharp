namespace Models
{
    public class Player
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Position Position { get; set; }
        public int Number { get; set; }
        public bool IsCaptain { get; set; }

        public Player(string firstName, string lastName, int number, Position position, bool isCaptain = false)
        {
            FirstName = firstName;
            LastName = lastName;
            Number = number;
            Position = position;
            IsCaptain = isCaptain;
        }

        public string GetPlayerInfo()
        {
            //string captain = "";

            //if (IsCaptain)
            //{
            //    captain = "C";
            //}

            string captain = IsCaptain ? "C" : string.Empty;

            return $"{Number}. {FirstName} {LastName} ({Position}) {captain}";
        }
    }
}
