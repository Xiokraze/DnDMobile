using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace DnDMobile.Classes
{
    class Spells
    {
        public static List<Spell> All { get; } = FetchSpells();

        public static int Count { get; } = All.Count;


        public Spells() { }


        public List<Spell> FilterSpellsByLevel(string spellLevel, List<Spell> spellList)
        {
            List<Spell> spellMatches = new List<Spell>();
            foreach (Spell spell in spellList)
            {
                if (spell.Level == spellLevel)
                {
                    spellMatches.Add(spell);
                }
            }
            return spellMatches;
        }


        public List<Spell> FilterSpellsByCastableBy(string spellCastableBy, List<Spell> spellList)
        {
            List<Spell> spellMatches = new List<Spell>();
            foreach (Spell spell in spellList)
            {
                if (spell.CastableBy.ToLower().Contains(spellCastableBy.ToLower()))
                {
                    spellMatches.Add(spell);
                }
            }
            return spellMatches;
        }


        public List<Spell> FilterSpellsBySchool(string spellSchool, List<Spell> spellList)
        {
            List<Spell> spellMatches = new List<Spell>();
            foreach (Spell spell in spellList)
            {
                if (spell.School == spellSchool)
                {
                    spellMatches.Add(spell);
                }
            }
            return spellMatches;
        }


        public List<Spell> FilterSpellsByConcentration(string spellConcentration, List<Spell> spellList)
        {
            List<Spell> spellMatches = new List<Spell>();
            foreach (Spell spell in spellList)
            {
                if (spell.Concentration == spellConcentration)
                {
                    spellMatches.Add(spell);
                }
            }
            return spellMatches;
        }


        public List<Spell> FilterSpellsByRitual(string spellRitual, List<Spell> spellList)
        {
            List<Spell> spellMatches = new List<Spell>();
            foreach (Spell spell in spellList)
            {
                if (spell.Ritual == spellRitual)
                {
                    spellMatches.Add(spell);
                }
            }
            return spellMatches;
        }


        public List<Spell> FilterSpellsBySource(string spellSource, List<Spell> spellList)
        {
            List<Spell> spellMatches = new List<Spell>();
            foreach (Spell spell in spellList)
            {
                if (spell.Source.ToLower().Contains(spellSource.ToLower()))
                {
                    spellMatches.Add(spell);
                }
            }
            return spellMatches;
        }


        private static List<Spell> FetchSpells()
        {
            List<Spell> spellList = new List<Spell>();
            var assembly = Assembly.GetExecutingAssembly();
            using (Stream stream = assembly.GetManifestResourceStream("DnDMobile.completedSpells.txt"))
            using (StreamReader reader = new StreamReader(stream))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Spell spell = JsonConvert.DeserializeObject<Spell>(line);
                    spellList.Add(spell);
                }
            }
            return spellList;
        }
    }
}
