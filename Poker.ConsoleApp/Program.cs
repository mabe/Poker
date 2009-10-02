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
                
            var game = new TexasHoldEm();

            Console.Read();
        }
    }
}
