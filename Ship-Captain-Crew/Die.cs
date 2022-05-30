using System;
using System.Text;

namespace Ship_Captain_Crew
{
    public class Die
    {
        private const int Sides = 6;
        private Random Random = new Random();

        public int Score { get; set; }

        public void Roll()
        {
            Score = Random.Next(0, Sides + 1);
        }

        public void Draw()
        {
            
        }

        internal string GetDiceDrawing()
        {
            StringBuilder sb = new StringBuilder();
            
            if(Score == 1)
            {
                sb.AppendLine("╔═══════╗");
                sb.AppendLine("║       ║");
                sb.AppendLine("║   o   ║");
                sb.AppendLine("║       ║");
                sb.AppendLine("╚═══════╝");
            }
            else if (Score == 2)
            {
                sb.AppendLine("╔═══════╗");
                sb.AppendLine("║     o ║");
                sb.AppendLine("║       ║");
                sb.AppendLine("║ o     ║");
                sb.AppendLine("╚═══════╝");
            }
            else if (Score == 3)
            {
                sb.AppendLine("╔═══════╗");
                sb.AppendLine("║     o ║");
                sb.AppendLine("║   o   ║");
                sb.AppendLine("║ o     ║");
                sb.AppendLine("╚═══════╝");
            }
            else if (Score == 4)
            {
                sb.AppendLine("╔═══════╗");
                sb.AppendLine("║ o   o ║");
                sb.AppendLine("║       ║");
                sb.AppendLine("║ o   o ║");
                sb.AppendLine("╚═══════╝");
            }
            else if (Score == 5)
            {
                sb.AppendLine("╔═══════╗");
                sb.AppendLine("║ o   o ║");
                sb.AppendLine("║   o   ║");
                sb.AppendLine("║ o   o ║");
                sb.AppendLine("╚═══════╝");
            }
            else if (Score == 6)
            {
                sb.AppendLine("╔═══════╗");
                sb.AppendLine("║ o o o ║");
                sb.AppendLine("║       ║");
                sb.AppendLine("║ o o o ║");
                sb.AppendLine("╚═══════╝");
            }

            return sb.ToString().Trim();
        }
    }
}
