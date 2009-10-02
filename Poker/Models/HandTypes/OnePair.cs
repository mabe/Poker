using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poker
{
    public class OnePair : HandType
    {
        public OnePair(IEnumerable<Card> cards, IEnumerable<Card> cardsOnTable) : base(cards, cardsOnTable) { }

        public override byte Rank
        {
            get { return 1; }
        }

        public override bool Check()
        {
            //return base.Check();

            var pairs = (from c in AllCards group c by c.Index into pair where pair.Count() == 2 select pair).Count();

            return pairs == 1;
        }
    }
}
