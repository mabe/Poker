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
        }

        protected Deck Deck { get; set; }
    }
}
