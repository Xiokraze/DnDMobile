using System;

namespace DnDMobile.Classes
{
    public static class StaticVariables
    {
        // General.
        public static string reset = "Reset";
        public static Random randomNumber = new Random();

        // Weapons.
        public static ItemTypes[] meleeTypes = { ItemTypes.SimpleMelee, ItemTypes.SimpleRanged, ItemTypes.MartialMelee, ItemTypes.MartialRanged, ItemTypes.Reset };

        //Armor.
        public static ItemTypes[] armorTypes = { ItemTypes.LightArmor, ItemTypes.MediumArmor, ItemTypes.HeavyArmor, ItemTypes.Shield, ItemTypes.Reset };

        // General Items.
        public static ItemTypes[] generalTypes = { ItemTypes.Ammunition, ItemTypes.ArcaneFocus, ItemTypes.DruidicFocus, ItemTypes.GeneralGood, ItemTypes.HolySymbol, ItemTypes.Reset };

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
