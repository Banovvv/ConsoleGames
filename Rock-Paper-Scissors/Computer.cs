using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    public class Computer : Player
    {
        private static Random _random;
        private static List<string> _moves;

        public Computer()
        {
            _random = new Random();
            _moves = new List<string>()
            {
                "Rock",
                "Paper",
                "Scissors"
            };
        }
        public static string GetComputerInput()
        {
            return _moves[_random.Next(0, _moves.Count)];
        }
    }
}
