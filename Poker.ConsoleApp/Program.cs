using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poker.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Game Begin");

            bool run = true;

            var game = new TexasHoldEm();
            game.PlayerJoins("Magnus");
            game.PlayerJoins("Per");

            while (run)
            {
                game.Begin();

                foreach (var player in game.Players())
                {
                    Console.WriteLine("Name: {0} Card1: {1} Card2: {2}", player.Name, player.Hand.Cards[0], player.Hand.Cards[1]);
                }

                foreach (var card in game.Cards)
                {
                    Console.WriteLine("Card: {0}", card);
                }

                Console.WriteLine();

                game.End();

                foreach (var player in game.Players())
                {
                    Console.WriteLine(string.Concat(player.Name, " ", player.Hand.HandType));
                }


                if (Console.ReadLine() == "exit")
                    run = false;
            }

        }
    }
}
