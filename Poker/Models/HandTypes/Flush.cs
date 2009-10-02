using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poker
{
    public class Flush : HandType
    {
        public Flush(IEnumerable<Card> cards, IEnumerable<Card> cardsOnTable) : base(cards, cardsOnTable) { }

        public override byte Rank
        {
            get { return 5; }
        }

        public override bool Check()
        {
            var flush = (from c in AllCards group c by c.Type into type where type.Count() >= 5 select type).SingleOrDefault();

            return flush != null;
        }
    }
}
