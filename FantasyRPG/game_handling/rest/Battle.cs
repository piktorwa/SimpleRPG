using FantasyRPG.game_handling.menu;
using FantasyRPG.game_handling.rest;
using FantasyRPG.operations;
using FantasyRPG.roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FantasyRPG.game_handling
{
    internal class Battle
    {
        public bool Execute(IRole Player, int Turns)
        {
            Console.Clear();
            LevelUp leveling = new LevelUp();
            List<IRole> monsters = PrepareMonsters.CreateMonsters(Turns);
            int monsterCount = monsters.Count;
            if (monsterCount>1) Console.WriteLine("\nYou have encountered monsters!");
            else Console.WriteLine("\nYou have encountered monster!");
            int killCount = 0;
            int choice = -1;
            switch (monsterCount)
            {
                case 1:
                    do
                    {
                        for (int i = 0; i < monsterCount; i++)
                        {
                            if (monsters[i].Self.HP <= 0) killCount++;
                            if (killCount == monsterCount) return false;
                        }
                        killCount = 0;
                        Console.WriteLine($"{Player.Name} {Player.Self.Name}");
                        Console.WriteLine($"{Player.Self.HP}/{Player.Self.MaxHP}HP\n");
                        for(int i = 0; i < monsterCount; i++)
                        {
                            Console.WriteLine($"{i+1}.{monsters[i].Name} {monsters[i].Self.Name}");
                            Console.WriteLine($"{monsters[i].Self.HP}/{monsters[i].Self.MaxHP}HP");
                        }
                        while (choice<0 || choice>monsterCount - 1)
                        {
                            Texts.WhichMonster();
                            choice = Checks.ReturnKey(Console.ReadKey(true)) - 1;
                        }
                        if (monsters[choice].Self.HP <= 0)
                        {
                            choice = -1;
                            continue;
                        }
                        Player.Attack(monsters[choice]);
                        if (monsters[choice].Self.HP <= 0) 
                        {
                            int tmpExp = Player.Self.Experience;
                            tmpExp += monsters[choice].Self.Experience;
                            Player.Self.Experience = tmpExp;
                        }
                        choice = -1;
                        for (int i = 0; i < monsterCount; i++)
                        {
                            if (monsters[i].Self.HP <= 0) continue;
                            monsters[i].Attack(Player);
                        }
                        for (int i = 0; i < Player.Self.MyStates.Count(); i++)
                        {
                            if (Player.Self.MyStates[i].Name.Equals("Stunned")) continue;
                            Player.Self.MyStates[i].Execute(Player.Self);
                        }
                        for(int i = 0; i < monsterCount; i++)
                        {
                            for(int j = 0; j < monsters[i].Self.MyStates.Count(); j++)
                            {
                                if (monsters[i].Self.HP <= 0) continue;
                                if (monsters[i].Self.MyStates[j].Name.Equals("Stunned")) continue;
                                monsters[i].Self.MyStates[j].Execute(monsters[i].Self);
                            }
                        }
                        if (Player.Self.HP <= 0) return true;
                        leveling.Execute(Player);
                        Console.Clear();
                    } while (true);

                case 2:
                    do
                    {
                        for (int i = 0; i < monsterCount; i++)
                        {
                            if (monsters[i].Self.HP <= 0) killCount++;
                            if (killCount == monsterCount) return false;
                        }
                        killCount = 0;
                        Console.WriteLine($"{Player.Name} {Player.Self.Name}");
                        Console.WriteLine($"{Player.Self.HP}/{Player.Self.MaxHP}HP");
                        for (int i = 0; i < monsterCount; i++)
                        {
                            Console.WriteLine($"{i + 1}.{monsters[i].Name} {monsters[i].Self.Name}");
                            Console.WriteLine($"{monsters[i].Self.HP}/{monsters[i].Self.MaxHP}HP");
                        } 
                        while (choice < 0 || choice > monsterCount - 1)
                        {
                            Texts.WhichMonster();
                            choice = Checks.ReturnKey(Console.ReadKey(true)) - 1;
                        }
                        if (monsters[choice].Self.HP <= 0)
                        {
                            choice = -1;
                            continue;
                        }
                        Player.Attack(monsters[choice]);
                        if (monsters[choice].Self.HP <= 0)
                        {
                            int tmpExp = Player.Self.Experience;
                            tmpExp += monsters[choice].Self.Experience;
                            Player.Self.Experience = tmpExp;
                        }
                        choice = -1;
                        for (int i = 0; i < monsterCount; i++)
                        {
                            if (monsters[i].Self.HP <= 0) continue;
                            monsters[i].Attack(Player);
                        }
                        for (int i = 0; i < Player.Self.MyStates.Count(); i++)
                        {
                            if (Player.Self.MyStates[i].Name.Equals("Stunned")) continue;
                            Player.Self.MyStates[i].Execute(Player.Self);
                        }
                        for (int i = 0; i < monsterCount; i++)
                        {
                            for (int j = 0; j < monsters[i].Self.MyStates.Count(); j++)
                            {
                                if (monsters[i].Self.HP <= 0) continue;
                                if (monsters[i].Self.MyStates[j].Name.Equals("Stunned")) continue;
                                monsters[i].Self.MyStates[j].Execute(monsters[i].Self);
                            }
                        }
                        if (Player.Self.HP <= 0) return true;
                        leveling.Execute(Player);
                        Console.Clear();
                    } while (true);

                case 3:
                    do
                    {
                        for (int i = 0; i < monsterCount; i++)
                        {
                            if (monsters[i].Self.HP <= 0) killCount++;
                            if (killCount == monsterCount) return false;
                        }
                        killCount = 0;
                        Console.WriteLine($"{Player.Name} {Player.Self.Name}");
                        Console.WriteLine($"{Player.Self.HP}/{Player.Self.MaxHP}HP");
                        for (int i = 0; i < monsterCount; i++)
                        {
                            Console.WriteLine($"{i + 1}.{monsters[i].Name} {monsters[i].Self.Name}");
                            Console.WriteLine($"{monsters[i].Self.HP}/{monsters[i].Self.MaxHP}HP");
                        }
                        while (choice < 0 || choice > monsterCount - 1)
                        {
                            Texts.WhichMonster();
                            choice = Checks.ReturnKey(Console.ReadKey(true)) - 1;
                        }
                        if (monsters[choice].Self.HP <= 0)
                        {
                            choice = -1;
                            continue;
                        }
                        Player.Attack(monsters[choice]);
                        if (monsters[choice].Self.HP <= 0)
                        {
                            int tmpExp = Player.Self.Experience;
                            tmpExp += monsters[choice].Self.Experience;
                            Player.Self.Experience = tmpExp;
                        }
                        choice = -1;
                        for (int i = 0; i < monsterCount; i++)
                        {
                            if (monsters[i].Self.HP <= 0) continue;
                            monsters[i].Attack(Player);
                        }
                        for (int i = 0; i < Player.Self.MyStates.Count(); i++)
                        {
                            if (Player.Self.MyStates[i].Name.Equals("Stunned")) continue;
                            Player.Self.MyStates[i].Execute(Player.Self);
                        }
                        for (int i = 0; i < monsterCount; i++)
                        {
                            for (int j = 0; j < monsters[i].Self.MyStates.Count(); j++)
                            {
                                if (monsters[i].Self.HP <= 0) continue;
                                if (monsters[i].Self.MyStates[j].Name.Equals("Stunned")) continue;
                                monsters[i].Self.MyStates[j].Execute(monsters[i].Self);
                            }
                        }
                        if (Player.Self.HP <= 0) return true;
                        leveling.Execute(Player);
                        Console.Clear();
                    } while (true);
                default:
                    //jak tu sie dostales?
                    return false;
            }
        }
    }
}
