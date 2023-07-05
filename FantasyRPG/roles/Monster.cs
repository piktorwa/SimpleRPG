using FantasyRPG.operations;
using FantasyRPG.operations.states;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyRPG.roles
{
    internal class Monster:IRole
    {
        public string Name { get; } = "Monster";
        public Monster(ICharacter race)
        {
            _self = race;
        }
        private ICharacter _self;
        public ICharacter Self
        {
            get { return _self; }
            set { _self = value; }
        }
        public void ChangeState(IRole defender)
        {
            Random ShouldAdd = new Random();
            bool shouldAdd = true;
            if (_self.Name.Equals("Goblin")&&(ShouldAdd.Next(100)<10))
            { 
                for (int i = 0; i < defender.Self.MyStates.Count; i++)
                {
                    if (defender.Self.MyStates[i].Name.Equals("Poisoned"))
                    {
                        int tmpTurns = defender.Self.MyStates[i].Turns;
                        tmpTurns += 2;
                        defender.Self.MyStates[i].Turns = tmpTurns;
                        shouldAdd = false;
                    }
                }
                if (shouldAdd)
                {
                    IStates NewState = new Poisoned();
                    defender.Self.AddState(NewState);
                }
            }
            if (_self.Name.Equals("Hobgoblin") && (ShouldAdd.Next(100) < 15))
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
            if (_self.Name.Equals("Orc"))
            {
                if(ShouldAdd.Next(100) < 30)
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
            if (_self.Name.Equals("Troll"))
            {
                if (ShouldAdd.Next(100) < 20)
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
                if (ShouldAdd.Next(100) < 10)
                {
                    for (int i = 0; i < defender.Self.MyStates.Count; i++)
                    {
                        if (defender.Self.MyStates[i].Name.Equals("Poisoned"))
                        {
                            int tmpTurns = defender.Self.MyStates[i].Turns;
                            tmpTurns += 2;
                            defender.Self.MyStates[i].Turns = tmpTurns;
                            shouldAdd = false;
                        }
                    }
                    if (shouldAdd)
                    {
                        IStates NewState = new Poisoned();
                        defender.Self.AddState(NewState);
                    }
                }
            }
            if (_self.Name.Equals("Demon Lord"))
            {
                if (ShouldAdd.Next(100) < 15)
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
                if (ShouldAdd.Next(100) < 15)
                {
                    for (int i = 0; i < defender.Self.MyStates.Count; i++)
                    {
                        if (defender.Self.MyStates[i].Name.Equals("Poisoned"))
                        {
                            int tmpTurns = defender.Self.MyStates[i].Turns;
                            tmpTurns += 2;
                            defender.Self.MyStates[i].Turns = tmpTurns;
                            shouldAdd = false;
                        }
                    }
                    if (shouldAdd)
                    {
                        IStates NewState = new Poisoned();
                        defender.Self.AddState(NewState);
                    }
                }
                shouldAdd = true;
                if (ShouldAdd.Next(100) < 10)
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
                shouldAdd = true;
                if (ShouldAdd.Next(100) < 20)
                {
                    for (int i = 0; i < defender.Self.MyStates.Count; i++)
                    {
                        if (defender.Self.MyStates[i].Name.Equals("Cursed"))
                        {
                            int tmpTurns = defender.Self.MyStates[i].Turns;
                            tmpTurns += 1;
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
            }
        }
        public void Attack(IRole defender)
        {
            Random NoMiss = new Random();
            if(NoMiss.Next(100) < _self.Accuracy - defender.Self.Swiftness)
            {
                int defHP = defender.Self.HP;
                if (defender.Self.Armor < _self.Strength)
                {
                    defHP = defHP - (_self.Strength - defender.Self.Armor);
                    defender.Self.HP = defHP;
                }
                
                ChangeState(defender);
            }
        }
    }
}
