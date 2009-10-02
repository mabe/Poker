using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poker
{
    public class TexasHoldEm : Game
    {
        public TexasHoldEm() : base()
        {
            Cards = new List<Card>();
        }

        public IList<Card> Cards { get; private set; }

        public void Begin()
        {
            Deck = new Deck();
            Cards.Clear();

            foreach (var player in (from s in Table.OccupiedSeats() select s.Player))
            {
                player.Hand = new Hand(Cards);
            }

            Deal();
        }

        public void End()
        {
            foreach (var player in (from s in Table.OccupiedSeats() select s.Player))
            {
                player.Hand.CheckHandSetType();
            }
        }

        private void Deal()
        {
            for (int i = 0; i < 2; i++)
            {
                foreach (var player in Table.OccupiedSeats().Select(x => x.Player))
                {
                    player.Hand.Cards.Add(Deck.Next());
                }
            }

            Deck.Next();

            Cards.Add(Deck.Next());
            Cards.Add(Deck.Next());
            Cards.Add(Deck.Next());

            Deck.Next();

            Cards.Add(Deck.Next());

            Deck.Next();

            Cards.Add(Deck.Next());
        }
    }
}
