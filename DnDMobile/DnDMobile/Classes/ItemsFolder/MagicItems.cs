using System;
using System.Collections.Generic;
using System.Text;

namespace DnDMobile.Classes.ItemsFolder
{
    class MagicItems
    {
        private readonly RollDice rollDice = new RollDice();
        private readonly Spells spellList = new Spells();


        public string RollD100TableA()
        {
            string result;
            int roll = rollDice.RollRandom(1, 100);
            if (roll >= 1 && roll <= 50)
            {
                result = "Potion of Healing";
            }
            else if (roll >= 51 && roll <= 60)
            {
                List<Spell> spells = spellList.FilterSpellsByLevel("0", spellList.GetSpellList());
                int spellIndex = rollDice.RollRandom(1, spells.Count) - 1;
                result = "Spell scroll of " + spells[spellIndex].Name;
            }
            else if (roll >= 61 && roll <= 70)
            {
                result = "Potion of climbing";
            }
            else if (roll >= 71 && roll <= 90)
            {
                List<Spell> spells = spellList.FilterSpellsByLevel("1", spellList.GetSpellList());
                int spellIndex = rollDice.RollRandom(1, spells.Count) - 1;
                result = "Spell scroll of " + spells[spellIndex].Name;
            }
            else if (roll >= 91 && roll <= 94)
            {
                List<Spell> spells = spellList.FilterSpellsByLevel("2", spellList.GetSpellList());
                int spellIndex = rollDice.RollRandom(1, spells.Count) - 1;
                result = "Spell scroll of " + spells[spellIndex].Name;
            }
            else if (roll >= 95 && roll <= 98)
            {
                result = "Potion of Greater Healing";
            }
            else if (roll == 99)
            {
                result = "Bag of Holding";
            }
            else
            {
                result = "Driftglobe";
            }
            return result;
        }
    }
}
