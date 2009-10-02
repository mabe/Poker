using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poker
{
    public class Seat
    {
        public Seat(byte number)
        {
            Number = number;
        }

        public Player Player
        {
            get;
            set;
        }

        public bool Dealer
        {
            get;
            set;
        }

        public byte Number
        {
            get;
            private set;
        }
    }
}
