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
            spellList.ForEach(x => 
            {
                if (x.Level == spellLevel)
                {
                    spellMatches.Add(x);
                }
            });
            return spellMatches;
        }


        public List<Spell> FilterSpellsByCastableBy(string spellCastableBy, List<Spell> spellList)
        {
            List<Spell> spellMatches = new List<Spell>();
            spellList.ForEach(x =>
            {
                if (x.CastableBy.ToLower().Contains(spellCastableBy.ToLower()))
                {
                    spellMatches.Add(x);
                }
            });
            return spellMatches;
        }


        public List<Spell> FilterSpellsBySchool(string spellSchool, List<Spell> spellList)
        {
            List<Spell> spellMatches = new List<Spell>();
            spellList.ForEach(x =>
            {
                if (x.School == spellSchool)
                {
                    spellMatches.Add(x);
                }
            });
            return spellMatches;
        }


        public List<Spell> FilterSpellsByConcentration(string spellConcentration, List<Spell> spellList)
        {
            List<Spell> spellMatches = new List<Spell>();
            spellList.ForEach(x =>
            {
                if (x.Concentration == spellConcentration)
                {
                    spellMatches.Add(x);
                }
            });
            return spellMatches;
        }


        public List<Spell> FilterSpellsByRitual(string spellRitual, List<Spell> spellList)
        {
            List<Spell> spellMatches = new List<Spell>();
            spellList.ForEach(x =>
            {
                if (x.Ritual == spellRitual)
                {
                    spellMatches.Add(x);
                }
            });
            return spellMatches;
        }


        public List<Spell> FilterSpellsBySource(string spellSource, List<Spell> spellList)
        {
            List<Spell> spellMatches = new List<Spell>();
            spellList.ForEach(x =>
            {
                if (x.Source.ToLower().Contains(spellSource.ToLower()))
                {
                    spellMatches.Add(x);
                }
            });
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
