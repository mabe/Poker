using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poker
{
    public class StraightFlush : HandType
    {
        public override byte Rank
        {
            get { return 8; }
        }

        public override bool Check(IEnumerable<Card> cards)
        {
            throw new NotImplementedException();
        }
    }
}
