using FantasyRPG.roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyRPG.operations.levelup
{
    internal class LevelUpBeastman
    {
        public static void Execute(IRole Player, int bonus)
        {
            int tmpStrength = Player.Self.Strength;
            int tmpEndurance = Player.Self.Endurance;
            int tmpSwiftness = Player.Self.Swiftness;
            int tmpAccuracy = Player.Self.Accuracy;
            int tmpMaxHP = Player.Self.MaxHP;
            tmpStrength += 3 + bonus;
            tmpEndurance += 1 + bonus;
            tmpSwiftness += 5 + bonus;
            tmpAccuracy += 4 + bonus;
            tmpMaxHP = tmpEndurance * 55;
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
