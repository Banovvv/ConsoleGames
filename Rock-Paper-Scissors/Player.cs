using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    public class Player
    {
        private string? _playerInput;

        public string? GetUserInput()
        {
            _playerInput = Console.ReadLine();

            return _playerInput;
        }
    }
}
