using Engine.Model;

namespace Engine.ViewModel
{
    public class Session
    {
        public Character CurrentCharacter { get; set; }

        public Session()
        {
            CurrentCharacter = new Character("Isonym", "James", 10);
        }
    }
}