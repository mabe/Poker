using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poker
{
    public abstract class HandType
    {
        public HandType(Hand hand)
        {
            var all = new List<Card>();
            all.AddRange(hand.Cards);
            all.AddRange(hand.CardsOnTable);

            Hand = hand;
            AllCards = all;
            Cards = new Card[5];
        }

        public int HighestIndexOnHand { get; set; }

        public int HighestIndexOnTable { get; set; }

        protected Hand Hand { get; set; }

        protected IEnumerable<Card> AllCards { get; private set; }

        protected Card[] Cards { get; set; }

        public bool CheckCards()
        {
            var isType = Check();



            return isType;
        }

        public abstract byte Rank { get; }

        public abstract bool Check();

        //protected void CalculateHighestIndex(IEnumerable<Card> cards)
        //{
        //    HighestIndex = (from c in cards orderby c.Index descending select c.Index).Take(1).Single();
        //}

        public static IEnumerable<HandType> Hands(Hand hand)
        {
            return (from h in new HandType[] { 
                                    new HighestIndex(hand), 
                                    new OnePair(hand), 
                                    new TwoPair(hand), 
                                    new ThreeOfAKind(hand), 
                                    new Straight(hand), 
                                    new Flush(hand),
                                    new FullHouse(hand),
                                    new FourOfAKind(hand),
                                    new StraightFlush(hand)
                                } orderby h.Rank descending select h).ToList();
        }

        public override string ToString()
        {
            return string.Concat(GetType().Name, " highest card is ", HighestIndexOnHand);
        }
    }
}
