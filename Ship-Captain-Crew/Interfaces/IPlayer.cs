using System.Collections.Generic;

namespace Ship_Captain_Crew.Interfaces
{
    public interface IPlayer
    {
        string Name { get; set; }
        int Score { get; set; }
        List<Die> Dice { get; set; }
        List<Die> Bank { get; set; }
        void PlayMove();
        void PrintScore();
        void CalculateScore();
        void SetName(string name);
    }
}
