using FantasyRPG.operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyRPG
{
    internal interface ICharacter
    {
        //baza dla wszystkich typów postaci (od grywalnych po potwory)
        string Name { get; }
        int Strength { get; set; }
        int Endurance { get; set; }
        int Swiftness { get; set; }
        int Accuracy { get; set; }
        int HP { get; set; } //Hit Points
        int MaxHP { get; set; }
        int Armor { get; set; }
        int Level { get; set; }
        int Experience { get; set; }
        List<IStates> MyStates { get; }
        void AddState(IStates state);
        void RemoveState(int index);
    }
}
