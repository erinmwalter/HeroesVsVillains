using System;

namespace HeroVersusVillain
{
    class Program
    {
        static void Main(string[] args)
        {
            Game myGame = new Game();
            Console.WriteLine("Welcome to Heroes vs. Villains!");
            
            while(true)
            {
                DisplayMainMenu();
                string choice = GetInput("Make your selection: ");
                if (choice == "1")
                {
                    myGame.StartGame();
                }
                else if (choice == "2")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("I'm sorry, Invalid Selection. Try Again.");
                }

            }
        }

        public static void DisplayMainMenu()
        {
            Console.WriteLine("1. New Game");
            Console.WriteLine("2. Exit");
        }

        public static string GetInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }
    }
}
