using FantasyRPG.game_handling.menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyRPG.operations
{
    internal class Poisoned : IStates
    {
        public string Name { get; } = "Poisoned";
        public Poisoned()
        {
            _turns = 3;
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
            //decrease in accuracy
            _shouldDecreaseStats = false;
            int tempAccuracy = target.Accuracy;
            tempAccuracy -= 10;
            target.Accuracy = tempAccuracy;
        }
        public void Execute(ICharacter target)
        {
            //lose HP for 2 turns, decrease in  accuracy
            if (_turns > 0)
            {
                _turns--;
                if (_shouldDecreaseStats) FirstExecute(target);
                Texts.Upoisoned();
                int tempHP = target.HP;
                tempHP = (int)(tempHP - tempHP * 0.04);
                target.HP = tempHP;
                _shouldIncreaseStats = true;
            }
            else if(_shouldIncreaseStats)
            {
                _shouldIncreaseStats = false;
                _shouldDecreaseStats = true;
                int tempAccuracy = target.Accuracy;
                tempAccuracy += 10;
                target.Accuracy = tempAccuracy;
            }
        }
    }
}
