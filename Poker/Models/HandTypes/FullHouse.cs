using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poker
{
    public class FullHouse : HandType
    {
        public override byte Rank
        {
            get { return 6; }
        }

        public override bool Check(IEnumerable<Card> cards)
        {
            throw new NotImplementedException();
        }
    }
}
