using System;

namespace DnDMobile.Classes
{
    public static class StaticVariables
    {
        // General.
        public static string reset = "Reset";
        public static Random randomNumber = new Random();

        // Weapons.
        public static ItemType[] meleeTypes = { ItemType.SimpleMelee, ItemType.SimpleRanged, ItemType.MartialMelee, ItemType.MartialRanged, ItemType.Reset };

        //Armor.
        public static ItemType[] armorTypes = { ItemType.LightArmor, ItemType.MediumArmor, ItemType.HeavyArmor, ItemType.Shield, ItemType.Reset };

        // General Items.
        public static ItemType[] generalTypes = { ItemType.Ammunition, ItemType.ArcaneFocus, ItemType.DruidicFocus, ItemType.GeneralGood, ItemType.HolySymbol, ItemType.Reset };

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
