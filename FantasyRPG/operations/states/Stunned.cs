using FantasyRPG.game_handling.menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyRPG.operations
{
    internal class Stunned : IStates
    {
        public string Name { get; } = "Stunned";
        public Stunned() 
        {
            _turns = 1;
        }
        private int _turns;
        public int Turns
        {
            get { return _turns; }
            set { _turns = value; }
        }
        public void Execute(ICharacter target)
        {
            if(_turns > 0)
            {
                _turns--;
                Texts.Ustunned();
                //you lose 1 turn during battle
            }
        }
    }
}
