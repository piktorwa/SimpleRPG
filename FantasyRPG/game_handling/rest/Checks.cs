using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyRPG.game_handling.rest
{
    internal class Checks
    {
        public static bool CheckKey4(ConsoleKeyInfo Choice)//sprawdza od 1 do 4
        {
            if (Choice.Key == ConsoleKey.NumPad1 || Choice.Key == ConsoleKey.D1 || Choice.Key == ConsoleKey.NumPad2 || Choice.Key == ConsoleKey.D2 || Choice.Key == ConsoleKey.NumPad3 || Choice.Key == ConsoleKey.D3 || Choice.Key == ConsoleKey.NumPad4 || Choice.Key == ConsoleKey.D4) return true;
            return false;
        }
        
        public static bool CheckWSAD(ConsoleKeyInfo currentMove)
        {
            if (currentMove.Key == ConsoleKey.UpArrow || currentMove.Key == ConsoleKey.W) return true;
            if (currentMove.Key == ConsoleKey.DownArrow || currentMove.Key == ConsoleKey.S) return true;
            if (currentMove.Key == ConsoleKey.LeftArrow || currentMove.Key == ConsoleKey.A) return true;
            if (currentMove.Key == ConsoleKey.RightArrow || currentMove.Key == ConsoleKey.D) return true;
            return false;
        }

        public static int ReturnKey(ConsoleKeyInfo Choice)
        {
            if (Choice.Key == ConsoleKey.NumPad1 || Choice.Key == ConsoleKey.D1) return 1;
            if (Choice.Key == ConsoleKey.NumPad2 || Choice.Key == ConsoleKey.D2) return 2;
            if (Choice.Key == ConsoleKey.NumPad3 || Choice.Key == ConsoleKey.D3) return 3;
            if (Choice.Key == ConsoleKey.NumPad4 || Choice.Key == ConsoleKey.D4) return 4;
            if (Choice.Key == ConsoleKey.NumPad5 || Choice.Key == ConsoleKey.D5) return 5;
            if (Choice.Key == ConsoleKey.NumPad6 || Choice.Key == ConsoleKey.D6) return 6;
            if (Choice.Key == ConsoleKey.NumPad7 || Choice.Key == ConsoleKey.D7) return 7;
            if (Choice.Key == ConsoleKey.NumPad8 || Choice.Key == ConsoleKey.D8) return 8;
            if (Choice.Key == ConsoleKey.NumPad9 || Choice.Key == ConsoleKey.D9) return 9;
            if (Choice.Key == ConsoleKey.NumPad0 || Choice.Key == ConsoleKey.D0) return 0;
            return -99;
        }
    }
}
