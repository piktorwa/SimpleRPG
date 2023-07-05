using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyRPG
{
    class MoveEast : Move
    {
        override public void Execute()
        {
            Console.WriteLine("You moved East!");
            Console.WriteLine("[Press ENTER to continue]");
            Console.ReadKey();
        }
    }
}
