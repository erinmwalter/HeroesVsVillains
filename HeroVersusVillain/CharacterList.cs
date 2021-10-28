using System;
using System.Collections.Generic;
using System.Text;

namespace HeroVersusVillain
{
    abstract class CharacterList
    {
        public List<Character> Characters = new List<Character>();

        public Character SelectCharacter(int index)
        {
            return Characters[index];
        }

        public virtual void PrintCharacters()
        {
            for(int i = 0; i < Characters.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {Characters[i]}");
            }
        }

    }
}
