using System;
using System.Collections.Generic;
using System.Text;

namespace HeroVersusVillain
{
    class HeroList : CharacterList
    {

        public HeroList()
        {
            Characters.Add(new Hero("Kevin the Gallant"));
            Characters.Add(new Hero("Jacob the Giant"));
            Characters.Add(new Hero("Sir Billy the Brave"));
            Characters.Add(new Hero("Dame Maria the Majestic"));
            
        }

        public override void PrintCharacters()
        {
            Console.WriteLine("Heros:");
            base.PrintCharacters();
        }
    }
}
