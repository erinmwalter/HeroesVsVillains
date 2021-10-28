using System;
using System.Collections.Generic;
using System.Text;

namespace HeroVersusVillain
{
    class Villain :Character
    {
        public Villain(string Name) :base(Name)
        {
            Attacks.Add(new Attack("Dagger Throw", 2));
            Defenses.Add(new Defense("Chain Mail", 1));
            Potions.Add(new Potion("Cursed VooDoo Potion of Life", 2));
        }

        public override Action Attack()
        {
            int attackChoice = GetRandom(0, Attacks.Count);
            return Attacks[attackChoice];
        }

        public override Action Defend()
        {
            int defenseChoice = GetRandom(0, Defenses.Count);
            return Defenses[defenseChoice];
        }

        
    }
}
