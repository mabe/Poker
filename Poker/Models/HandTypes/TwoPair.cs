using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poker
{
    public class TwoPair : HandType
    {
        public TwoPair(IEnumerable<Card> cards, IEnumerable<Card> cardsOnTable) : base(cards, cardsOnTable) { }

        public override byte Rank
        {
            get { return 2; }
        }

        public override bool Check()
        {
            //return base.Check(cards, cardsOnHand);

            var pairs = (from c in AllCards group c by c.Index into pair where pair.Count() == 2 select pair).Count();

            return pairs == 2;
        }
    }
}
