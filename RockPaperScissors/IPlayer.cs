using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
    public interface IPlayer
    {
        int ID { get; set; }
        string Name { get; set; }
        string Owner { get; set; }
        uint Score { get; set; }

        Move NextMove();
    }
}
