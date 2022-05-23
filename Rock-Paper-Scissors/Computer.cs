﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    public static class Computer
    {
        private static Random _random;
        private static List<int> _moves = Enum.GetValues(typeof(Moves.ValidMoves)).Cast<int>().ToList();

        static Computer()
        {
            _random = new Random();
        }
        public static string GetComputerInput()
        {
            return GetRandomInput();
        }

        private static string GetRandomInput()
        {
            switch(_moves[_random.Next(0, _moves.Count)])
            {
                case 0: return "R";
                case 1: return "P";
                case 2: return "S";
                default: return string.Empty;
            }
        }
    }
}
