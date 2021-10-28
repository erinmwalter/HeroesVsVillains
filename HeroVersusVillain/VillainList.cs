using System;
using System.Collections.Generic;
using System.Text;

namespace HeroVersusVillain
{
    class VillainList : CharacterList
    {
        public VillainList()
        {
            Characters.Add(new Villain("Petey the Pirate"));
            Characters.Add(new Villain("Glinda the Very Bad Witch"));
            Characters.Add(new Villain("Gary the Ghoul"));
            Characters.Add(new Villain("Gemini the Serial Killer"));
        }

        public override void PrintCharacters()
        {
            Console.WriteLine("Villains:");
            base.PrintCharacters();
        }
    }
}
