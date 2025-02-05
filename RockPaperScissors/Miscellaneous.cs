﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
    public static class Miscellaneous
    {
        public static List<Move> Player1Moves { get; set; } = new List<Move>();
        public static List<Move> Player2Moves { get; set; } = new List<Move>();

        public static void DisplayRoundResult(Move move1, Move move2, IPlayer p1, IPlayer p2)
        {
            Player1Moves.Add(move1);
            Player2Moves.Add(move2);

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
                Console.WriteLine($"Player 1 ({p1.Name}) wins!");
                Console.ForegroundColor = ConsoleColor.White;

                p1.Score++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Player 2 ({p2.Name}) wins!");
                Console.ForegroundColor = ConsoleColor.White;

                p2.Score++;
            }
        }
    }

    public enum Move
    {
        Rock, Paper, Scissors
    }
}
