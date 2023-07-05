using FantasyRPG.roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyRPG.operations.levelup
{
    internal class LevelUpDwarf
    {
        public static void Execute(IRole Player, int bonus)
        {
            int tmpStrength = Player.Self.Strength;
            int tmpEndurance = Player.Self.Endurance;
            int tmpSwiftness = Player.Self.Swiftness;
            int tmpAccuracy = Player.Self.Accuracy;
            int tmpMaxHP = Player.Self.MaxHP;
            tmpStrength += 4 + bonus;
            tmpEndurance += 4 + bonus;
            tmpSwiftness += 1 + bonus;
            tmpAccuracy += 2 + bonus;
            tmpMaxHP = tmpEndurance * 65;
            Player.Self.Strength = tmpStrength;
            Player.Self.Endurance = tmpEndurance;
            Player.Self.Swiftness = tmpSwiftness;
            Player.Self.Accuracy = tmpAccuracy;
            Player.Self.MaxHP = tmpMaxHP;
            Player.Self.HP = tmpMaxHP;
            return;
        }
    }
}
