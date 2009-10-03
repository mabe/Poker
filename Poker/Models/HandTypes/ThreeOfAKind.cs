using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poker
{
    public class ThreeOfAKind : HandType
    {
        public ThreeOfAKind(Hand hand) : base(hand) { }

        public override byte Rank
        {
            get { return 3; }
        }

        public override bool Check()
        {
            //return base.Check();

            var pairs = (from c in AllCards group c by c.Index into pair where pair.Count() == 3 select pair).Count();

            return pairs > 0;
        }
    }
}
