using System;
using System.Collections.Generic;
using System.Text;
using RockPaperScissors;

namespace RockPaperScissors.Players
{
    public class RandomPlayer : IPlayer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Owner { get; set; }
        public uint Score { get; set; }

        public RandomPlayer()
        {
            this.ID = 0;
            this.Name = "Random";
            this.Owner = "None";
            this.Score = 0;
        }

        public Move NextMove()
        {
            return (Move) new Random().Next(0, 3);
        }
    }
}