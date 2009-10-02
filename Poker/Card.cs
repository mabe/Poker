using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poker
{
    public class Card
    {
        public Card(int index, CardType cardtype)
        {
            Index = index;
            Type = cardtype;
        }
    
        public int Index
        {
            get;
            set;
        }

        public CardType Type
        {
            get;
            set;
        }
    }
}
