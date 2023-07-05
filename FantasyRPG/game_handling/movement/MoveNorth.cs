using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyRPG
{
    class MoveNorth : Move
    {
        override public void Execute()
        {
            Console.WriteLine("You moved North!");
            Console.WriteLine("[Press ENTER to continue]");
            Console.ReadKey();
        }
    }
}
