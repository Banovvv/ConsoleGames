using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    public class Game
    {
        public Game()
        {

        }

        public void Run()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WindowWidth = 50;

            while (true)
            {
                GameField();

                CompareChoices(Player.GetUserInput(), Computer.GetComputerInput());

                Pause();
            }
        }

        internal string CompareChoices(string player, string computer)
        {
            return string.Empty;
        }

        internal void Pause()
        {
            Console.WriteLine();
            Console.WriteLine("Press <ENTER> to continue");
            Console.ReadLine();
        }

        internal void GameField()
        {
            Console.Clear();

            Console.WriteLine($@"           Rock-Paper-Scissors");
            Console.WriteLine(new string('#', 41));
            Console.WriteLine();
        }
    }
}
