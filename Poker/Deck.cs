using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poker
{
    public class Deck : IEnumerable<Card>
    {
        //Maby make a Queue<Card>

        public Deck()
        {
            Dealt = 0;
            Cards = new List<Card>();

            foreach (CardType type in Enum.GetValues(typeof(CardType)))
            {
                for (int i = 1; i <= 13; i++)
                {
                    Cards.Add(new Card(i, type));
                }
            } 
        }

        protected IList<Card> Cards
        {
            get;
            set;
        }

        public byte Dealt { get; set; }

        public Card Next()
        {
            var card = Cards[Dealt];
            Dealt++;

            return card;
        }

        public void Shuffle()
        {
            Random rng = new Random();       
            int n = Cards.Count;            
            while (n > 1)
            {
                n--;                        
                int k = rng.Next(n + 1);  
                var tmp = Cards[k];
                Cards[k] = Cards[n];
                Cards[n] = tmp;
            }


            //int n = [someMutableArray count];
            //while (n > 1) {
            //    int rnd = arc4random() % n;
            //    int i = n - 1;
            //    [someMutableArray exchangeObjectAtIndex:i withObjectAtIndex:rnd];
            //    n--;
            //}

        }

        #region IEnumerable<Card> Members

        public IEnumerator<Card> GetEnumerator()
        {
            return Cards.GetEnumerator();
        }

        #endregion

        #region IEnumerable Members

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #endregion
    }
}
