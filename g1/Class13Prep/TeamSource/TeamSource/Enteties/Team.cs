using System;
using System.Collections.Generic;
using System.Text;

namespace TeamSource.Enteties
{
    public class Team
    {
        public string Name { get; set; }
        public string Arena { get; set; }
        public Coach Coach { get; set; }
        public List<Player> Players { get; set; }
    }
}
