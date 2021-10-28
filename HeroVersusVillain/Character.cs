using System;
using System.Collections.Generic;
using System.Text;

namespace HeroVersusVillain
{
    abstract class Character
    {
        public string Name { get; set; } = "No Name";
        public int Health { get; set; } = 50;
        public virtual List<Attack> Attacks { get; set; } = new List<Attack> { new Attack("Baby Attack", 1) };
        public virtual List<Potion> Potions { get; set; } = new List<Potion> { new Potion("Basic Healing Draught", 1) };
        public virtual List<Defense> Defenses { get; set; } = new List<Defense> { new Defense("Basic Wooden Shield", 1) };

        public Character()
        {

        }
        public Character(string Name)
        {
            this.Name = Name;

        }
        public virtual Action Attack()
        {
            for(int i = 0; i < Attacks.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {Attacks[i]}");
            }
            int attackChoice = GetValidInput("Choose Your Attack: ", Attacks.Count);
           
            return Attacks[attackChoice - 1];

        }
        public virtual Action Defend()
        {
            Console.WriteLine("Mount Your Defense! ");
            for (int i = 0; i < Defenses.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {Defenses[i]}");
            }
            int defenseChoice = GetValidInput("Choose Your Defense: ", Defenses.Count);
            
            return Defenses[defenseChoice - 1];
        }
        public virtual void Heal()
        {

        }
       
        public int GetValidInput(string prompt, int size)
        {
            int response =-1;
            Console.Write(prompt);
            
            while(!int.TryParse(Console.ReadLine(), out response))
            {
                Console.WriteLine("Invalid Input, try again.");
                return GetValidInput(prompt, size);
            }
            if(response <= 0 || response > (size))
            {
                Console.WriteLine($"Input must be between 1 and {size}. Try Again.");
                return GetValidInput(prompt, size);
            }

            else
            {
                return response;
            }
            
        }
        public override string ToString()
        {
            return Name;
        }
        public int GetRandom(int min, int max)
        {
            Random rand = new Random();
            int randomNum = rand.Next(min, max);
            return randomNum;
        }

    }
}
