using System.Collections.Generic;

namespace Models
{
    public class Round
    {
        public int RoundNumber { get; set; }
        public List<int> WiningNumbers { get; set; }
        public List<Ticket> Tickets { get; set; }

        public Round()
        {
        }

        public Round(int roundNumber)
        {
            RoundNumber = roundNumber;
            WiningNumbers = new List<int>();
            Tickets = new List<Ticket>();
        }
    }
}
