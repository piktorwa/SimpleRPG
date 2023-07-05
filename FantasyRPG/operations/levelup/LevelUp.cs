using FantasyRPG.game_handling.menu;
using FantasyRPG.operations.levelup;
using FantasyRPG.roles;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyRPG.operations
{
    internal class LevelUp : ILevelUp
    {
        public void Execute(IRole Player)
        {
            int tmpLevel = Player.Self.Level;
            int tmpExp = Player.Self.Experience;
            bool enter = false;
            while(tmpLevel * 70 < tmpExp){
                tmpExp = tmpExp - tmpLevel * 70;
                tmpLevel++;
                int bonus = 7;
                if (tmpLevel % 10 == 0)
                {
                    if (Player.Name.Equals("Warrior")) LevelUpWarrior.Execute(Player, bonus);
                    if (Player.Name.Equals("Rouge")) LevelUpRouge.Execute(Player, bonus);
                    if (Player.Name.Equals("Paladin")) LevelUpPaladin.Execute(Player, bonus);
                    if (Player.Name.Equals("Shaman")) LevelUpShaman.Execute(Player, bonus);
                }
                if (tmpLevel % 5 == 0)
                {
                    bonus = 4;
                    if (Player.Name.Equals("Warrior")) LevelUpWarrior.Execute(Player, bonus);
                    if (Player.Name.Equals("Rouge")) LevelUpRouge.Execute(Player, bonus);
                    if (Player.Name.Equals("Paladin")) LevelUpPaladin.Execute(Player, bonus);
                    if (Player.Name.Equals("Shaman")) LevelUpShaman.Execute(Player, bonus);
                }
                bonus = 0;
                if (Player.Name.Equals("Warrior")) LevelUpWarrior.Execute(Player, bonus);
                if (Player.Name.Equals("Rouge")) LevelUpRouge.Execute(Player, bonus);
                if (Player.Name.Equals("Paladin")) LevelUpPaladin.Execute(Player, bonus);
                if (Player.Name.Equals("Shaman")) LevelUpShaman.Execute(Player, bonus);
                Texts.LevelUpText();
                enter = true;
            }
            if (enter)
            {
                Texts.PressEnter();
            }
            Player.Self.Level = tmpLevel;
            Player.Self.Experience = tmpExp;
            return;
        }
    }
}
