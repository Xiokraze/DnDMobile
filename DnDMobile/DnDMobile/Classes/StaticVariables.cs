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

        // Gems.
        public static string gp10 = "10 gp";
        public static string gp50 = "50 gp";
        public static string gp100 = "100 gp";
        public static string gp500 = "500 gp";
        public static string gp1000 = "1000 gp";
        public static string gp5000 = "5000 gp";
        public static string[] gemTypes = { gp10, gp50, gp100, gp500, gp1000, gp5000, reset };

        // Art. 
        public static string gp25 = "25 gp";
        public static string gp250 = "250 gp";
        public static string gp750 = "750 gp";
        public static string gp2500 = "2500 gp";
        public static string gp7500 = "7500 gp";
        public static string[] artTypes = { gp25, gp250, gp750, gp2500, gp7500, reset };
    }
}
