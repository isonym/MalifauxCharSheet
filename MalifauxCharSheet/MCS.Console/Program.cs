using Engine.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Data;

namespace MCS.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Magia> magias = FromDataFactory.GetAll<Magia>();
            List<Immuto> immutos = FromDataFactory.GetAll<Immuto>();

            List<Spell> spells = Spell.GenerateSpellCombinations(magias, immutos);
            foreach (Spell spell in spells)
            {
                System.Console.WriteLine(spell);
            }

            System.Console.ReadLine();
        }
    }
}
