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

                new Questions("What Planet Are You From?", "Earth",
                              "Titan",0,3),
                new Questions("Which option do you find more frightening?", "Death By Insects",
                              "Getting Stepped On",1,2),
                new Questions("Pick an option that best describes your personality.", "Humorous",
                              "Patriotic",2,0),
                new Questions("What Color Gauntlet Would You Use?", "Red",
                              "Gold",1,3)
            };
            All = all;
        }
        
     public static IList<Questions> All { private set; get; }
    }

}
