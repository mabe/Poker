﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poker
{
    public class ThreeOfAKind : HandType
    {
        public override byte Rank
        {
            get { return 3; }
        }

        public override bool Check(IEnumerable<Card> cards)
        {
            throw new NotImplementedException();
        }
    }
}