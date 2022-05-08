using System;
using System.Collections.Generic;
using System.Linq;


namespace DnD.Core
{
    public class Race
    {
        // The age of the character
        int age = 0;
        
        // Different types of alignment
        private enum AlignmentType
        {
            Lawful_Good,
            Neutral_Good,
            Chaotic_Good,
            Lawful_Neutral,
            Neutral,
            Chaotic_Neutral,
            Lawful_Evil,
            Neutral_Evil,
            Chaotic_Evil
        }
        
        // The height of the character
        string height = null;
        
        // The speed of the character
        int speed = 0;
        
        private enum Languages
        {
            Common,
            Dwarvish,
            Elvish,
            Giant,
            Gnomish,
            Goblin,
            Halfling,
            Orc,
            Abyssal,
            Celestial,
            Draconic,
            Deep_Speech,
            Infernal,
            Primodial,
            Sylvan,
            Undercommon
        }
    }
}
