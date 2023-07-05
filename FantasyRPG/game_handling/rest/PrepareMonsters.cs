using FantasyRPG.roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyRPG.game_handling.rest
{
    internal class PrepareMonsters
    {
        public static List<IRole> CreateMonsters(int Turns)
        {
            List<IRole> monsters = new List<IRole> { };
            Random random = new Random();
            int NumberOfMonsters = random.Next(3) + 1;
            int WhatMonster;
            for(int i = 0; i < NumberOfMonsters; i++)
            {
                WhatMonster = random.Next(10000);
                if (WhatMonster < 10000 - Turns * 10) monsters.Add(CharacterFactory.MakeRole(CharacterFactory.MakeMonster(1, Turns)));
                else if (WhatMonster < 10000 - Turns * 7) monsters.Add(CharacterFactory.MakeRole(CharacterFactory.MakeMonster(2, Turns)));
                else if (WhatMonster < 10000 - Turns * 5) monsters.Add(CharacterFactory.MakeRole(CharacterFactory.MakeMonster(3, Turns)));
                else if (WhatMonster < 10000 - Turns * 4) monsters.Add(CharacterFactory.MakeRole(CharacterFactory.MakeMonster(4, Turns)));
                else if (WhatMonster < 10000 - Turns * 3) monsters.Add(CharacterFactory.MakeRole(CharacterFactory.MakeMonster(5, Turns)));
            }
            return monsters;
        }
    }
}
