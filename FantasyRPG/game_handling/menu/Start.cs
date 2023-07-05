using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyRPG
{
    //menu startowe
    //rozpoczecie tworzenia postaci
    class Start
    {
        public static void Begin()
        {
            Console.WriteLine("Welcome to FantasyRPG!");
            Console.WriteLine("Let's begin your journey by creating Hero.");
            Console.WriteLine("You are moving by using WSAD or arrows, during fights You will be using only numbers.");
            Console.WriteLine("[Press ENTER to continue.]");
            Console.ReadLine();
        }
    }
}
