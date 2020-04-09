using System;
using System.Collections.Generic;
using System.Text;

namespace Lotary.Entities
{
    public class Session
    {
        static int counter = 0;
        public Session()
        {
            counter += 1;
            SessionId = counter;
            WinningCombination = new int[7];
        }
        private int SessionId { get; set; }
        private int[] WinningCombination { get; set; }
        public Ticket[] Tickets { get; set; }

        public void StartSession()
        {
            Console.WriteLine("START");
        }

    }
}
