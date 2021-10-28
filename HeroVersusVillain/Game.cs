using System;
using System.Collections.Generic;
using System.Text;

namespace HeroVersusVillain
{
    class Game
    {
        public HeroList Heroes = new HeroList();
        public VillainList Villains = new VillainList();
        public Character Player { get; set; }
        public Character Opponent { get; set; }
        public Action PlayerAction { get; set; }
        public Action OpponentAction { get; set; }
        
        public bool IsSomeoneWinner => (Player.Health <= 0 || Opponent.Health <= 0);

        public void StartGame()
        {
            SetCharacters();
            Console.Clear();
            Console.WriteLine("\nLet's Play!\nPress any key to begin game...");
            Console.ReadKey();


            while(!IsSomeoneWinner)
            {
                TakeTurn();
            }
            GameOver();
        }

        public void SetCharacters()
        {
            Heroes.PrintCharacters();
            int choice = int.Parse(Program.GetInput("Choose your character: "));
            Player = Heroes.SelectCharacter(choice-1);
            Villains.PrintCharacters();
            choice = int.Parse(Program.GetInput("Choose your opponent: "));
            Opponent = Villains.SelectCharacter(choice - 1);

        }

        public void TakeTurn()
        {
            Console.Clear();
            Console.WriteLine($"Your Health: {Player.Health}");
            Console.WriteLine($"Opponent Health: {Opponent.Health}");
            PlayerAttack();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            OpponentAttack();
            Console.WriteLine("Press any key to continue to next turn...");
            Console.ReadKey();
        }

        public int UpdateHealth(int attacker, int defender)
        {
            int difference = Math.Abs(attacker - defender);
            if(attacker > defender) 
            {
                return difference;
            }
            else
            {
                Console.WriteLine("Attack successfully Defended!");
                return 0;
            }
        }

        public void PlayerAttack()
        {
            //Player's Attack:
            Console.WriteLine("\nYour Turn to Attack:");
            PlayerAction = Player.Attack();
            OpponentAction = Opponent.Defend();
            Console.WriteLine($"\nYou Chose {PlayerAction}.\nOpponent Defends with {OpponentAction}");
            Console.WriteLine("Roll for Multipliers: ");
            Console.Write($"{Player} rolls ");
            PlayerAction.UpdateMultiplier();
            Console.Write($"{Opponent} rolls ");
            OpponentAction.UpdateMultiplier();
            Opponent.Health -= UpdateHealth(PlayerAction.TotalAction, OpponentAction.TotalAction);
        }

        public void OpponentAttack()
        {
            //Player's Attack:
            Console.WriteLine("\nOpponents Turn to Retaliate!");
            PlayerAction = Player.Defend();
            OpponentAction = Opponent.Attack();
            Console.WriteLine($"\nYou Chose {PlayerAction}.\nOpponent Attacks with {OpponentAction}");
            Console.WriteLine("Roll for Multipliers: ");
            Console.Write($"{Player} rolls ");
            PlayerAction.UpdateMultiplier();
            Console.Write($"{Opponent} rolls ");
            OpponentAction.UpdateMultiplier();
            Player.Health -= UpdateHealth(OpponentAction.TotalAction, PlayerAction.TotalAction);
        }

        public void GameOver()
        {
            if (Player.Health < Opponent.Health)
            {
                Console.WriteLine($"{Opponent} has defeated you. You Lose!");
            }
            else if (Player.Health > Opponent.Health)
            {
                Console.WriteLine($"{Player} wins the game! Congratulations on keeping evil at bay!");
            }
            else
            {
                Console.WriteLine("You both have died! Valiant effort.");
            }
        }

    }
}
