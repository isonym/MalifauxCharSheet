using System.ComponentModel;
using System.Runtime.CompilerServices;
using Engine.Model;
using ViewModel.Annotations;

namespace ViewModel
{
    public class CharacterView : INotifyPropertyChanged
    {
        private Character _character;

        public event PropertyChangedEventHandler PropertyChanged;

        public CharacterView()
        {
            _character = new Character();
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}