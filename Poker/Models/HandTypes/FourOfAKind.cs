using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poker
{
    public class FourOfAKind : HandType
    {
        public FourOfAKind(Hand hand) : base(hand) { }

        public override byte Rank
        {
            get { return 7; }
        }

        public override bool Check()
        {
            var pairs = (from c in AllCards group c by c.Index into pair where pair.Count() == 4 select pair).Count();

            return pairs > 0;
        }
    }
}
