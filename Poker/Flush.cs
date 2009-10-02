using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poker
{
    public class Flush : Hand
    {
        public override byte Rank
        {
            get { return 5; }
        }

        public override bool Check(IEnumerable<Card> cards)
        {
            throw new NotImplementedException();
        }
    }
}
