using System;
using System.Collections.Generic;
using System.Text;

namespace HeroVersusVillain
{
    class Hero : Character
    {
        public Hero(string Name) : base(Name)
        {
            Attacks.Add(new Attack("Sword Strike", 2));
            Defenses.Add(new Defense("Copper Helmet", 1));
            Potions.Add(new Potion("Elixir of Life", 2));

        }


    }
}
