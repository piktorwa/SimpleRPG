using FantasyRPG.game_handling.menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyRPG.operations.states
{
    internal class Cursed : IStates
    {
        public string Name { get; } = "Cursed";
        public Cursed() 
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
        public void Execute(ICharacter target)
        {
            //decrease in swiftness and accuracy

            if (_turns > 0) _turns--;
            if (_turns > 0 && _shouldDecreaseStats)
            {
                Texts.Ucursed();
                int tempSwiftness = target.Swiftness;
                tempSwiftness -= 10;
                target.Swiftness = tempSwiftness;
               
                int tempAccuracy = target.Accuracy;
                tempAccuracy -= 10;
                target.Accuracy = tempAccuracy;

                _shouldDecreaseStats = false;
                _shouldIncreaseStats = true;
            }

            if(_turns == 0 && _shouldIncreaseStats)
            {
                int tempSwiftness = target.Swiftness;
                tempSwiftness = tempSwiftness + 10;
                target.Swiftness = tempSwiftness;

                int tempAccuracy = target.Accuracy;
                tempAccuracy = tempAccuracy + 10;
                target.Accuracy = tempAccuracy;

                _shouldDecreaseStats = true;
                _shouldIncreaseStats = false;
            }
        }
    }
}
