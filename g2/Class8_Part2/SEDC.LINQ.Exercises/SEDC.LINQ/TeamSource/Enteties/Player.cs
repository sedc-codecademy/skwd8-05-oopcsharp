using System;
using System.Collections.Generic;
using System.Text;

namespace TeamSource.Enteties
{
    public class Player
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public Dictionary<string, float> PlayerStatistic { get; set; }

    }
}
