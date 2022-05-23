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

        internal void CompareChoices(string player, string computer)
        {
            int result = 0;

            if (player == "R" && computer == "R")
            {
                result = 0;
            }
            else if (player == "R" && computer == "P")
            {
                result = 1;
            }
            else if (player == "R" && computer == "S")
            {
                result = -1;
            }

            if (result == 0)
            {
                Console.WriteLine();
                Console.WriteLine("Draw!");
            }
            else if (result == -1)
            {
                Console.WriteLine();
                Console.WriteLine("You win!");
            }
            else if (result == 1)
            {
                Console.WriteLine();
                Console.WriteLine("The Computer win!");
            }

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
