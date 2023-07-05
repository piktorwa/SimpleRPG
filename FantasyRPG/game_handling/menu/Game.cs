using FantasyRPG.game_handling.movement;
using FantasyRPG.game_handling.rest;
using FantasyRPG.operations;
using FantasyRPG.operations.levelup;
using FantasyRPG.roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyRPG.game_handling.menu
{
    internal class Game
    {
        public static void Play()
        {
            ICharacter _race;
            IRole _player;
            ConsoleKeyInfo _choice;
            //tworzenie postaci
            do
            {
                Texts.CreatingHero();
                _choice = Console.ReadKey(true);
                _choice = Texts.ChosenRace(_choice);
                if(Checks.CheckKey4(_choice)) break;
            } while (true);
            _race = CharacterFactory.MakeCharacter(_choice);
            do
            {
                Texts.ChoosingRole();
                _choice = Console.ReadKey(true);
                _choice = Texts.ChosenRole(_choice);
                if (Checks.CheckKey4(_choice)) break;
            } while (true);
            _player = CharacterFactory.MakeRole(_choice, _race);
            Random rnd = new Random();
            int rndHolder;
            int turns = 1;
            Battle LetTheFightBegin = new Battle();
            LevelUp leveling = new LevelUp();
            do
            {
                //Texts.Ways(rndHolder);
                do
                {
                    Texts.Ways();
                    _choice = Console.ReadKey(true);
                    if (Checks.CheckWSAD(_choice)) break;
                } while (true);
                Movement.MakeMove(_choice);
                rndHolder = rnd.Next(100 + turns);

                if (rndHolder < (30 + turns)) Events.Execute(_player);
                else if (LetTheFightBegin.Execute(_player, turns)) break;
                else
                {
                    Texts.WonBattle();
                }
                leveling.Execute(_player);
                turns++;
            } while (true);//graj tak dlugo az Gracz umrze
            Texts.EndGame();
        }
    }
}
