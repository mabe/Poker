using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Poker.Models;

namespace Poker
{
    public abstract class Game
    {
        public Game()
        {
            Table = new Table(8);
        }

        protected Deck Deck { get; set; }

        protected Table Table { get; set; }

        public void PlayerJoins(string name)
        {
            Table.PlayerJoins(new Player(name), (byte)(Table.OccupiedSeats().Count() + 1));
        }

        public IEnumerable<Player> Players()
        {
            return Table.OccupiedSeats().Select(x => x.Player);
        }


    }
}
