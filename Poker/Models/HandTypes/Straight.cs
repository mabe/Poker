using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poker
{
    public class Straight : HandType
    {
        public Straight(Hand hand) : base(hand) { }

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
