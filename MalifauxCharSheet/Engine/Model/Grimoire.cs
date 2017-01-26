using System.Collections.Generic;
using Engine.Data;

namespace Engine.Model
{
    public class Grimoire : Item
    {
        public List<Magia> Magias { get; }
        public List<Immuto> Immutos { get; }

        public List<Spell> Spells { get; }

        public Grimoire(string name, double cost, string[] magias, string[] immutos, int quantity = 1) : base(name, cost, quantity)
        {
            Magias = new List<Magia>();
            Immutos = new List<Immuto>();
            Spells = new List<Spell>();

            foreach (string immutoString in immutos)
            {
                Immutos.Add(FromDataFactory.Get<Immuto>(immutoString));
            }

            foreach (string magiaString in magias)
            {
                Magias.Add(FromDataFactory.Get<Magia>(magiaString));
            }

            Spells = Spell.GenerateSpellCombinations(Magias, Immutos);
        }
    }
}