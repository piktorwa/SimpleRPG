using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyRPG.game_handling.rest
{
    internal class Statistics
    {
        public Statistics() 
        {
            _turns = 0;
            _numberOfBattles = 0;
            _numberOfStatesChanges = 0;
            _numberOfAttacks = 0;
        }
        private int _turns;
        public int Turns
        {
            get { return _turns; }
        }
        private int _numberOfBattles;
        public int numberOfBattles
        {
            get { return _numberOfBattles; }
        }
        private int _numberOfStatesChanges;
        public int NumberOfStatesChanges
        {
            get { return _numberOfStatesChanges; }
        }
        private int _numberOfAttacks;
        public int NumberOfAttacks
        {
            get { return _numberOfAttacks; }
        }
        public void IncreaseTurns()
        {
            _turns++;
        }
        public void IncreaseNoB() 
        {
            _numberOfBattles++;
        }
        public void IncreaseNoSC()
        {
            _numberOfStatesChanges++;
        }
        public void IncreaseNoA()
        {
            _numberOfAttacks++;
        }
    }
}
