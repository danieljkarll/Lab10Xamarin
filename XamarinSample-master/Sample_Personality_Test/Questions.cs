using System;
using System.Collections.Generic;

namespace Sample_Personality_Test
{
    public class Questions
    {
        // Instance members.
        private Questions()
        {
        }

        public Questions(string prompt, string left, string right, int affirmative, int negative)
        {
            Prompt = prompt;
            Left = left;
            Right = right;
            Affirmative = affirmative;
            Negative = negative; 
        }

        public string Prompt { private set; get; }

        public string Left { private set; get; }

        public string Right { private set; get; }

        public int Affirmative { private set; get; }

        public int Negative { private set; get; }

        // Static members.
        static Questions()
        {
            List<Questions> all = new List<Questions>
            {

                new Questions("You see a synth what do you do?", "Continue life as normal",
                              "Shoot it",3,0),
                new Questions("You see a man dying on the sidewalk what do you do?", "Try to help him",
                              "Loot.",2,0),
                new Questions("Whats the best strategy in a fight", "Flee",
                              "Destroy the creature. And Loot.",3,1),
                new Questions("Would you rather", "Help others",
                              "Achieving Victory whatever the cost may be",2,0)
            };
            All = all;
        }
        
     public static IList<Questions> All { private set; get; }
    }

}
