using System;
using System.Collections.Generic;
using System.Linq;

namespace Ship_Captain_Crew
{
    public class Player
    {
        private bool ShipCaptainCrew = false;

        public Player()
        {
            Dice.Add(new Die());
            Dice.Add(new Die());
            Dice.Add(new Die());
            Dice.Add(new Die());
            Dice.Add(new Die());
        }

        public string Name { get; set; }
        public int Score { get; set; } = 0;
        public List<Die> Dice { get; set; } = new List<Die>();
        public List<Die> Bank { get; set; } = new List<Die>();

        public void PlayMove()
        {
            for (int i = 0; i < 3; i++) // Every player has exactly three throws
            {
                RollDice();

                if (!ShipCaptainCrew)
                {
                    Die hasSix = Dice.Where(x => x.Score == 6).FirstOrDefault();
                    Die hasFive = Dice.Where(x => x.Score == 5).FirstOrDefault();
                    Die hasFour = Dice.Where(x => x.Score == 4).FirstOrDefault();

                    if (hasSix != null || Bank.Count == 1)
                    {
                        if (Bank.Count == 0)
                        {
                            Bank.Add(hasSix);
                            Dice.Remove(hasSix);
                        }

                        if (hasFive != null || Bank.Count == 2)
                        {
                            if (Bank.Count == 1)
                            {
                                Bank.Add(hasFive);
                                Dice.Remove(hasFive);
                            }

                            if (hasFour != null)
                            {
                                Bank.Add(hasFour);
                                Dice.Remove(hasFour);

                                ShipCaptainCrew = true;
                            }
                        }
                    }
                }
                else
                {
                    foreach (var die in Dice)
                    {
                        Score += die.Score;
                    }
                }
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
