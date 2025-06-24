using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int iScore = 0; // Starting score 
            int iRound = 1; // Current round 
            ShowResult(iScore); // ShowResult Method call 

            Console.WriteLine("Guess Heads (1) or Tails (2) for up to 5 rounds. ");
            Console.WriteLine(" Correct guesses earn +10 points, incorrect guesses deduct -5 points");
            Console.WriteLine("Invalid input default to Heads.");
            Console.WriteLine("The game ends early if the score would become negative");
            while( iRound <= 5)
            {
                Console.WriteLine(iRound);
                int iGuess = GetPlayerGuess();
                int iFlip = random.Next(1, 3);
                iScore = UpdateScore(iGuess, iFlip, iScore);
                if (iScore <0)
                {
                    ShowResult(iScore);
                    return ;
                }
                iRound++;
            }
            ShowResult(iScore);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        static int GetPlayerGuess()
        {
            int guess = 0;
            string sInput = "";
            Console.WriteLine("Guess: \n-1-Heads \n-2-Tails");
            sInput = Console.ReadLine();
            guess = int.Parse(sInput);
            if( (guess == 1 || guess == 2))
            {
  
                return guess;
            }
            else
            {
                Console.WriteLine("Invalid input, using Heads (1).");
                return 1;
            }
            
        }
        static int UpdateScore(int iGuess, int iFlips,int iScores)
        {
            Console.WriteLine("Coin shows : " + iFlips);
            if (iFlips == iGuess)
            {
                Console.WriteLine("Correct! +10 points");
                return iScores + 10;
            }
            else
            {
                Console.WriteLine("Wrong! - 5points");
                return (iScores - 5);
            }
        }
       private static int ShowResult(int iScore)
        {
            Console.WriteLine("Game Over! Final Score" + iScore );
            if (iScore < 25)
            {
                Console.WriteLine("Better luck next time!");
                
            }
            else
            {
                Console.WriteLine("Great job!");
            }
            return iScore;
        }
    }
}
