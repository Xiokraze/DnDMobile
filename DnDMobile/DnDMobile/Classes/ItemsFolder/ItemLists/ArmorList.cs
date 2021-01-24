using System.Collections.Generic;
using System.Linq;

namespace DnDMobile.Classes.ItemsFolder.ItemLists
{
    class ArmorList
    {
        public static List<Armor> LightArmor { get; } = new List<Armor>
        {
            new Armor("Padded", "5 gp", "11 + Dex Modifier", "-", "Disadvantage", "8 lbs", ItemTypes.LightArmor),
            new Armor("Leather", "10 gp", "11 + Dex Modifier", "-", "-", "10 lbs", ItemTypes.LightArmor),
            new Armor("Studded Leather", "45 gp", "12 + Dex Modifier", "-", "-", "13 lbs", ItemTypes.LightArmor)
        };


        public static List<Armor> MediumArmor { get; } = new List<Armor>
        {
            new Armor("Hide", "10 gp", "12 + Dex Modifier (Max 2)", "-", "-", "12 lbs", ItemTypes.MediumArmor),
            new Armor("Chain Shirt", "50 gp", "13 + Dex Modifier (Max 2)", "-", "-", "20 lbs", ItemTypes.MediumArmor),
            new Armor("Scale Mail", "50 gp", "14 + Dex Modifier (Max 2)", "-", "Disadvantage", "45 lbs", ItemTypes.MediumArmor),
            new Armor("Breastplate", "400 gp", "14 + Dex Modifier (Max 2)", "-", "-", "20 lbs", ItemTypes.MediumArmor),
            new Armor("Half Plate", "750 gp", "15 + Dex Modifier (Max 2)", "-", "Disadvantage", "40 lbs", ItemTypes.MediumArmor)
        };


        public static List<Armor> HeavyArmor { get; } = new List<Armor>
        {
            new Armor("Ring Mail", "30 gp", "14", "-", "Disadvantage", "40 lbs", ItemTypes.HeavyArmor),
            new Armor("Chain Mail", "75 gp", "16", "13", "Disadvantage", "55 lbs", ItemTypes.HeavyArmor),
            new Armor("Splint", "200 gp", "17", "15", "Disadvantage", "60 lbs", ItemTypes.HeavyArmor),
            new Armor("Plate", "1,500 gp", "18", "15", "Disadvantage", "65 lbs", ItemTypes.HeavyArmor)
        };


        public static List<Armor> Shields { get; } = new List<Armor>
        {
            new Armor("Shield", "10 gp", "+2", "-", "-", "6 lbs", ItemTypes.Shield)
        };


        public static List<Armor> All { get; } = ConcatenateLists();


        public static int Count { get; } = All.Count;


        private static List<Armor> ConcatenateLists()
        {
            List<Armor> items = new List<Armor>();
            items = items.Concat(LightArmor).Concat(MediumArmor).Concat(HeavyArmor).Concat(Shields).ToList();
            items.Sort((x, y) => x.Description.CompareTo(y.Description));
            return items;
        }
    }
}
