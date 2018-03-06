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
            Console.WriteLine("Welcome to the Rock Paper Scissors Competition!");

            IPlayer player1 = new RandomPlayer();
            IPlayer player2 = new RandomPlayer();

            int round = 1;
            while (player1.Score < 3 && player2.Score < 3)
            {
                Console.WriteLine($"\nRound {round}:");
                Move move1 = player1.NextMove();
                Move move2 = player2.NextMove();
                int result = move1 - move2;

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(move1.ToString());
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" vs ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(move2.ToString());
                Console.ForegroundColor = ConsoleColor.White;

                if (result == 0)
                {
                    Console.WriteLine("Tie");
                }
                else if (result == 1 || result == -2)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"Player 1 ({player1.Name}) wins!");
                    Console.ForegroundColor = ConsoleColor.White;

                    player1.Score++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"Player 2 ({player2.Name}) wins!");
                    Console.ForegroundColor = ConsoleColor.White;

                    player2.Score++;
                }

                Miscellaneous.Player1Moves.Add(move1);
                Miscellaneous.Player2Moves.Add(move2);

                Console.WriteLine($"Score: {player1.Score} - {player2.Score}");
                round++;
            }

            bool player1Win = player1.Score == 3;
            Console.WriteLine($"\n\nThe winner is Player {(player1Win ? 1 : 2)} ({(player1Win ? player1.Name : player2.Name)}). Well done {(player1Win ? player1.Owner : player2.Owner)}");
            Console.ReadKey();
        }
    }
}
