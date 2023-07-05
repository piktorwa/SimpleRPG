using FantasyRPG.roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyRPG.game_handling.menu
{
    internal class Events
    {
        public static void Execute(IRole Player)
        {
            Texts.ShowIt();
        }
        
    }
}
