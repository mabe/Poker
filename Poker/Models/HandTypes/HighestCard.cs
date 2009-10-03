using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poker
{
    public class HighestIndex : HandType
    {
        public HighestIndex(Hand hand) : base(hand) { }

        public override byte Rank
        {
            get { return 0; }
        }

        public override bool Check()
        {
            return true;
        }
    }
}
