using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poker
{
    public abstract class Game
    {
        public Game()
        {
            Deck = new Deck();
            Deck.Shuffle();

            Players = new Dictionary<int, Player>();
        }

        public abstract void Deal();

        public IDictionary<int, Player> Players
        {
            get;
            private set;
        }

        public Deck Deck
        {
            get;
            private set;
        }
    }
}
