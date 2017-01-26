using System.Collections.Generic;

namespace Engine.Model
{
    public class Spell
    {
        public Magia Magia { get; }
        public Immuto Immuto { get; }

        public Spell(Magia magia, Immuto immuto)
        {
            Magia = magia;
            Immuto = immuto;
        }

        public static List<Spell> GenerateSpellCombinations(IEnumerable<Magia> magias, IEnumerable<Immuto> immutos)
        {
            List<Spell> spells = new List<Spell>();

            foreach (Magia magia in magias)
            {
                foreach (Immuto immuto in immutos)
                {
                    spells.Add(new Spell(magia, immuto));
                }
            }

            return spells;
        }

        public override string ToString()
        {
            return $"<Spell {Magia} + {Immuto}>";
        }
    }
}