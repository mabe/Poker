using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poker
{
    public class Player
    {
        public Player(string name)
        {
            Name = name;
        }

        public string Name
        {
            get;
            private set;
        }

        public Hand Hand
        {
            get;
            set;
        }
    }
}
