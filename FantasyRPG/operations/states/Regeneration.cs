using FantasyRPG.game_handling.menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyRPG.operations.states
{
    internal class Regeneration:IStates
    {
        public string Name { get; } = "Regeneration";
        private int _turns;
        public int Turns 
        { 
            get { return _turns; }
            set { _turns = value; }
        }
        public void Execute(ICharacter target)
        {
            if(_turns >= 0)
            {
                Texts.Uregen();
                int tempHP = target.HP;
                tempHP = (int)(tempHP + target.MaxHP * 0.03);
                if (tempHP > target.MaxHP) { tempHP = target.MaxHP; }
                target.HP = tempHP;
            }
        }
    }
}
