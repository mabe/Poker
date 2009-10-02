using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poker
{
    public abstract class HandType
    {
        public HandType(IEnumerable<Card> cards, IEnumerable<Card> cardsOnHand)
        {
            var all = new List<Card>();

            all.AddRange(cards);
            all.AddRange(cardsOnHand);

            AllCards = all;
        }

        public abstract byte Rank
        {
            get;
        }

        public int HighestIndexOnHand
        {
            get;
            set;
        }

        public int HighestIndexOnTable { get; set; }

        protected IEnumerable<Card> AllCards { get; private set; }

        public virtual bool Check()
        {
            return true;
        }

        //protected void CalculateHighestIndex(IEnumerable<Card> cards)
        //{
        //    HighestIndex = (from c in cards orderby c.Index descending select c.Index).Take(1).Single();
        //}

        public static IEnumerable<HandType> Hands(IEnumerable<Card> cards, IEnumerable<Card> cardsOnTable)
        {
            return (from h in new HandType[] { 
                                    new HighestIndex(cards, cardsOnTable), 
                                    new OnePair(cards, cardsOnTable), 
                                    new TwoPair(cards, cardsOnTable), 
                                    new ThreeOfAKind(cards, cardsOnTable), 
                                    new Straight(cards, cardsOnTable), 
                                    new Flush(cards, cardsOnTable),
                                    new FullHouse(cards, cardsOnTable)
                                } orderby h.Rank descending select h).ToList();
        }

        public override string ToString()
        {
            return string.Concat(GetType().Name, " highest card is ", HighestIndexOnHand);
        }
    }
}
