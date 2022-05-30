using System;
using System.Collections.Generic;
using System.Text;

namespace Ship_Captain_Crew
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
            Console.WindowWidth = 40;

            while (true)
            {
                DrawField();

                Pause();
            }
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
