using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace YanivGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of players");
            int players = int.Parse(Console.ReadLine());

            string winnerName = "";
            int winnerScore = -1;

            for (int i = 0; i < players; i++)
            {
                Console.WriteLine("Enter Player Name");
                string playerName = Console.ReadLine();

                Console.WriteLine("Enter number of Cards");
                int numOfCards = int.Parse(Console.ReadLine());
                int playerScore = 0;

                Console.WriteLine("Enter cards");
                for (int j = 0; j < numOfCards; j++)
                {
                    playerScore += int.Parse(Console.ReadLine());

                }

                if (playerScore < 7 && playerScore > winnerScore)
                {
                    winnerScore = playerScore;
                    winnerName = playerName;
                }
                

            }
            Console.WriteLine("The winner is " + winnerName);
            Console.WriteLine("The score is " + winnerScore);
        }
    }
}
