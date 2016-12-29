using System.Collections.Generic;

namespace Engine.Model
{
    public class Character
    {
        private readonly string _name;
        private readonly string _playerName;
        private double _scrip;
        private int _experiencePoints;

        private List<Item> _inventory;
        private List<Aspect> _aspects;
        private List<Skill> _skills;
        private List<Spell> _spells;

        public string Name => _name;

        public string PlayerName => _playerName;

        public double Scrip => _scrip;

        public int ExperiencePoints => _experiencePoints;

        public Character()
        {
            _experiencePoints = 0;

            _inventory = new List<Item>();
            _aspects = new List<Aspect>();
            _skills = new List<Skill>();
            _spells = new List<Spell>();
        }

        public Character(string name, string playerName, double scrip) : this()
        {
            _name = name;
            _playerName = playerName;
            _scrip = scrip;
        }
    }
}