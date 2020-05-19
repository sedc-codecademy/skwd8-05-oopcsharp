using System.Collections.Generic;

namespace Models
{
    public class Lotto
    {
        public string Name { get; set; }
        public List<Round> Rounds { get; set; }

        public Lotto()
        {
        }

        public Lotto(string name)
        {
            Name = name;
            Rounds = new List<Round> { new Round(1) };
        }
    }
}
