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
            while (true)
            {
                GameField();

                

                Pause();
            }
        }

        internal string CompareChoices(string player, string computer)
        {
            return string.Empty;
        }

        internal void Pause()
        {
            Console.WriteLine("\nPress <ENTER> to continue.");
            Console.ReadLine();
        }

        internal void GameField()
        {
            Console.Clear();

            Console.WriteLine($"Rock-Paper-Scissors\n{new string('#', 30)}\n");
        }
    }
}
