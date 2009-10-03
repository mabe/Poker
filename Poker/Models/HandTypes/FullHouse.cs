using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poker
{
    public class FullHouse : HandType
    {
        public FullHouse(Hand hand) : base(hand) { }

        public override byte Rank
        {
            get { return 6; }
        }

        public override bool Check()
        {
            var pairs = (from c in AllCards group c by c.Index into pair select pair);

            return (pairs.Where(x => x.Count() == 3).Count() > 0 && pairs.Where(x => x.Count() == 2).Count() > 0);
        }
    }
}
