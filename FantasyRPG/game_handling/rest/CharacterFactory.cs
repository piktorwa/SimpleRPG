using FantasyRPG.characters;
using FantasyRPG.characters.monsters;
using FantasyRPG.characters.races;
using FantasyRPG.roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyRPG
{
    //fabryka postaci
    internal class CharacterFactory
    {
        public static ICharacter MakeCharacter(ConsoleKeyInfo Choice)
        {
            if (Choice.Key == ConsoleKey.NumPad1 || Choice.Key == ConsoleKey.D1)
            {
                ICharacter _human = new Human();
                return _human;
            }
            if (Choice.Key == ConsoleKey.NumPad2 || Choice.Key == ConsoleKey.D2)
            {
                ICharacter _dwarf = new Dwarf();
                return _dwarf;
            }
            if (Choice.Key == ConsoleKey.NumPad3 || Choice.Key == ConsoleKey.D3)
            {
                ICharacter _elf = new Elf();
                return _elf;
            }
            if (Choice.Key == ConsoleKey.NumPad4 || Choice.Key == ConsoleKey.D4)
            {
                ICharacter _beastman = new Beastman();
                return _beastman;
            }
            Console.WriteLine("There's no such option. Choose your race again.");
            Console.WriteLine("[Press ENTER to continue]");
            Console.ReadKey();
            return null;
        }
        public static ICharacter MakeMonster(int Choice, int Turn)
        {
            switch (Choice)
            {
                case 1://return goblin
                    ICharacter _goblin = new Goblin(Turn);
                    return _goblin;
                case 2://return goblin
                    ICharacter _hobgoblin = new Hobgoblin(Turn);
                    return _hobgoblin;
                case 3://return goblin
                    ICharacter _orc = new Orc(Turn);
                    return _orc;
                case 4://return goblin
                    ICharacter _Troll = new Troll(Turn);
                    return _Troll;
                case 5://return goblin
                    ICharacter _demonLord = new DemonLord(Turn);
                    return _demonLord;
                default:
                    return null;
            }
        }
        public static IRole MakeRole(ConsoleKeyInfo Choice, ICharacter race)
        {
            if (Choice.Key == ConsoleKey.NumPad1 || Choice.Key == ConsoleKey.D1)
            {
                IRole _warrior = new Warrior(race);
                return _warrior;
            }
            if (Choice.Key == ConsoleKey.NumPad2 || Choice.Key == ConsoleKey.D2)
            {
                IRole _rouge = new Rouge(race);
                return _rouge;
            }
            if (Choice.Key == ConsoleKey.NumPad3 || Choice.Key == ConsoleKey.D3)
            {
                IRole _paladin = new Paladin(race);
                return _paladin;
            }
            if (Choice.Key == ConsoleKey.NumPad4 || Choice.Key == ConsoleKey.D4)
            {
                IRole _shaman = new Shaman(race);
                return _shaman;
            }
            Console.WriteLine("There's no such option. Choose your race again.");
            Console.WriteLine("[Press ENTER to continue]");
            Console.ReadKey();
            return null;
        }
        public static IRole MakeRole(ICharacter race)
        {
            IRole _monster = new Monster(race);
            return _monster;
        }
    }
}
