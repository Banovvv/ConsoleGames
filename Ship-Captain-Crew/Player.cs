using System.Collections.Generic;

namespace Ship_Captain_Crew
{
    public class Player
    {
        public Player(string name)
        {
            Name = name;
            Dice.Add(new Die());
            Dice.Add(new Die());
            Dice.Add(new Die());
            Dice.Add(new Die());
            Dice.Add(new Die());
        }

        public string Name { get; set; }
        public List<Die> Dice { get; set; } = new List<Die>();

        public void RollDice()
        {
            foreach (var die in Dice)
            {
                die.Roll();
            }
        }
    }
}
