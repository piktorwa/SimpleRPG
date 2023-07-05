using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyRPG.game_handling.movement
{
    internal class Movement
    {
        public static void MakeMove(ConsoleKeyInfo currentMove)
        {
            Move moveN = new MoveNorth();
            Move moveS = new MoveSouth();
            Move moveW = new MoveWest();
            Move moveE = new MoveEast();
            if (currentMove.Key == ConsoleKey.UpArrow || currentMove.Key == ConsoleKey.W) moveN.Execute();
            if (currentMove.Key == ConsoleKey.DownArrow || currentMove.Key == ConsoleKey.S) moveS.Execute();
            if (currentMove.Key == ConsoleKey.LeftArrow || currentMove.Key == ConsoleKey.A) moveW.Execute();
            if (currentMove.Key == ConsoleKey.RightArrow || currentMove.Key == ConsoleKey.D) moveE.Execute();
        }
    }
}
