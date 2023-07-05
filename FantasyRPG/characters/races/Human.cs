using FantasyRPG.operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace FantasyRPG
{
    internal class Human : ICharacter
    {
        public Human() 
        {
            _strength = 10;
            _endurance = 10;
            _swiftness = 10;
            _accuracy = 90;
            _maxHP = _endurance * 50;
            _HP = _maxHP;
            _level = 1;
            _experience = 0;
        }
        private string _name = "Human";
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
        private int _experience;
        public int Experience
        {
            get { return _experience; }
            set { _experience = value; }
        }
        private int _level;
        public int Level 
        { 
            get { return _level; }
            set { _level = value; }
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
        public void ShowStats()
        {
            Console.WriteLine("Stats");
            Console.WriteLine("Level: " + _level);
            Console.WriteLine("Strength: " + _strength);
            Console.WriteLine("Endurance: " + _endurance);
            Console.WriteLine("Swiftness: " + _swiftness);
            Console.WriteLine("Accuracy: " + _accuracy);
            Console.WriteLine("Armor: " + _armor);
        }
    }
}
