using System.Collections.Generic;

namespace Engine.Model
{
    public class Spell
    {
        private readonly List<Magia> _magias;
        private readonly List<Immuto> _immutos;

        public List<Magia> Magias => _magias;
        public List<Immuto> Immutos => _immutos;

        public Spell()
        {
            _magias = new List<Magia>();
            _immutos = new List<Immuto>();
        }

        public Spell(Magia magia, Immuto immuto) : this()
        {
            _magias.Add(magia);
            _immutos.Add(immuto);
        }

        public Spell(List<Magia> magias, List<Immuto> immutos)
        {
            _magias = magias;
            _immutos = immutos;
        }
    }
}