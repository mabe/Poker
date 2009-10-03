using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poker
{
    public class StraightFlush : HandType
    {
        public StraightFlush(Hand hand) : base(hand) { }

        public override byte Rank
        {
            get { return 8; }
        }

        public override bool Check()
        {
            var flush = (from c in AllCards group c by c.Type into type where type.Count() >= 5 select type).SingleOrDefault();

            if (flush == null)
                return false;

            var indexs = (from c in flush group c by c.Index into index orderby index.Key select index.Key);

            int i = indexs.First(), straight = 0;

            foreach (var index in indexs)
            {
                if (i != index)
                {
                    if (straight >= 5)
                        break;

                    i = index;
                    straight = 0;
                }

                straight++;
                i++;
            }

            return (straight >= 5);
        }
    }
}
