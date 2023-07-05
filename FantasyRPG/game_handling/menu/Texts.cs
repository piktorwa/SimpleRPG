using FantasyRPG.characters.races;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyRPG.game_handling.menu
{
    public class Texts
    {
        public static void ShowIt()
        {
            //Console.Clear();
            Console.WriteLine("[Text holder/Not implemented]\n[Press ENTER to continue]");
            Console.ReadKey();
        }
        public static void CreatingHero()
        {
            Console.Clear();
            Console.WriteLine("You can choose 1 form the following races:");
            Console.WriteLine("1. Human");
            Console.WriteLine("2. Dwarf (Specilize in Endurance)");
            Console.WriteLine("3. Elf (Specilizie in Accuracy)");
            Console.WriteLine("4. Beastman (Specializie in Swiftness)");
        }
        public static void ChoosingRole()
        {
            Console.Clear();
            Console.WriteLine("You can choose 1 form the following classes:");
            Console.WriteLine("1. Warrior");
            Console.WriteLine("2. Rouge");
            Console.WriteLine("3. Palladin");
            Console.WriteLine("4. Shaman");
        }
        public static ConsoleKeyInfo ChosenRace(ConsoleKeyInfo Choice)
        {
            ConsoleKeyInfo _check;
            if (Choice.Key== ConsoleKey.NumPad1 || Choice.Key == ConsoleKey.D1)
            {
                Console.WriteLine("You have chosen: Human");
                Console.WriteLine("You won't be able to change it later, do you wish to continue? (y/n)");
                do
                {
                    _check = Console.ReadKey(true);
                    if (_check.Key == ConsoleKey.N)
                    {
                        return _check;
                    }
                    if (_check.Key == ConsoleKey.Y)
                    {
                        return Choice;
                    }
                } while (true);
            }
            if (Choice.Key == ConsoleKey.NumPad2 || Choice.Key == ConsoleKey.D2)
            {
                Console.WriteLine("You have chosen: Dwarf");
                Console.WriteLine("You won't be able to change it later, do you wish to continue? (y/n)");
                do
                {
                    _check = Console.ReadKey(true);
                    if (_check.Key == ConsoleKey.N)
                    {
                        return _check;
                    }
                    if (_check.Key == ConsoleKey.Y)
                    {
                        return Choice;
                    }
                } while (true);
            }
            if (Choice.Key == ConsoleKey.NumPad3 || Choice.Key == ConsoleKey.D3)
            {
                Console.WriteLine("You have chosen: Elf");
                Console.WriteLine("You won't be able to change it later, do you wish to continue? (y/n)");
                do
                {
                    _check = Console.ReadKey(true);
                    if (_check.Key == ConsoleKey.N)
                    {
                        return _check;
                    }
                    if (_check.Key == ConsoleKey.Y) 
                    {
                        return Choice;
                    }    
                } while (true);            
            }
            if (Choice.Key == ConsoleKey.NumPad4 || Choice.Key == ConsoleKey.D4)
            {
                Console.WriteLine("You have chosen: Beastman");
                Console.WriteLine("You won't be able to change it later, do you wish to continue? (y/n)");
                do
                {
                    _check = Console.ReadKey(true);
                    if (_check.Key == ConsoleKey.N)
                    {
                        return _check;
                    }
                    if (_check.Key == ConsoleKey.Y)
                    {
                        return Choice;
                    }
                } while (true);
            }
            return Choice;   
        }
        public static ConsoleKeyInfo ChosenRole(ConsoleKeyInfo Choice)
        {
            ConsoleKeyInfo _check;
            if (Choice.Key == ConsoleKey.NumPad1 || Choice.Key == ConsoleKey.D1)
            {
                Console.WriteLine("You have chosen: Warrior");
                Console.WriteLine("You won't be able to change it later, do you wish to continue? (y/n)");
                do
                {
                    _check = Console.ReadKey(true);
                    if (_check.Key == ConsoleKey.N)
                    {
                        return _check;
                    }
                    if (_check.Key == ConsoleKey.Y)
                    {
                        return Choice;
                    }
                } while (true);
            }
            if (Choice.Key == ConsoleKey.NumPad2 || Choice.Key == ConsoleKey.D2)
            {
                Console.WriteLine("You have chosen: Rouge");
                Console.WriteLine("You won't be able to change it later, do you wish to continue? (y/n)");
                do
                {
                    _check = Console.ReadKey(true);
                    if (_check.Key == ConsoleKey.N)
                    {
                        return _check;
                    }
                    if (_check.Key == ConsoleKey.Y)
                    {
                        return Choice;
                    }
                } while (true);
            }
            if (Choice.Key == ConsoleKey.NumPad3 || Choice.Key == ConsoleKey.D3)
            {
                Console.WriteLine("You have chosen: Palladin");
                Console.WriteLine("You won't be able to change it later, do you wish to continue? (y/n)");
                do
                {
                    _check = Console.ReadKey(true);
                    if (_check.Key == ConsoleKey.N)
                    {
                        return _check;
                    }
                    if (_check.Key == ConsoleKey.Y)
                    {
                        return Choice;
                    }
                } while (true);
            }
            if (Choice.Key == ConsoleKey.NumPad4 || Choice.Key == ConsoleKey.D4)
            {
                Console.WriteLine("You have chosen: Shaman");
                Console.WriteLine("You won't be able to change it later, do you wish to continue? (y/n)");
                do
                {
                    _check = Console.ReadKey(true);
                    if (_check.Key == ConsoleKey.N)
                    {
                        return _check;
                    }
                    if (_check.Key == ConsoleKey.Y)
                    {
                        return Choice;
                    }
                } while (true);
            }
            return Choice;
        }
        public static void Ways()
        {
            Console.Clear();
            Console.WriteLine($"Where do you want to go?");
        }
        public static void WonBattle()
        {
            Console.Clear();
            Console.WriteLine("You have won the battle!");
            Console.WriteLine("[Press ENTER to continue]");
            Console.ReadKey();
        }
        public static void LevelUpText()
        {
            Console.WriteLine("You have leveled up!");            
        }
        public static void EndGame()
        {
            Console.Clear();
            Console.WriteLine("This the end! Good luck next time hero!");
            Console.WriteLine("[Press ENTER to continue]");
            Console.ReadKey();
        }
        public static void WhichMonster()
        {
            Console.WriteLine("\nWhich monster do you want to attack?");
        }
        public static void Ubleeding() 
        {
            Console.WriteLine("You are bleeding!");
            Console.WriteLine("Press ENTER to continue.");
            Console.ReadKey();
        }
        public static void Upoisoned() 
        {
            Console.WriteLine("You are poisoned!");
            Console.WriteLine("Press ENTER to continue.");
            Console.ReadKey();
        }
        public static void Ustunned() 
        {
            Console.WriteLine("You are stunned!");
            Console.WriteLine("Press ENTER to continue.");
            Console.ReadKey();
        }
        public static void Ucursed() 
        {
            Console.WriteLine("You are cursed!");
            Console.WriteLine("Press ENTER to continue.");
            Console.ReadKey();
        }
        public static void Uregen() 
        {
            Console.WriteLine("You are regenerating!");
            Console.WriteLine("Press ENTER to continue.");
            Console.ReadKey();
        }
        public static void PressEnter()
        {
            Console.WriteLine("[Press ENTER to continue]");
            Console.ReadKey();
        }
    }
}
