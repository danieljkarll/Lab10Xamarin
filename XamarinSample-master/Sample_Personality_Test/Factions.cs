using System;
using System.Collections.Generic;

namespace Sample_Personality_Test
{
    public class Factions
    {
        public Factions()
        {
        }

        public Factions(string name, int points)
        {
            Name = name;
            Points = points;
        }

        public string Name { private set; get; }

        public int Points { set; get; }

        static Factions()
        {
            List<Factions> all = new List<Factions>
            {
                new Factions("BrotherhoodOfSteel", 0),
                new Factions("FireBreathers",0),
                new Factions("Responders",0),
                new Factions("Railroad",0)
            };
            All = all;
        }
        public static IList<Factions> All { set; get; }
    }
}
