using FantasyRPG.roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyRPG.operations.levelup
{
    internal class LevelUpWarrior
    {
        public static void Execute(IRole Player, int bonus)
        {
            int tmpArmor = Player.Self.Armor;
            if (Player.Self.Name.Equals("Human")) LevelUpHuman.Execute(Player, bonus);
            if (Player.Self.Name.Equals("Dwarf")) LevelUpDwarf.Execute(Player, bonus);
            if (Player.Self.Name.Equals("Elf")) LevelUpElf.Execute(Player, bonus);
            if (Player.Self.Name.Equals("Beastman")) LevelUpBeastman.Execute(Player, bonus);
            Player.Self.Armor = tmpArmor;
            return;
        }
    }
}
