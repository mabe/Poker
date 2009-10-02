using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poker
{
    public class StraightFlush : HandType
    {
        public StraightFlush(IEnumerable<Card> cards, IEnumerable<Card> cardsOnTable) : base(cards, cardsOnTable) { }

        public override byte Rank
        {
            get { return 8; }
        }

        public override bool Check()
        {
            //return base.Check();

            throw new NotImplementedException();
        }
    }
}
