using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poker
{
    public class Straight : HandType
    {
        public Straight(IEnumerable<Card> cards, IEnumerable<Card> cardsOnTable) : base(cards, cardsOnTable) { }

        public override byte Rank
        {
            get { return 4; }
        }

        public override bool Check()
        {
            var indexs = (from c in AllCards group c by c.Index into index orderby index.Key select index.Key).ToList();

            int i = indexs.First(), straight = 0;

            foreach (var index in indexs)
            {
                straight++;

                if (i != index)
                {
                    i = index;
                    straight = 0;
                }

                i++;
            }

            return (straight > 5);
        }
    }
}
