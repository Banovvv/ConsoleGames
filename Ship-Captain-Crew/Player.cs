using System;
using System.Collections.Generic;

namespace Ship_Captain_Crew
{
    public class Player
    {
        public Player()
        {
            Dice.Add(new Die());
            Dice.Add(new Die());
            Dice.Add(new Die());
            Dice.Add(new Die());
            Dice.Add(new Die());
        }

        public string Name { get; set; }
        public List<Die> Dice { get; set; } = new List<Die>();
        public List<Die> Bank { get; set; } = new List<Die>();

        public void PlayMove()
        {
            for (int i = 0; i < 3; i++) // Every player has exactly three throws
            {

            }
        }

        public void RollDice()
        {
            foreach (var die in Dice)
            {
                die.Roll();
            }
        }

        public void SetName()
        {
            Console.Write("Please enter your name: ");

            string name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Your name shouldn't be empty, try again.");
                SetName();
            }
            else
            {
                Name = name;
            }
        }
    }
}
