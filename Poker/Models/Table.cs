using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poker.Models
{
    public class Table
    {
        public Table(byte numberOfSeats)
        {
            Seats = new Dictionary<byte, Seat>();

            for (byte b = 1; b <= numberOfSeats; b++)
            {
                Seats.Add(b, new Seat(b));
            }
        }

        public IEnumerable<Seat> OccupiedSeats()
        {
            return (from s in Seats.Values where s.Player != null select s);
        }

        public void PlayerJoins(Player player, byte seat)
        {
            if (seat > Seats.Count || seat < 1)
                throw new ArgumentException("seat");

            if (Seats[seat].Player != null)
                throw new ArgumentException("Seat occupied");

            Seats[seat].Player = player;
        }

        public IDictionary<byte, Seat> Seats
        {
            get;
            set;
        }
    }
}
