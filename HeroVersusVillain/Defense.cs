using System;
using System.Collections.Generic;
using System.Text;

namespace HeroVersusVillain
{
    class Defense : Action
    {
        public Defense(string Name, int Strength) : base(Name,Strength)
        {

        }

        public override int UpdateMultiplier()
        {
            Multiplier = GetRandom(0, 4);
            Console.WriteLine($"{Multiplier}. Total Action Strength: {TotalAction}");
            return Multiplier;
        }
    }
}
