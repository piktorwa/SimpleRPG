using FantasyRPG.game_handling.menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyRPG.operations
{
    internal class Bleeding : IStates
    {
        public string Name { get; } = "Bleeding";
        public Bleeding() 
        {
            _turns = 2;
            _shouldDecreaseStats = true;
            _shouldIncreaseStats = true;
        }
        private int _turns;
        public int Turns
        {
            get { return _turns; }
            set { _turns = value; }
        }
        private bool _shouldDecreaseStats;
        private bool _shouldIncreaseStats;
        public void FirstExecute(ICharacter target)
        {
            //decrease in swiftness
            _shouldDecreaseStats = false;
            int tempSwiftness = target.Swiftness;
            tempSwiftness -= 20;
            target.Swiftness = tempSwiftness;
        }
        public void Execute(ICharacter target)
        {
            //lose HP for 3 turns, decrease in swiftness
            if (_turns > 0)
            {
                _turns--;
                if (_shouldDecreaseStats) FirstExecute(target);
                Texts.Ubleeding();
                int tempHP = target.HP;
                tempHP = (int)(tempHP - tempHP * 0.05);
                target.HP = tempHP;
                _shouldIncreaseStats = true;
            }
            else if (_shouldIncreaseStats)
            {
                _shouldDecreaseStats = true;
                _shouldIncreaseStats = false;
                int tempSwiftness = target.Swiftness;
                tempSwiftness += 20;
                target.Swiftness = tempSwiftness;
            }
        }
    }
}
