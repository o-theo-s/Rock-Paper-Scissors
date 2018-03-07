using System;

namespace RockPaperScissors.Players.Has
{
    //The winner class
    public partial class HasPlayer : IPlayer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Owner { get; set; } 
        public uint Score { get; set; }

        public HasPlayer()
        {
            this.ID = 1;
            this.Name = "HasPlayer";
            this.Owner = "Hasmik";
            this.Score = 0;
        }

        virtual public Move NextMove()
        {
            throw new NotImplementedException();
        }
    }
}
