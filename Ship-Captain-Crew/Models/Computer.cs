using Ship_Captain_Crew.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Ship_Captain_Crew
{
    public class Computer : IPlayer
    {
        private bool ShipCaptainCrew = false;
                
        public Computer()
        {
            Dice.Add(new Die());
            Dice.Add(new Die());
            Dice.Add(new Die());
            Dice.Add(new Die());
            Dice.Add(new Die());
            SetName("Computer");
        }

        public string Name { get; set; }
        public int Score { get; set; } = 0;
        public List<Die> Dice { get; set; } = new List<Die>();
        public List<Die> Bank { get; set; } = new List<Die>();

        public void PlayMove()
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

                            Thread.Sleep(1000);
                        }

                        if (hasFive != null || Bank.Count == 2)
                        {
                            if (Bank.Count == 1)
                            {
                                Bank.Add(hasFive);
                                Dice.Remove(hasFive);

                                Console.WriteLine("The Computer got the Captain.");

                                Thread.Sleep(1000);
                            }

                            if (hasFour != null)
                            {
                                Bank.Add(hasFour);
                                Dice.Remove(hasFour);

                                Console.WriteLine("The Computer got the Crew.");

                                Thread.Sleep(1000);

                                ShipCaptainCrew = true;

                                CalculateScore();
                                PrintScore();
                                break;
                            }
                        }
                    }
                }

                if (!ShipCaptainCrew && @throw == 3)
                {
                    PrintScore();
                }
            }
        }

        public void RollDice()
        {
            foreach (var die in Dice)
            {
                die.Roll();
            }

            Console.WriteLine($"The Computer rolled: {string.Join(", ", Dice.Select(x => x.Score))}");

            Thread.Sleep(1000);
        }

        public void PrintScore()
        {
            Console.WriteLine($"The Computer's score is: {Score}");
            Console.WriteLine();
        }

        public void CalculateScore()
        {
            foreach (var die in Dice)
            {
                Score += die.Score;
            }
        }

        public void SetName(string name)
        {
            Name = name;
        }
    }
}
