using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poker
{
    public class FourOfAKind : HandType
    {
        public FourOfAKind(IEnumerable<Card> cards, IEnumerable<Card> cardsOnTable) : base(cards, cardsOnTable) { }

        public override byte Rank
        {
            get { return 7; }
        }

        public override bool Check()
        {
            throw new NotImplementedException();
        }
    }
}
