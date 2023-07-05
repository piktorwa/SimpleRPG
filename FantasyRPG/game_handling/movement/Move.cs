using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyRPG
{
    abstract class Move
    {
        abstract public void Execute();
    }
}

/*0001 1
0010 2
0100 4
1000 8
0011 3
0110 6
1100 12
1001 9
1010 10
0101 5
1110 14
1101 13
1011 11
0111 7*/