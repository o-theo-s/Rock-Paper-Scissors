using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors.Players.Theo
{
    public class TheosPlayer : IPlayer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Owner { get; set; }
        public uint Score { get; set; }

        public TheosPlayer()
        {
            this.ID = 2;
            this.Name = "TheosPlayer";
            this.Owner = "Theofilos";
            this.Score = 0;
        }

        public virtual Move NextMove()
        {
            throw new NotImplementedException();
        }
    }
}
