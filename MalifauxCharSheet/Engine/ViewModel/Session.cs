using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Engine.Model;

namespace Engine.ViewModel
{
    public class Session : INotifyPropertyChanged
    {
        private readonly Character _currentCharacter;

        public Character CurrentCharacter => _currentCharacter;

        public ObservableCollection<Item> Inventory => new ObservableCollection<Item>(CurrentCharacter.Inventory);

        public Session()
        {
            _currentCharacter = new Character("Isonym", "James", 10);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void buttonAddXp_OnClick()
        {
            _currentCharacter.AddXp(10);
            OnPropertyChanged();
        }
    }
}