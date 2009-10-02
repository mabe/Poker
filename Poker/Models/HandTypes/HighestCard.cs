using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poker
{
    public class HighestIndex : HandType
    {
        public HighestIndex(IEnumerable<Card> cards, IEnumerable<Card> cardsOnTable) : base(cards, cardsOnTable) { }

        public override byte Rank
        {
            get { return 0; }
        }
    }
}
