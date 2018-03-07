using RockPaperScissors.Players;
using RockPaperScissors.Players.Has;
using RockPaperScissors.Players.Theo;
using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Welcome to the Rock Paper Scissors Competition!\n");
            Console.WriteLine("What is the target score? Enter a number: ");
            int targetScore = Int32.Parse(Console.ReadLine());

            IPlayer player1 = new RandomPlayer();
            IPlayer player2 = new RandomPlayer();

            int round = 1;
            while (player1.Score < targetScore && player2.Score < targetScore)
            {
                Console.WriteLine($"\nRound {round}:");
                Move move1 = player1.NextMove();
                Move move2 = player2.NextMove();

                int result = Miscellaneous.DisplayRoundResult(move1, move2, player1, player2);

                if (result == 1)
                    player1.Score++;
                else if (result == 2)
                    player2.Score++;

                Console.WriteLine($"Score: {player1.Score} - {player2.Score}");
                round++;
            }

            bool player1Won = player1.Score == targetScore;
            Console.WriteLine($"\n\nThe winner is Player {(player1Won ? 1 : 2)} ({(player1Won ? player1.Name : player2.Name)}). Well done {(player1Won ? player1.Owner : player2.Owner)}");
            Console.ReadKey();
        }
    }
}
