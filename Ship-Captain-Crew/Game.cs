using System;
using System.Collections.Generic;
using System.Text;

namespace Ship_Captain_Crew
{
    public class Game
    {
        private readonly string PlayerName;

        public Game()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WindowWidth = 40;

            PlayerName = GetValidPlayerName();
        }

        public void Run()
        {
            while (true)
            {
                DrawField();

                Player player = new Player();
                player.SetName(PlayerName);
                Computer computer = new Computer();

                player.PlayMove();
                computer.PlayMove();

                GetWinner(player, computer);

                Pause();
            }
        }

        private void GetWinner(Player player, Computer computer)
        {
            if(player.Score > computer.Score)
            {
                Console.WriteLine("You win!");
                Console.WriteLine($"Your score is {player.Score},\nwhile the Computer has {computer.Score}");
            }
            else if (player.Score < computer.Score)
            {
                Console.WriteLine("Computer wins!");
                Console.WriteLine($"The Computer has a score of {computer.Score},\nwhile you have {player.Score}");
            }
            else
            {
                Console.WriteLine("Draw!");
                Console.WriteLine($"Both you and the Computer\nhave a score of {player.Score}");
            }
        }

        private string GetValidPlayerName()
        {
            DrawField();

            Console.Write("Please enter your name: ");

            string name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Your name shouldn't be empty, try again.");
                GetValidPlayerName();
            }

            return name;
        }

        internal void Pause()
        {
            Console.WriteLine();
            Console.WriteLine("Press <ENTER> to continue");
            Console.ReadLine();
        }

        internal void DrawField()
        {
            Console.Clear();

            Console.WriteLine($@"           Ship-Captain-Crew");
            Console.WriteLine(new string('#', 41));
            Console.WriteLine();
        }
    }
}
