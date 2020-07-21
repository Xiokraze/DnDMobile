using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace DnDMobile.Classes
{
    class Spells
    {
        public List<Spell> SpellList { get; } = SetSpellList();


        public Spells() { }


        public List<Spell> GetSpellList()
        {
            return SpellList;
        }


        private static List<Spell> SetSpellList()
        {
            List<Spell> SpellList = new List<Spell>();
            try
            {
                var assembly = Assembly.GetExecutingAssembly();
                var resourceName = "DnDMobile.spells.txt";
                string line;
                using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                using (StreamReader reader = new StreamReader(stream))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        try
                        {
                            Spell spell = JsonConvert.DeserializeObject<Spell>(line);
                            if (spell != null)
                            {
                                SpellList.Add(spell);
                            }
                        }
                        catch
                        {
                            continue;
                        }
                    }
                }
            }
            catch { }
            return SpellList;
        }
    }
}
