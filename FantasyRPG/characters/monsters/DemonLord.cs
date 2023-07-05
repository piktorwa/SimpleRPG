using FantasyRPG.operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyRPG.characters.monsters
{
    internal class DemonLord : ICharacter
    {
        public DemonLord(int Turn)
        {
            _strength = 11 + 2 * Turn;
            _endurance = (int)(3 + 1.5 * Turn);
            _swiftness = (int)(5 + Turn * 0.8);
            _accuracy = (int)(170 + Turn * 0.1);
            _maxHP = _endurance * 55;
            _HP = _maxHP;
            _armor = (int)(7 + Turn * 1.7);
        }
        private string _name = "Demon Lord";
        public string Name
        {
            get
            {
                return _name;
            }
        }
        private int _strength;
        public int Strength
        {
            get { return _strength; }
            set
            {
                _strength = value;
            }
        }
        private int _endurance;
        public int Endurance
        {
            get { return _endurance; }
            set
            {
                _endurance = value;
            }
        }
        private int _swiftness;
        public int Swiftness
        {
            get { return _swiftness; }
            set
            {
                _swiftness = value;
            }
        }
        private int _accuracy;
        public int Accuracy
        {
            get { return _accuracy; }
            set
            {
                _accuracy = value;
            }
        }
        private int _HP;
        private int _maxHP;
        public int HP
        {
            get { return _HP; }
            set
            {
                _HP = value;
            }
        }
        public int MaxHP
        {
            get { return _maxHP; }
            set
            {
                _maxHP = value;
            }
        }
        private int _armor;
        public int Armor
        {
            get { return _armor; }
            set { _armor = value; }
        }
        private List<IStates> _myStates = new List<IStates> { };
        public List<IStates> MyStates
        {
            get { return _myStates; }
        }
        public void AddState(IStates NewState)
        {
            _myStates.Add(NewState);
        }
        public void RemoveState(int index)
        {
            if (_myStates.Count == 0) return;
            _myStates.RemoveAt(index);
        }
        public int Experience { get; set; } = 100000;
        public int Level
        {
            get;
            set;
        }
    }
}
