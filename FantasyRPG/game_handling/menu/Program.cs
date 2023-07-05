//Program was made by: Wiktor Pantak
//  Kraków, 04.06.2023
//It contains simple RPG game.
//
//
//

using FantasyRPG.game_handling.menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyRPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Start.Begin();
            Game.Play();
        }
    }
}
