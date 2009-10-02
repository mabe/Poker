using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poker
{
    public abstract class Hand
    {
        public abstract bool Check(IEnumerable<Card> cards);

        public abstract byte Rank
        {
            get;
        }

        public int HighestIndex
        {
            get;
            set;
        }
    }
}
