using System;
using System.Collections.Generic;
using System.Text;

namespace HeroVersusVillain
{
    abstract class Action
    {
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Multiplier { get; set; } = 1;
        public int TotalAction => Strength * Multiplier;

        public Action(string Name, int Strength)
        {
            this.Name = Name;
            this.Strength = Strength;
        }

        public override string ToString()
        {
            return $"{Name}. Base Strength: {Strength}.";
        }

        public virtual int UpdateMultiplier() 
        {
            Multiplier = GetRandom(0, 6);
            Console.WriteLine($"{Multiplier}. Total Action Strength: {TotalAction}");
            return Multiplier;
        }

        public int GetRandom(int min, int max)
        {
            Random rand = new Random();
            int randomNum = rand.Next(min, max);
            return randomNum;
        }
    }
}
