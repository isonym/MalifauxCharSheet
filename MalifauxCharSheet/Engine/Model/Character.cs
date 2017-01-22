using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Engine.Annotations;

namespace Engine.Model
{
    public class Character : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

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

        public double Scrip
        {
            get { return _scrip; }
            private set
            {
                _scrip = value;
                OnPropertyChanged();
            }
        }

        public int ExperiencePoints
        {
            get { return _experiencePoints; }
            private set
            {
                _experiencePoints = value;
                OnPropertyChanged();
            }
        }

        public List<Item> Inventory => _inventory;
        public List<Aspect> Aspects => _aspects;
        public List<Skill> Skills => _skills;
        public List<Spell> Spells => _spells;

        public Character()
        {
            _experiencePoints = 0;

            _inventory = new List<Item>();

            _aspects = new List<Aspect>();
            foreach (string name in AspectNames.Names)
            {
                Aspects.Add(new Aspect(name, 0));
            }

            _skills = new List<Skill>();
            _spells = new List<Spell>();
        }

        public Character(string name, string playerName, double scrip) : this()
        {
            _name = name;
            _playerName = playerName;
            _scrip = scrip;

            AddInventoryItem("Fish", 5.0, 2);
        }

        public void AddInventoryItem(string name, double weight, int quantity = 1)
        {
            Inventory.Add(new Item(name, weight, quantity));
            OnPropertyChanged("Inventory");
        }

        public void ModifyExperiencePoints(int xp)
        {
            ExperiencePoints += xp;
            AddInventoryItem("Potato", 10.0);
        }

        public void ModifyScrip(double modify)
        {
            Scrip += modify;
        }


        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}