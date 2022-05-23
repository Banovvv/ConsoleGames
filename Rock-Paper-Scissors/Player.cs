namespace Rock_Paper_Scissors
{
    public static class Player
    {
        private static List<int> _moves = Enum.GetValues(typeof(Moves.ValidMoves)).Cast<int>().ToList();


        public static string? GetUserInput()
        {
            Console.WriteLine("Your choice: [R]ock, [P]aper, [S]cissors?");
            string playerInput = Console.ReadLine();

            if (!IsValidInput(playerInput) || playerInput == null)
            {
                Console.WriteLine("Wrong input, try again");
                GetUserInput();
            }

            return playerInput;
        }

        private static bool IsValidInput(string input) => _moves.Contains(GetNumericInput(input));

        private static int GetNumericInput(string input)
        {
            switch (input)
            {
                case "R": Console.WriteLine("You selected Rock"); return 0;
                case "P": Console.WriteLine("You selected Paper"); return 1;
                case "S": Console.WriteLine("You selected Scissors"); return 2;
                default: return -1;
            }
        }
    }
}
