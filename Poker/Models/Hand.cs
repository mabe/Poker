using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poker
{
    public class Hand
    {
        public Hand(IEnumerable<Card> cardsOnTable)
        {
            Cards = new List<Card>();
            CardsOnTable = cardsOnTable;
        }

        public IList<Card> Cards
        {
            get;
            private set;
        }

        public IEnumerable<Card> CardsOnTable
        {
            get;
            set;
        }

        public HandType HandType
        {
            get;
            private set;
        }

        public void CheckHandSetType()
        {
            foreach (var handtype in HandType.Hands(Cards, CardsOnTable))
            {
                if (handtype.Check())
                {
                    HandType = handtype;
                    break;
                }
            }
        }
    }
}
