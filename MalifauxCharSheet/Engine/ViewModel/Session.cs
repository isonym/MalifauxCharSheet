using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Engine.Annotations;
using Engine.Model;

namespace Engine.ViewModel
{
    public class Session
    {
        private readonly Character _currentCharacter;

        public Character CurrentCharacter => _currentCharacter;

        public Session(string charname, string playername)
        {
            _currentCharacter = new Character(charname, playername, 10);
        }

        public void buttonAddXp_OnClick()
        {
            _currentCharacter.ModifyExperiencePoints(10);
        }

        public void buttonAddScrip_OnClick()
        {
            _currentCharacter.ModifyScrip(10);
        }
    }
}