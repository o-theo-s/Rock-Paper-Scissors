using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
    public static class Miscellaneous
    {
        public static List<Move> Player1Moves { get; set; } = new List<Move>();
        public static List<Move> Player2Moves { get; set; } = new List<Move>();
    }

    public enum Move
    {
        Rock, Paper, Scissors
    }
}
