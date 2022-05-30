using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ship_Captain_Crew
{
    public class Computer : Player
    {
        private bool ShipCaptainCrew = false;

        public Computer()
        {
            Name = "Computer";
        }

        public new void PlayMove()
        {
            for (int @throw = 1; @throw <= 3; @throw++) // Every player has exactly three throws
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

                            Console.WriteLine("The Computer got the Ship.");
                        }

                        if (hasFive != null || Bank.Count == 2)
                        {
                            if (Bank.Count == 1)
                            {
                                Bank.Add(hasFive);
                                Dice.Remove(hasFive);

                                Console.WriteLine("The Computer got the Captain.");
                            }

                            if (hasFour != null)
                            {
                                Bank.Add(hasFour);
                                Dice.Remove(hasFour);

                                Console.WriteLine("The Computer got the Crew.");

                                ShipCaptainCrew = true;

                                CalculateScore();
                                PrintScore();
                                break;
                            }
                        }
                    }
                }

                if(!ShipCaptainCrew && @throw == 3)
                {
                    PrintScore();
                }
            }
        }

        public new void RollDice()
        {
            foreach (var die in Dice)
            {
                die.Roll();
            }

            Console.WriteLine($"The Computer rolled: {string.Join(", ", Dice.Select(x => x.Score))}");
        }

        public new void PrintScore()
        {
            Console.WriteLine($"The Computer's score is: {Score}");
            Console.WriteLine();
        }
    }
}
