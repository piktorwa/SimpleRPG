using FantasyRPG.operations.states;
using FantasyRPG.operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyRPG.roles
{
    internal class Shaman:IRole
    {
        public string Name { get; } = "Shaman";
        public Shaman(ICharacter race)
        {
            _self = race;
            _self.Armor = 11;
        }
        private ICharacter _self;
        public ICharacter Self
        {
            get { return _self; }
            set { _self = value; }
        }
        public void ChangeState(IRole defender)
        {
            //bleeding, cursing and stunning
            Random ShouldAdd = new Random();
            bool shouldAdd = true;
            if (ShouldAdd.Next(100) < 20)
            {
                for (int i = 0; i < defender.Self.MyStates.Count; i++)
                {
                    if (defender.Self.MyStates[i].Name.Equals("Cursed"))
                    {
                        int tmpTurns = defender.Self.MyStates[i].Turns;
                        tmpTurns += 2;
                        defender.Self.MyStates[i].Turns = tmpTurns;
                        shouldAdd = false;
                    }
                }
                if (shouldAdd)
                {
                    IStates NewState = new Cursed();
                    defender.Self.AddState(NewState);
                }
            }
            shouldAdd = true;
            if (ShouldAdd.Next(100) < 6)
            {
                for (int i = 0; i < defender.Self.MyStates.Count; i++)
                {
                    if (defender.Self.MyStates[i].Name.Equals("Bleeding"))
                    {
                        int tmpTurns = defender.Self.MyStates[i].Turns;
                        tmpTurns += 2;
                        defender.Self.MyStates[i].Turns = tmpTurns;
                        shouldAdd = false;
                    }
                }
                if (shouldAdd)
                {
                    IStates NewState = new Bleeding();
                    defender.Self.AddState(NewState);
                }
            }
            shouldAdd = true;
            if (ShouldAdd.Next(100) < 2)
            {
                for (int i = 0; i < defender.Self.MyStates.Count; i++)
                {
                    if (defender.Self.MyStates[i].Name.Equals("Stunned"))
                    {
                        int tmpTurns = defender.Self.MyStates[i].Turns;
                        tmpTurns += 1;
                        defender.Self.MyStates[i].Turns = tmpTurns;
                        shouldAdd = false;
                    }
                }
                if (shouldAdd)
                {
                    IStates NewState = new Stunned();
                    defender.Self.AddState(NewState);
                }
            }
        }
        public void Attack(IRole defender)
        {
            Random NoMiss = new Random();
            if (NoMiss.Next(100) < _self.Accuracy - defender.Self.Swiftness)
            {
                int defHP = defender.Self.HP;
                if (defender.Self.Armor < (int)(_self.Strength * 2.1))
                {
                    defHP = (int)(defHP - (_self.Strength * 2.1 - defender.Self.Armor));
                    defender.Self.HP = defHP;
                }

                ChangeState(defender);
            }
        }
    }
}
