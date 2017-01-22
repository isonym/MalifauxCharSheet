using System.ComponentModel;
using System.Runtime.CompilerServices;
using Engine.Annotations;

namespace Engine.Model
{
    public static class AspectNames
    {
        public static readonly string[] Names = new string[]
        {
            "Might", "Grace", "Speed", "Resiliance",
            "Intellect", "Charm", "Cunning", "Tenacity"
        };
    }

    public class Aspect : INotifyPropertyChanged
    {
        public string Name { get; }

        public int Level { get; private set; }

        public Aspect(string name, int level)
        {
            Name = name;
            Level = level;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}