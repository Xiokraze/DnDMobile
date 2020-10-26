using System;
using System.Collections.Generic;
using System.Text;

namespace DnDMobile.Classes
{
    public static class StaticVariables
    {
        // General.
        public static string reset = "Reset";

        // Weapons.
        public static string simpleMelee = "Simple Melee";
        public static string simpleRanged = "Simple Ranged";
        public static string martialMelee = "Martial Melee";
        public static string martialRanged = "Martial Ranged";
        public static string[] meleeTypes = { simpleMelee, simpleRanged, martialMelee, martialRanged, reset };

        //Armor.
        public static string lightAmor = "Light Armor";
        public static string mediumAmor = "Medium Armor";
        public static string heavyAmor = "Heavy Armor";
        public static string shields = "Shields";
        public static string[] armorTypes = { lightAmor, mediumAmor, heavyAmor, shields, reset};

        // General Items.
        public static string ammunition = "Ammunition";
        public static string arcaneFocus = "Arcane Focus";
        public static string druidicFocus = "Druidic Focus";
        public static string generalGood = "General Good";
        public static string holySymbol = "Holy Symbol";
        public static string[] generalTypes = { ammunition, arcaneFocus, druidicFocus, generalGood, holySymbol, reset };
    }
}
